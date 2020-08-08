using System;
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
            if (reg.GetValue("SF-Client.exe") == null || (int)reg.GetValue("SF-Client.exe") != 0x00002ee1 || (int)reg.GetValue("SF-Client.exe") != 0x00002711)
            {
                if (Environment.OSVersion.Version.Major == 10)
                    reg.SetValue("SF-Client.exe", 0x00002ee1);
                else
                    reg.SetValue("SF-Client.exe", 0x00002711);
            }

            Tools.SetProcessWorkingSize();

            CosturaUtility.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //try
            //{
                Application.Run(new Main());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
