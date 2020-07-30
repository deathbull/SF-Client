using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace SF_Client
{
    public partial class FlashPlayer : MetroForm
    {
        public FlashPlayer()
        {
            InitializeComponent();

        }

        public string FlashVariables { get; set; }
        public string Username { get; set; }
        public string SwfClient { get; set; }

        [STAThread]
        private void FlashPlayer_Load(object sender, EventArgs e)
        {
            FlashPlayer.CheckForIllegalCrossThreadCalls = false;
            this.axShockwaveFlash1.FlashVars = FlashVariables;
            this.axShockwaveFlash1.LoadMovie(0, SwfClient);
            this.axShockwaveFlash1.GotoFrame(0);
            this.Text = "SF-Client " + "[ " + Username + " ]";
        }

        private void RestartFlashPlayer()
        {
            try
            {
                this.Controls.Remove(axShockwaveFlash1);
                axShockwaveFlash1.Dispose();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashPlayer));
                this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
                this.axShockwaveFlash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
                this.axShockwaveFlash1.Dock = DockStyle.Fill;
                this.axShockwaveFlash1.Enabled = true;
                this.axShockwaveFlash1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
                this.axShockwaveFlash1.Location = new System.Drawing.Point(0, 0);
                this.axShockwaveFlash1.Margin = new Padding(10);
                this.axShockwaveFlash1.Name = "axShockwaveFlash1";
                this.axShockwaveFlash1.OcxState = ((AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
                this.axShockwaveFlash1.Padding = new Padding(10);
                this.axShockwaveFlash1.Size = new System.Drawing.Size(1248, 473);
                this.axShockwaveFlash1.TabIndex = 2;
                this.axShockwaveFlash1.TabStop = false;
                this.axShockwaveFlash1.MakeDirty();
                this.axShockwaveFlash1.PreviewKeyDown += axShockwaveFlash1_PreviewKeyDown;
                this.Controls.Add(this.axShockwaveFlash1);
                axShockwaveFlash1.Refresh();
                this.axShockwaveFlash1.FlashVars = FlashVariables;
                this.axShockwaveFlash1.LoadMovie(0, SwfClient);
                this.axShockwaveFlash1.GotoFrame(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void axShockwaveFlash1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                if (MessageBox.Show("Do you want to restart flash player ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RestartFlashPlayer();
                }
            }
        }
    }
}
