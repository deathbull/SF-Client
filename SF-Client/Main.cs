using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_Client
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            language.SelectedIndex = 0;
            Main.CheckForIllegalCrossThreadCalls = false;
        }

        private string Username { get; set; }

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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.DocumentText.Contains("<div class=\"bgcdw_errors_flash\">") || webBrowser1.DocumentText.Contains("data-error=\"bgc.error.password_isTooShort\""))
            {
                MessageBox.Show("Please enter correct username and password", "Attention", MessageBoxButtons.OK);
                return;
            }
            else if (webBrowser1.DocumentText.Contains("bgcdw_login_form_username"))
            {
                Username = userNameTextbox.Text;
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
                    string swf = webBrowser1.Document.GetElementById("sffclient").GetAttribute("data");
                    string var = "";
                    foreach (HtmlElement item in webBrowser1.Document.GetElementsByTagName("param"))
                    {
                        if (item.Name == "FlashVars")
                        {
                            var = item.GetAttribute("value").Replace(item.GetAttribute("value").Split(new string[] { "isFastReg=1&" }, StringSplitOptions.None)[1].Split(new string[] { "&quality" }, StringSplitOptions.None)[0], "lang=" + language.GetItemText(language.SelectedItem).ToLower());
                            break;
                        }
                    }
                    FlashPlayer _ = new FlashPlayer()
                    {
                        FlashVariables = var,
                        SwfClient = swf,
                        Username = this.Username,
                    };
                    _.Show();
                    webBrowser1.Navigate(webBrowser1.Url.AbsoluteUri.Replace("?action=internalMap", "?action=internalStart"));
                    this.WindowState = FormWindowState.Minimized;
                }
                catch (Exception)
                {
                    webBrowser1.Navigate(webBrowser1.Url);
                }
            }
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

        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

        private const int INTERNET_OPTION_END_BROWSER_SESSION = 42;

        private void ClearCache_Click(object sender, EventArgs e)
        {
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_END_BROWSER_SESSION, IntPtr.Zero, 0);
        }
    }
}
