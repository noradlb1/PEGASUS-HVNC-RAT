using Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Plugin
{
    class StrCrypt // StrCrypt.Decrypt(
    {
        public static string Decrypt(string str)
        {
            var value = Convert.FromBase64String(str);
            string r = string.Empty;
            if (value != null && value.Length > 0)
            {
                using (MemoryStream strm = new MemoryStream(value))
                using (GZipStream zip = new GZipStream(strm, CompressionMode.Decompress))
                using (StreamReader reader = new StreamReader(zip))
                {
                    r = reader.ReadToEnd();
                }
            }
            return r;
        }

    }
}
