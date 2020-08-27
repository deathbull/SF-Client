using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_Client
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams 
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private async void SplashScreen_Load(object sender, System.EventArgs e)
        {
            this.Show();
            Description.Text = "Downloading avatars for Discord";
            Tools.LoadRPCImages();
            Description.Text = "Finished";
            this.Close();
        }
    }
}
