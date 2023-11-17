using System.Text;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Utils
{
    public static class StringDecoder
    {
        public static string Decrypt(string text, int key)
        {
            var input = new StringBuilder(text);
            var output = new StringBuilder(text.Length);
            char Textch;
            for (var iCount = 0; iCount < text.Length; iCount++)
            {
                Textch = input[iCount];
                Textch = (char) (Textch ^ key);
                output.Append(Textch);
            }

            return output.ToString();
        }
    }
}