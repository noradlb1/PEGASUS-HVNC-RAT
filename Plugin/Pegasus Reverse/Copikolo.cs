using System;

namespace Plugin
{

    public static class Copikolo
    {
        public const int QLZ_VERSION_MAJOR = 1;

        public const int QLZ_VERSION_MINOR = 5;

        public const int QLZ_VERSION_REVISION = 0;

        public const int QLZ_STREAMING_BUFFER = 0;

        public const int QLZ_MEMORY_SAFE = 0;

        private const int HASH_VALUES = 4096;

        private const int MINOFFSET = 2;

        private const int UNCONDITIONAL_MATCHLEN = 6;

        private const int UNCOMPRESSED_END = 4;

        private const int CWORD_LEN = 4;

        private const int DEFAULT_HEADERLEN = 9;

        private const int QLZ_POINTERS_1 = 1;

        private const int QLZ_POINTERS_3 = 16;

        private static int headerLen(byte[] source)
        {
            if ((source[0] & 2) != 2) return 3;
            return 9;
        }

        public static int sizeDecompressed(byte[] source)
        {
            if (headerLen(source) == 9) return source[5] | (source[6] << 8) | (source[7] << 16) | (source[8] << 24);
            return source[2];
        }

        public static int sizeCompressed(byte[] source)
        {
            if (headerLen(source) == 9) return source[1] | (source[2] << 8) | (source[3] << 16) | (source[4] << 24);
            return source[1];
        }

        private static void write_header(byte[] dst, int level, bool compressible, int size_compressed,
            int size_decompressed)
        {
            dst[0] = (byte)(2u | (compressible ? 1u : 0u));
            dst[0] |= (byte)(level << 2);
            dst[0] |= 64;
            dst[0] |= 0;
            fast_write(dst, 1, size_decompressed, 4);
            fast_write(dst, 5, size_compressed, 4);
        }

        public static byte[] compress(byte[] source, int level)
        {
            var i = 0;
            var num = 13;
            var num2 = 2147483648u;
            var i2 = 9;
            var array = new byte[source.Length + 400];
            var array2 = new int[4096];
            var array3 = new byte[4096];
            var num3 = 0;
            var num4 = source.Length - 6 - 4 - 1;
            var num5 = 0;
            if (level != 1 && level != 3) throw new ArgumentException("C# version only supports level 1 and 3");
            var array4 = level != 1 ? new int[4096, 16] : new int[4096, 1];
            if (source.Length == 0) return new byte[0];
            if (i <= num4) num3 = source[i] | (source[i + 1] << 8) | (source[i + 2] << 16);
            byte[] array5;
            while (i <= num4)
            {
                if ((num2 & 1) == 1)
                {
                    if (i > source.Length >> 1 && num > i - (i >> 5))
                    {
                        array5 = new byte[source.Length + 9];
                        write_header(array5, level, false, source.Length, source.Length + 9);
                        Array.Copy(source, 0, array5, 9, source.Length);
                        return array5;
                    }

                    fast_write(array, i2, (int)(num2 >> 1) | int.MinValue, 4);
                    i2 = num;
                    num += 4;
                    num2 = 2147483648u;
                }

                if (level == 1)
                {
                    var num6 = ((num3 >> 12) ^ num3) & 0xFFF;
                    var num7 = array4[num6, 0];
                    var num8 = array2[num6] ^ num3;
                    array2[num6] = num3;
                    array4[num6, 0] = i;
                    if (num8 == 0 && array3[num6] != 0 && (i - num7 > 2 || i == num7 + 1 && num5 >= 3 && i > 3 &&
                            source[i] == source[i - 3] && source[i] == source[i - 2] && source[i] == source[i - 1] &&
                            source[i] == source[i + 1] && source[i] == source[i + 2]))
                    {
                        num2 = (num2 >> 1) | 0x80000000u;
                        if (source[num7 + 3] != source[i + 3])
                        {
                            var num9 = 1 | (num6 << 4);
                            array[num] = (byte)num9;
                            array[num + 1] = (byte)(num9 >> 8);
                            i += 3;
                            num += 2;
                        }
                        else
                        {
                            var num10 = i;
                            var num11 = source.Length - 4 - i + 1 - 1 > 255 ? 255 : source.Length - 4 - i + 1 - 1;
                            i += 4;
                            if (source[num7 + i - num10] == source[i])
                            {
                                i++;
                                if (source[num7 + i - num10] == source[i])
                                    for (i++; source[num7 + (i - num10)] == source[i] && i - num10 < num11; i++)
                                    {
                                    }
                            }

                            var num12 = i - num10;
                            num6 <<= 4;
                            if (num12 < 18)
                            {
                                var num13 = num6 | (num12 - 2);
                                array[num] = (byte)num13;
                                array[num + 1] = (byte)(num13 >> 8);
                                num += 2;
                            }
                            else
                            {
                                fast_write(array, num, num6 | (num12 << 16), 3);
                                num += 3;
                            }
                        }

                        num3 = source[i] | (source[i + 1] << 8) | (source[i + 2] << 16);
                        num5 = 0;
                    }
                    else
                    {
                        num5++;
                        array3[num6] = 1;
                        array[num] = source[i];
                        num2 >>= 1;
                        i++;
                        num++;
                        num3 = ((num3 >> 8) & 0xFFFF) | (source[i + 2] << 16);
                    }

                    continue;
                }

                num3 = source[i] | (source[i + 1] << 8) | (source[i + 2] << 16);
                var num14 = source.Length - 4 - i + 1 - 1 > 255 ? 255 : source.Length - 4 - i + 1 - 1;
                var num15 = ((num3 >> 12) ^ num3) & 0xFFF;
                var b = array3[num15];
                var num16 = 0;
                var num17 = 0;
                int num18;
                for (var j = 0; j < 16 && b > j; j++)
                {
                    num18 = array4[num15, j];
                    if ((byte)num3 == source[num18] && (byte)(num3 >> 8) == source[num18 + 1] &&
                        (byte)(num3 >> 16) == source[num18 + 2] && num18 < i - 2)
                    {
                        int k;
                        for (k = 3; source[num18 + k] == source[i + k] && k < num14; k++)
                        {
                        }

                        if (k > num16 || k == num16 && num18 > num17)
                        {
                            num17 = num18;
                            num16 = k;
                        }
                    }
                }

                num18 = num17;
                array4[num15, b & 0xF] = i;
                b = array3[num15] = (byte)(b + 1);
                if (num16 >= 3 && i - num18 < 131071)
                {
                    var num19 = i - num18;
                    for (var l = 1; l < num16; l++)
                    {
                        num3 = source[i + l] | (source[i + l + 1] << 8) | (source[i + l + 2] << 16);
                        num15 = ((num3 >> 12) ^ num3) & 0xFFF;
                        array4[num15, array3[num15]++ & 0xF] = i + l;
                    }

                    i += num16;
                    num2 = (num2 >> 1) | 0x80000000u;
                    if (num16 == 3 && num19 <= 63)
                    {
                        fast_write(array, num, num19 << 2, 1);
                        num++;
                    }
                    else if (num16 == 3 && num19 <= 16383)
                    {
                        fast_write(array, num, (num19 << 2) | 1, 2);
                        num += 2;
                    }
                    else if (num16 <= 18 && num19 <= 1023)
                    {
                        fast_write(array, num, ((num16 - 3) << 2) | (num19 << 6) | 2, 2);
                        num += 2;
                    }
                    else if (num16 <= 33)
                    {
                        fast_write(array, num, ((num16 - 2) << 2) | (num19 << 7) | 3, 3);
                        num += 3;
                    }
                    else
                    {
                        fast_write(array, num, ((num16 - 3) << 7) | (num19 << 15) | 3, 4);
                        num += 4;
                    }

                    num5 = 0;
                }
                else
                {
                    array[num] = source[i];
                    num2 >>= 1;
                    i++;
                    num++;
                }
            }

            while (i <= source.Length - 1)
            {
                if ((num2 & 1) == 1)
                {
                    fast_write(array, i2, (int)(num2 >> 1) | int.MinValue, 4);
                    i2 = num;
                    num += 4;
                    num2 = 2147483648u;
                }

                array[num] = source[i];
                i++;
                num++;
                num2 >>= 1;
            }

            while ((num2 & 1) != 1) num2 >>= 1;
            fast_write(array, i2, (int)(num2 >> 1) | int.MinValue, 4);
            write_header(array, level, true, source.Length, num);
            array5 = new byte[num];
            Array.Copy(array, array5, num);
            return array5;
        }

        private static void fast_write(byte[] a, int i, int value, int numbytes)
        {
            for (var j = 0; j < numbytes; j++) a[i + j] = (byte)(value >> (j * 8));
        }

        public static byte[] decompress(byte[] source)
        {
            var num = sizeDecompressed(source);
            var num2 = headerLen(source);
            var num3 = 0;
            var num4 = 1u;
            var array = new byte[num];
            var array2 = new int[4096];
            var array3 = new byte[4096];
            var num5 = num - 6 - 4 - 1;
            var num6 = -1;
            var num7 = 0u;
            var num8 = (source[0] >> 2) & 3;
            if (num8 != 1 && num8 != 3) throw new ArgumentException("C# version only supports level 1 and 3");
            if ((source[0] & 1) != 1)
            {
                var array4 = new byte[num];
                Array.Copy(source, headerLen(source), array4, 0, num);
                return array4;
            }

            while (true)
            {
                if (num4 == 1)
                {
                    num4 = (uint)(source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) |
                                   (source[num2 + 3] << 24));
                    num2 += 4;
                    if (num3 <= num5)
                        num7 = (uint)(num8 != 1
                            ? source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) |
                              (source[num2 + 3] << 24)
                            : source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16));
                }

                if ((num4 & 1) == 1)
                {
                    num4 >>= 1;
                    uint num10;
                    uint num11;
                    if (num8 == 1)
                    {
                        var num9 = ((int)num7 >> 4) & 0xFFF;
                        num10 = (uint)array2[num9];
                        if ((num7 & 0xFu) != 0)
                        {
                            num11 = (num7 & 0xF) + 2;
                            num2 += 2;
                        }
                        else
                        {
                            num11 = source[num2 + 2];
                            num2 += 3;
                        }
                    }
                    else
                    {
                        uint num12;
                        if ((num7 & 3) == 0)
                        {
                            num12 = (num7 & 0xFF) >> 2;
                            num11 = 3u;
                            num2++;
                        }
                        else if ((num7 & 2) == 0)
                        {
                            num12 = (num7 & 0xFFFF) >> 2;
                            num11 = 3u;
                            num2 += 2;
                        }
                        else if ((num7 & 1) == 0)
                        {
                            num12 = (num7 & 0xFFFF) >> 6;
                            num11 = ((num7 >> 2) & 0xF) + 3;
                            num2 += 2;
                        }
                        else if ((num7 & 0x7F) != 3)
                        {
                            num12 = (num7 >> 7) & 0x1FFFFu;
                            num11 = ((num7 >> 2) & 0x1F) + 2;
                            num2 += 3;
                        }
                        else
                        {
                            num12 = num7 >> 15;
                            num11 = ((num7 >> 7) & 0xFF) + 3;
                            num2 += 4;
                        }

                        num10 = (uint)(num3 - num12);
                    }

                    array[num3] = array[num10];
                    array[num3 + 1] = array[num10 + 1];
                    array[num3 + 2] = array[num10 + 2];
                    for (var i = 3; i < num11; i++) array[num3 + i] = array[num10 + i];
                    num3 += (int)num11;
                    if (num8 == 1)
                    {
                        num7 = (uint)(array[num6 + 1] | (array[num6 + 2] << 8) | (array[num6 + 3] << 16));
                        while (num6 < num3 - num11)
                        {
                            num6++;
                            var num9 = (int)(((num7 >> 12) ^ num7) & 0xFFF);
                            array2[num9] = num6;
                            array3[num9] = 1;
                            num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (array[num6 + 3] << 16));
                        }

                        num7 = (uint)(source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16));
                    }
                    else
                    {
                        num7 = (uint)(source[num2] | (source[num2 + 1] << 8) | (source[num2 + 2] << 16) |
                                       (source[num2 + 3] << 24));
                    }

                    num6 = num3 - 1;
                    continue;
                }

                if (num3 > num5) break;
                array[num3] = source[num2];
                num3++;
                num2++;
                num4 >>= 1;
                if (num8 == 1)
                {
                    while (num6 < num3 - 3)
                    {
                        num6++;
                        var num13 = array[num6] | (array[num6 + 1] << 8) | (array[num6 + 2] << 16);
                        var num9 = ((num13 >> 12) ^ num13) & 0xFFF;
                        array2[num9] = num6;
                        array3[num9] = 1;
                    }

                    num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (source[num2 + 2] << 16));
                }
                else
                {
                    num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (source[num2 + 2] << 16) | (source[num2 + 3] << 24));
                }
            }

            while (num3 <= num - 1)
            {
                if (num4 == 1)
                {
                    num2 += 4;
                    num4 = 2147483648u;
                }

                array[num3] = source[num2];
                num3++;
                num2++;
                num4 >>= 1;
            }

            return array;
        }
    }

}

