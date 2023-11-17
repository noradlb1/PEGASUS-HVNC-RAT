namespace PEGASUS.Cryptografhsh
{
    using System;
    using System.IO;
    using System.Security.Cryptography;

    /// <summary>
    /// Defines the <see cref="GetHash" />.
    /// </summary>
    public static class GetHash
    {
        /// <summary>
        /// The GetChecksum.
        /// </summary>
        /// <param name="file">The file<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetChecksum(string file)
        {
            using (var stream = File.OpenRead(file))
            {
                var sha = new SHA256Managed();
                var checksum = sha.ComputeHash(stream);
                return BitConverter.ToString(checksum).Replace("-", string.Empty);
            }
        }
    }
}
