namespace PEGASUS.Cryptografhsh
{
    using System;
    using System.IO;
    using System.IO.Compression;

    /// <summary>
    /// Defines the <see cref="GZip" />.
    /// </summary>
    public class GZip
    {
        /// <summary>
        /// The Compress.
        /// </summary>
        /// <param name="buff">The buff<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        public static byte[] Compress(byte[] buff)
        {
            using (var memoryStream = new MemoryStream())
            {
                var bytes = BitConverter.GetBytes(buff.Length);
                memoryStream.Write(bytes, 0, 4);
                using (var gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    gzipStream.Write(buff, 0, buff.Length);
                    gzipStream.Flush();
                }

                return memoryStream.ToArray();
            }
        }

        /// <summary>
        /// The Decompress.
        /// </summary>
        /// <param name="buff">The buff<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="byte[]"/>.</returns>
        public static byte[] Decompress(byte[] buff)
        {
            using (var memoryStream = new MemoryStream(buff))
            {
                var buffer1 = new byte[4];
                memoryStream.Read(buffer1, 0, 4);
                var int32 = BitConverter.ToInt32(buffer1, 0);
                using (var gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    var buffer2 = new byte[int32];
                    gzipStream.Read(buffer2, 0, int32);

                    return buffer2;
                }
            }
        }
    }
}
