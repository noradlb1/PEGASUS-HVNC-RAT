using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Plugin
{
    class AntiVM
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CheckRemoteDebuggerPresent(
          IntPtr hProcess,
          ref bool isDebuggerPresent);
        public static bool GetDetectVM()
        {
            using (ManagementObjectCollection managementObject = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem").Get())
            {
                foreach (ManagementBaseObject managementBaseObject in managementObject)
                {
                    try
                    {
                        string str = managementBaseObject["Manufacturer"].ToString().ToLower();
                        bool strTo = managementBaseObject["Model"].ToString().ToLower().Contains("virtual");
                        if ((str.Equals("microsoft corporation") && strTo) || str.Contains("vmware") || managementBaseObject["Model"].ToString().Equals("VirtualBox"))
                        {
                            return true;
                        }
                    }
                    catch (Exception) { return false; }
                }
            }
            return false;
        }

        public static bool IsDebuggerAttached(Process process)
        {
            try
            {
                bool isDebuggerAttached = false;
                CheckRemoteDebuggerPresent(process.Handle, ref isDebuggerAttached);
                return isDebuggerAttached;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static bool IsRdpAvailable => SystemInformation.TerminalServerSession == true ? true : false;
        private static bool SBieDLL() => Process.GetProcessesByName("wsnm").Length <= 0 && GetModuleHandle("SbieDll.dll").ToInt32() == 0 ? false : true;
        public static bool GetCheckVM() => IsDebuggerAttached(Process.GetCurrentProcess()) || SBieDLL() || IsRdpAvailable || GetDetectVM() ? true : false;
    }
}
