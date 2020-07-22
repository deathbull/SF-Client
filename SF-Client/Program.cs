using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_Client
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            CosturaUtility.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
