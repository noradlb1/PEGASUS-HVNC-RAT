using System;
using System.Text;

namespace PEGASUS.Design.RenamingObfuscation.Classes
{
    public static class Utils
    {
        private const string alphabet =
            "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρστυφχψωABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي0123456789艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת";

        private static readonly Random random = new Random();

        public static string GenerateRandomString()
        {
            var sb = new StringBuilder();
            for (var i = 1; i <= random.Next(10, 20); i++)
            {
                var randomCharacterPosition = random.Next(0, alphabet.Length);
                sb.Append(alphabet[randomCharacterPosition]);
            }

            return sb.ToString();
        }
    }
}