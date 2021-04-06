using MetroFramework.Forms;
using DiscordRpcNet;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using SF_Client.DiscordRPC;
using CefSharp;
using CefSharp.WinForms;
using System.IO;

namespace SF_Client
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            InitializeChromium();
            new SplashScreen().ShowDialog();
            language.SelectedIndex = 0;
            Main.CheckForIllegalCrossThreadCalls = false;
        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            settings.UserAgent = "BigpointClient/1.6.2";
            settings.IgnoreCertificateErrors = true;
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Deathbull\SF-Client\CefCache\";
            settings.CefCommandLineArgs["enable-npapi"] = "1";
            settings.CefCommandLineArgs.Add("ppapi-flash-path", "pepflashplayer.dll");
            settings.CefCommandLineArgs.Add("ppapi-flash-version", "30.0.0.306");
            settings.CefCommandLineArgs.Add("disable-gpu", "1");
            settings.CefCommandLineArgs.Add("disable-gpu-compositing", "1");
            settings.CefCommandLineArgs.Add("disable-gpu-vsync", "1");
            settings.CefCommandLineArgs.Add("disable-pinch", "1");
            settings.CefCommandLineArgs.Add("ppapi-antialiased-text-enabled", "0");
            settings.Locale = language.GetItemText(language.SelectedItem).ToLower();
            settings.AcceptLanguageList = language.GetItemText(language.SelectedItem).ToLower() + "-" + language.GetItemText(language.SelectedItem).ToUpper();

            Cef.EnableHighDPISupport();
            Cef.Initialize(settings);
            Cef.GetGlobalCookieManager().DeleteCookiesAsync("", "");

            browser = new ChromiumWebBrowser("");
            browser.Dock = DockStyle.Fill;
            metroTabPage1.Controls.Add(browser);
            browser.BrowserSettings.Javascript = CefState.Enabled;
            browser.BrowserSettings.Plugins = CefState.Enabled;
            browser.BringToFront();
            browser.FrameLoadEnd += Browser_FrameLoadEnd;
        }

        private void Browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Url == "https://lp.seafight.com/")
            {
                browser.GetMainFrame().EvaluateScriptAsync("document.getElementById('bgcdw_login_form_username').setAttribute('value', '" + userNameTextbox.Text + "');" +
                                                           "document.getElementById('bgcdw_login_form_password').setAttribute('value', '" + userPassTextbox.Text + "');" +
                                                           "document.getElementsByName('bgcdw_login_form')[0].submit();");
            }
            if (e.Url.Contains("loginDone=true"))
            {
                browser.Load(e.Url.Replace("Start&loginDone=true", "Map"));
            }
            if (e.Url.Contains("internalMap"))
            {
                e.Frame.EvaluateScriptAsync("document.getElementById('seafightClientContainer').setAttribute('style', 'display: block');" +
                                            "try{" +
                                            "document.getElementsByName('quality')[0].setAttribute('value', '" + Enum.GetName(typeof(Tools.Quality), quality.Value) + "');" +
                                            "document.getElementsByName('wmode')[0].setAttribute('value', 'window');" +
                                            "}" +
                                            "catch (e){" +
                                            "loadFunc();" +
                                            "})");
            }
        }

        private string Username { get; set; }
        private ChromiumWebBrowser browser { get; set; }


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
                if (browser_option.Value == 0)
                {
                    webBrowser1.Navigate(new Uri("https://lp.seafight.com/"), null, null, "User-Agent: BigpointClient/1.6.2");
                    webBrowser1.BringToFront();
                }
                else
                {
                    
                    browser.Load("https://lp.seafight.com/");
                    browser.BringToFront();
                }
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
                webBrowser1.Navigate(new Uri(webBrowser1.Url.AbsoluteUri.Replace("/index.es?action=internalStart&loginDone=true", "/index.es?action=internalMap")), null, null, "User-Agent: BigpointClient/1.2.0");
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
                            var = var.Replace(var.Split(new string[] { "platform=" }, StringSplitOptions.None)[1].Split(new string[] { "&" }, StringSplitOptions.None)[0], "PC_CLIENT");
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Lanuguage = language.SelectedIndex;
            Properties.Settings.Default.Username = userNameTextbox.Text;
            Properties.Settings.Default.Password = userPassTextbox.Text;
            Properties.Settings.Default.DiscordRPC_Active = DiscordRPC_Active.Checked;
            Properties.Settings.Default.DiscordRPC_Description = DiscordRPC_Description.Text;
            Properties.Settings.Default.browserOption = browser_option.Value;

            Properties.Settings.Default.Save();

            DiscordRpc.Shutdown();
            Cef.Shutdown();


            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            language.SelectedIndex = Properties.Settings.Default.Lanuguage;
            userNameTextbox.Text = Properties.Settings.Default.Username;
            userPassTextbox.Text = Properties.Settings.Default.Password;
            DiscordRPC_Image.Image = Images.ImageList[Properties.Settings.Default.DiscordRPC_Image];
            DiscordRPC_Active.Checked = Properties.Settings.Default.DiscordRPC_Active;
            DiscordRPC_Description.Text = Properties.Settings.Default.DiscordRPC_Description;
            browser_option.Value = Properties.Settings.Default.browserOption;
        }

        void UpdatePresence()
        {
            if (DiscordRPC_Active.Checked)
            {
                DiscordRpc.EventHandlers handlers = new DiscordRpc.EventHandlers();
                DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();
                DiscordRpc.Initialize("738137354589437972", ref handlers, true, null);
                presence.details = DiscordRPC_Description.Text;
                presence.largeImageKey = Properties.Settings.Default.DiscordRPC_Image;
                presence.largeImageText = "Seafight";
                presence.startTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                DiscordRpc.UpdatePresence(ref presence);
            }
            else
            {
                DiscordRpc.Shutdown();
            }
        }

        private void DiscordRPC_Image_MouseEnter(object sender, EventArgs e)
        {
            DiscordRPC_Image_Change.BringToFront();
        }

        private void DiscordRPC_Image_Change_MouseLeave(object sender, EventArgs e)
        {
            DiscordRPC_Image.BringToFront();
        }

        private void DiscordRPC_Image_Change_Click(object sender, EventArgs e)
        {
            SelectImage _ = new SelectImage();
            _.ShowDialog();
            if (_.Selected != null)
            {
                Properties.Settings.Default.DiscordRPC_Image = _.Selected;
                DiscordRPC_Image.Image = Images.ImageList[Properties.Settings.Default.DiscordRPC_Image];
                UpdatePresence();
            }
        }

        private void DiscordRPC_Active_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresence();
        }

        private void DiscordRPC_Description_TextChanged(object sender, EventArgs e)
        {
            UpdatePresence();
        }

        private void clearCache_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the cache ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(Application.ExecutablePath, "cc");
                Application.Exit();
            }
        }
    }
}
