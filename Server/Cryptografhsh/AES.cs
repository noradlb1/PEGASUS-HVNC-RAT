namespace PEGASUS.Cryptografhsh
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="AES" />.
    /// </summary>
    public static class AES
    {
        /// <summary>
        /// Defines the IvLength.
        /// </summary>
        private const int IvLength = 16;

        /// <summary>
        /// Defines the HmacSha256Length.
        /// </summary>
        private const int HmacSha256Length = 32;

        /// <summary>
        /// Defines the _defaultKey.
        /// </summary>
        private static byte[] _defaultKey;

        /// <summary>
        /// Defines the _defaultAuthKey.
        /// </summary>
        private static byte[] _defaultAuthKey;

        /// <summary>
        /// Defines the Salt.
        /// </summary>
        public static readonly byte[] Salt =
        {
            0xBF, 0xEB, 0x1E, 0x56, 0xFB, 0xCD, 0x97, 0x3B, 0xB2, 0x19, 0x2, 0x24, 0x30, 0xA5, 0x78, 0x43, 0x0, 0x3D,
            0x56,
            0x44, 0xD2, 0x1E, 0x62, 0xB9, 0xD4, 0xF1, 0x80, 0xE7, 0xE6, 0xC3, 0x39, 0x41
        };

        /// <summary>
        /// The SetDefaultKey.
        /// </summary>
        /// <param name="key">The key<see cref="string"/>.</param>
        public static void SetDefaultKey(string key)
        {
            using (var derive = new Rfc2898DeriveBytes(key, Salt, 50000))
            {
                _defaultKey = derive.GetBytes(16);
                _defaultAuthKey = derive.GetBytes(64);
            }
        }

        /// <summary>
        /// The Encrypt.
        /// </summary>
        /// <param name="input">The input<see cref="string"/>.</param>
        /// <param name="key">The key<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Encrypt(string input, string key)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input), Encoding.UTF8.GetBytes(key)));
        }

        /// <summary>
        /// The Encrypt.
        /// </summary>
        /// <param name="input">The input<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Encrypt(string input)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input)));
        }

        /* FORMAT
         * ----------------------------------------
         * |     HMAC     |   IV   |  CIPHERTEXT  |
         * ----------------------------------------
         *     32 bytes    16 bytes
         */
        /// <summary>
        /// The Encrypt.
        /// </summary>
        /// <param name="input">The input<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        public static byte[] Encrypt(byte[] input)
        {
            if (_defaultKey == null || _defaultKey.Length == 0) throw new Exception("Key can not be empty.");
            if (input == null || input.Length == 0) throw new ArgumentException("Input can not be empty.");

            byte[] data = input, encdata = new byte[0];

            try
            {
                using (var ms = new MemoryStream())
                {
                    ms.Position = HmacSha256Length; // reserve first 32 bytes for HMAC
                    using (var aesProvider = new AesCryptoServiceProvider())
                    {
                        aesProvider.KeySize = 128;
                        aesProvider.BlockSize = 128;
                        aesProvider.Mode = CipherMode.CBC;
                        aesProvider.Padding = PaddingMode.PKCS7;
                        aesProvider.Key = _defaultKey;
                        aesProvider.GenerateIV();

                        using (var cs = new CryptoStream(ms, aesProvider.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            ms.Write(aesProvider.IV, 0,
                                aesProvider.IV.Length); // write next 16 bytes the IV, followed by ciphertext
                            cs.Write(data, 0, data.Length);
                            cs.FlushFinalBlock();

                            using (var hmac = new HMACSHA256(_defaultAuthKey))
                            {
                                var hash = hmac.ComputeHash(ms.ToArray(), HmacSha256Length,
                                    ms.ToArray().Length - HmacSha256Length); // compute the HMAC of IV and ciphertext
                                ms.Position = 0; // write hash at beginning
                                ms.Write(hash, 0, hash.Length);
                            }
                        }
                    }

                    encdata = ms.ToArray();
                }
            }
            catch
            {
            }

            return encdata;
        }

        /// <summary>
        /// The Encrypt.
        /// </summary>
        /// <param name="input">The input<see cref="byte[]"/>.</param>
        /// <param name="key">The key<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        public static byte[] Encrypt(byte[] input, byte[] key)
        {
            if (key == null || key.Length == 0) throw new Exception("Key can not be empty.");

            byte[] authKey;
            using (var derive = new Rfc2898DeriveBytes(key, Salt, 50000))
            {
                key = derive.GetBytes(16);
                authKey = derive.GetBytes(64);
            }

            byte[] data = input, encdata = new byte[0];

            try
            {
                using (var ms = new MemoryStream())
                {
                    ms.Position = HmacSha256Length; // reserve first 32 bytes for HMAC
                    using (var aesProvider = new AesCryptoServiceProvider())
                    {
                        aesProvider.KeySize = 128;
                        aesProvider.BlockSize = 128;
                        aesProvider.Mode = CipherMode.CBC;
                        aesProvider.Padding = PaddingMode.PKCS7;
                        aesProvider.Key = key;
                        aesProvider.GenerateIV();

                        using (var cs = new CryptoStream(ms, aesProvider.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            ms.Write(aesProvider.IV, 0,
                                aesProvider.IV.Length); // write next 16 bytes the IV, followed by ciphertext
                            cs.Write(data, 0, data.Length);
                            cs.FlushFinalBlock();

                            using (var hmac = new HMACSHA256(authKey))
                            {
                                var hash = hmac.ComputeHash(ms.ToArray(), HmacSha256Length,
                                    ms.ToArray().Length - HmacSha256Length); // compute the HMAC of IV and ciphertext
                                ms.Position = 0; // write hash at beginning
                                ms.Write(hash, 0, hash.Length);
                            }
                        }
                    }

                    encdata = ms.ToArray();
                }
            }
            catch
            {
            }

            return encdata;
        }

        /// <summary>
        /// The Decrypt.
        /// </summary>
        /// <param name="input">The input<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string Decrypt(string input)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input)));
        }

        /// <summary>
        /// The Decrypt.
        /// </summary>
        /// <param name="input">The input<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        public static byte[] Decrypt(byte[] input)
        {
            if (_defaultKey == null || _defaultKey.Length == 0) throw new Exception("Key can not be empty.");
            if (input == null || input.Length == 0) throw new ArgumentException("Input can not be empty.");

            var data = new byte[0];

            try
            {
                using (var ms = new MemoryStream(input))
                {
                    using (var aesProvider = new AesCryptoServiceProvider())
                    {
                        aesProvider.KeySize = 128;
                        aesProvider.BlockSize = 128;
                        aesProvider.Mode = CipherMode.CBC;
                        aesProvider.Padding = PaddingMode.PKCS7;
                        aesProvider.Key = _defaultKey;

                        // read first 32 bytes for HMAC
                        using (var hmac = new HMACSHA256(_defaultAuthKey))
                        {
                            var hash = hmac.ComputeHash(ms.ToArray(), HmacSha256Length,
                                ms.ToArray().Length - HmacSha256Length);
                            var receivedHash = new byte[HmacSha256Length];
                            ms.Read(receivedHash, 0, receivedHash.Length);

                            if (!CryptographyHelper.AreEqual(hash, receivedHash))
                                return data;
                        }

                        var iv = new byte[IvLength];
                        ms.Read(iv, 0, IvLength); // read next 16 bytes for IV, followed by ciphertext
                        aesProvider.IV = iv;

                        using (var cs = new CryptoStream(ms, aesProvider.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            var temp = new byte[ms.Length - IvLength + 1];
                            data = new byte[cs.Read(temp, 0, temp.Length)];
                            Buffer.BlockCopy(temp, 0, data, 0, data.Length);
                        }
                    }
                }
            }
            catch
            {
            }

            return data;
        }
    }
}
