using System;
using System.Windows.Forms;

namespace LicenseKeyGenerator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LicenseKeyGeneratorForm());
        }
    }
}