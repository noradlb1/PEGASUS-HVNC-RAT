using System;
using System.Security.Cryptography;
using System.Text;

namespace Plugin.Handle
{
    public static class Pikolo
    {
        public static string DePikoloData(string Message)
        {
            var uTF8Encoding = new UTF8Encoding();
            var mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            var key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes("CqbkTHriRRbQjaArtJfF"));
            var tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            tripleDESCryptoServiceProvider.Key = key;
            tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
            tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            var array = Convert.FromBase64String(Message);
            byte[] bytes;
            try
            {
                bytes = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
            }
            finally
            {
                tripleDESCryptoServiceProvider.Clear();
                mD5CryptoServiceProvider.Clear();
            }

            return uTF8Encoding.GetString(bytes);
        }

        public static string PikoloData(string Message)
        {
            var uTF8Encoding = new UTF8Encoding();
            var mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
            var key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes("CqbkTHriRRbQjaArtJfF"));
            var tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            tripleDESCryptoServiceProvider.Key = key;
            tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
            tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
            var bytes = uTF8Encoding.GetBytes(Message);
            byte[] inArray;
            try
            {
                inArray = tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            }
            finally
            {
                tripleDESCryptoServiceProvider.Clear();
                mD5CryptoServiceProvider.Clear();
            }

            return Convert.ToBase64String(inArray);
        }
    }
}