using System;
using System.Windows.Forms;

namespace LazyPassword
{
    class Program
    {
        private static readonly string[] _specialChars = { "{", "}", "(", ")", "+", "^" };

        [STAThread]
        private static void Main()
        {
            var text = Clipboard.GetText();
            var escapedText = text;

            foreach (var specialChar in _specialChars)
            {
                escapedText = escapedText.Replace(specialChar, $"{{{specialChar}}}");
            }

            SendKeys.SendWait(escapedText);
        }
    }
}
