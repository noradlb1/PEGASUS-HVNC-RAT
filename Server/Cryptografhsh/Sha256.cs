namespace PEGASUS.Cryptografhsh
{
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="Sha256" />.
    /// </summary>
    public static class Sha256
    {
        /// <summary>
        /// The ComputeHash.
        /// </summary>
        /// <param name="input">The input<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ComputeHash(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);

            using (var sha = new SHA256Managed())
            {
                data = sha.ComputeHash(data);
            }

            var hash = new StringBuilder();

            foreach (var _byte in data)
                hash.Append(_byte.ToString("X2"));

            return hash.ToString().ToUpper();
        }

        /// <summary>
        /// The ComputeHash.
        /// </summary>
        /// <param name="input">The input<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        public static byte[] ComputeHash(byte[] input)
        {
            using (var sha = new SHA256Managed())
            {
                return sha.ComputeHash(input);
            }
        }
    }
}
