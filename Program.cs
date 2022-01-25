using System;
using System.Windows.Forms;

namespace LazyPassword
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            var text = Clipboard.GetText();
            SendKeys.SendWait(text);
        }
    }
}
