using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SF_Client
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            //Confirmation for Webbrowser to use javascript
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION\", true);
            if (reg == null)
                reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION\");
            if (reg.GetValue("SF-Client.exe") == null)
                reg.SetValue("SF-Client.exe", 0x00002af9);

            CosturaUtility.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
