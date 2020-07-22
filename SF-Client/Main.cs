using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SF_Client
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            language.SelectedIndex = 0;
        }

        private void RefreshFlashPlayer()
        {
            this.metroTabPage1.Controls.Remove(axShockwaveFlash1);
            axShockwaveFlash1.Dispose();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.axShockwaveFlash1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.axShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.axShockwaveFlash1.Location = new System.Drawing.Point(0, 0);
            this.axShockwaveFlash1.Margin = new System.Windows.Forms.Padding(10);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Padding = new System.Windows.Forms.Padding(10);
            this.axShockwaveFlash1.Size = new System.Drawing.Size(1248, 473);
            this.axShockwaveFlash1.TabIndex = 2;
            this.axShockwaveFlash1.TabStop = false;
            this.axShockwaveFlash1.MakeDirty();
            this.metroTabPage1.Controls.Add(this.axShockwaveFlash1);
            axShockwaveFlash1.Refresh();
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/vkYs2Xx");
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTextbox.Text) || string.IsNullOrEmpty(userPassTextbox.Text))
                MessageBox.Show("Please enter a username and password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                metroTabControl1.SelectedIndex = 0;
                webBrowser1.Navigate("http://www.seafight.com");
                return;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.DocumentText.Contains("<div class=\"bgcdw_errors_flash\">") || webBrowser1.DocumentText.Contains("data-error=\"bgc.error.password_isTooShort\""))
            {
                MessageBox.Show("Please enter correct username and password", "Attention", MessageBoxButtons.OK);
            }
            else if (webBrowser1.DocumentText.Contains("bgcdw_login_form_username"))
            {
                HtmlElement lname = webBrowser1.Document.GetElementById("bgcdw_login_form_username");
                HtmlElement lpass = webBrowser1.Document.GetElementById("bgcdw_login_form_password");
                if (!lname.GetAttribute("value").Equals(userNameTextbox.Text))
                {
                    lname.SetAttribute("value", userNameTextbox.Text);
                }
                if (!lpass.GetAttribute("value").Equals(userPassTextbox.Text))
                {
                    lpass.SetAttribute("value", userPassTextbox.Text);
                }
                try
                {
                    foreach (HtmlElement element in webBrowser1.Document.All)
                    {
                        if (element.GetAttribute("className") == "bgcdw_button bgcdw_login_form_login")
                        {
                            element.InvokeMember("click");
                            break;
                        }
                    }
                    RefreshFlashPlayer();
                }
                catch (Exception)
                {
                }
            }
            else if (e.Url.AbsoluteUri.Contains("&loginDone=true"))
            {
                webBrowser1.Navigate(webBrowser1.Url.AbsoluteUri.Replace("/index.es?action=internalStart&loginDone=true", "/index.es?action=internalMap"));
            }
            else if (webBrowser1.Url.ToString().Contains("/index.es?action=internalMap"))
            {
                try
                {
                    axShockwaveFlash1.LoadMovie(0, webBrowser1.Document.GetElementById("sffclient").GetAttribute("data"));
                    foreach (HtmlElement item in webBrowser1.Document.GetElementsByTagName("param"))
                    {
                        if (item.Name == "FlashVars")
                        {
                            axShockwaveFlash1.FlashVars = item.GetAttribute("value").Replace(item.GetAttribute("value").Split(new string[] { "isFastReg=1&" }, StringSplitOptions.None)[1].Split(new string[] { "&quality" }, StringSplitOptions.None)[0], "lang=" + language.GetItemText(language.SelectedItem).ToLower());
                            break;
                        }
                    }
                    axShockwaveFlash1.GotoFrame(0);
                    webBrowser1.Navigate(webBrowser1.Url.AbsoluteUri.Replace("?action=internalMap", "?action=internalStart"));
                }
                catch (Exception)
                {
                    webBrowser1.Navigate(webBrowser1.Url);
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.BringToFront();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.BringToFront();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Lanuguage = language.SelectedIndex;
            Properties.Settings.Default.Username = userNameTextbox.Text;
            Properties.Settings.Default.Password = userPassTextbox.Text;

            Properties.Settings.Default.Save();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            language.SelectedIndex = Properties.Settings.Default.Lanuguage;
            userNameTextbox.Text = Properties.Settings.Default.Username;
            userPassTextbox.Text = Properties.Settings.Default.Password;
        }
    }
}
