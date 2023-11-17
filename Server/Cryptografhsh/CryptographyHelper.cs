namespace PEGASUS.Cryptografhsh
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;

    /// <summary>
    /// Defines the <see cref="CryptographyHelper" />.
    /// </summary>
    public static class CryptographyHelper
    {
        /// <summary>
        /// Compares two byte arrays for equality.
        /// </summary>
        /// <param name="a1">Byte array to compare.</param>
        /// <param name="a2">Byte array to compare.</param>
        /// <returns>True if equal, else false.</returns>
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public static bool AreEqual(byte[] a1, byte[] a2)
        {
            var result = true;
            for (var i = 0; i < a1.Length; ++i)
                if (a1[i] != a2[i])
                    result = false;
            return result;
        }

        /// <summary>
        /// The DeriveKeys.
        /// </summary>
        /// <param name="password">The password<see cref="string"/>.</param>
        /// <param name="key">The key<see cref="string"/>.</param>
        /// <param name="authKey">The authKey<see cref="string"/>.</param>
        public static void DeriveKeys(string password, out string key, out string authKey)
        {
            using (var derive = new Rfc2898DeriveBytes(password, AES.Salt, 50000))
            {
                key = Convert.ToBase64String(derive.GetBytes(16));
                authKey = Convert.ToBase64String(derive.GetBytes(64));
            }
        }
    }
}
