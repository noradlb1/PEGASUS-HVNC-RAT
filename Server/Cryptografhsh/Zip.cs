namespace PEGASUS.Cryptografhsh
{
    using System;
    using System.IO;
    using System.IO.Compression;

    /// <summary>
    /// Defines the <see cref="Zip" />.
    /// </summary>
    public static class Zip
    {
        /// <summary>
        /// The Decompress.
        /// </summary>
        /// <param name="input">The input<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        public static byte[] Decompress(byte[] input)
        {
            using (var source = new MemoryStream(input))
            {
                var lengthBytes = new byte[4];
                source.Read(lengthBytes, 0, 4);

                var length = BitConverter.ToInt32(lengthBytes, 0);
                using (var decompressionStream = new GZipStream(source,
                           CompressionMode.Decompress))
                {
                    var result = new byte[length];
                    decompressionStream.Read(result, 0, length);
                    return result;
                }
            }
        }

        /// <summary>
        /// The Compress.
        /// </summary>
        /// <param name="input">The input<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        public static byte[] Compress(byte[] input)
        {
            using (var result = new MemoryStream())
            {
                var lengthBytes = BitConverter.GetBytes(input.Length);
                result.Write(lengthBytes, 0, 4);

                using (var compressionStream = new GZipStream(result,
                           CompressionMode.Compress))
                {
                    compressionStream.Write(input, 0, input.Length);
                    compressionStream.Flush();
                }

                return result.ToArray();
            }
        }
    }
}
