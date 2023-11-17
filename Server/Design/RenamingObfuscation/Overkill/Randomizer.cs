using System;
using System.Security.Cryptography;
using System.Text;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Utils
{
    /// <summary>
    ///     This class is the one that generates random integers and strings.
    /// </summary>
    public class Randomizer
    {
        private static readonly RandomNumberGenerator csp = RandomNumberGenerator.Create();

        private static readonly char[] chars =
            "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρστυφχψωABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي0123456789艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת"
                .ToCharArray();

        public static int Next(int maxValue, int minValue = 0)
        {
            if (minValue >= maxValue) throw new ArgumentOutOfRangeException(nameof(minValue));
            var diff = (long) maxValue - minValue;
            var upperBound = uint.MaxValue / diff * diff;
            uint ui;
            do
            {
                ui = RandomUInt();
            } while (ui >= upperBound);

            return (int) (minValue + ui % diff);
        }

        public static string GenerateRandomString(int size)
        {
            var data = new byte[4 * size];
            csp.GetNonZeroBytes(data);
            var sb = new StringBuilder(size);
            for (var i = 0; i < size; i++)
                sb.Append(chars[BitConverter.ToUInt32(data, i * 4)
                                % chars.Length]);
            return sb.ToString();
        }

        private static uint RandomUInt()
        {
            return BitConverter.ToUInt32(RandomBytes(sizeof(uint)), 0);
        }

        private static byte[] RandomBytes(int bytesNumber)
        {
            var buffer = new byte[bytesNumber];
            csp.GetNonZeroBytes(buffer);
            return buffer;
        }
    }
}