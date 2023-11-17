using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace Plugin
{
    class HWIDGen // HWIDGen.HWID();
    {
        public static string HWID()
        {
            try
            {
                return GetHash(Environment.ProcessorCount.ToString() + Environment.UserName + Environment.MachineName + (object)Environment.OSVersion + (object)new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize);
            }
            catch
            {
                return "ErrorHWID.log";
            }
        }

        public static string GetHash(string strToHash)
        {
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(strToHash));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte num in hash)
                stringBuilder.Append(num.ToString("x2"));
            return stringBuilder.ToString().Substring(0, 20).ToUpper();
        }
    }
}
