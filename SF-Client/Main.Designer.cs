namespace SF_Client
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.language = new MetroFramework.Controls.MetroComboBox();
            this.ClearCache = new MetroFramework.Controls.MetroButton();
            this.Login = new MetroFramework.Controls.MetroButton();
            this.userNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.userPassTextbox = new MetroFramework.Controls.MetroTextBox();
            this.Discord = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(96, 35);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 70);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.ShowToolTips = true;
            this.metroTabControl1.Size = new System.Drawing.Size(996, 684);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.webBrowser1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 0;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(988, 641);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Game   ";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.UseVisualStyleBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(988, 641);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.metroTabPage2.Controls.Add(this.language);
            this.metroTabPage2.Controls.Add(this.ClearCache);
            this.metroTabPage2.Controls.Add(this.Login);
            this.metroTabPage2.Controls.Add(this.userNameTextbox);
            this.metroTabPage2.Controls.Add(this.userPassTextbox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 0;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(988, 641);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Login   ";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 0;
            // 
            // language
            // 
            this.language.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.language.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.language.ForeColor = System.Drawing.Color.Red;
            this.language.FormattingEnabled = true;
            this.language.ItemHeight = 29;
            this.language.Items.AddRange(new object[] {
            "BG",
            "BR",
            "CS",
            "DA",
            "DE",
            "EL",
            "EN",
            "ES",
            "FI",
            "FR",
            "HU",
            "IT",
            "NL",
            "NO",
            "PL",
            "PT",
            "RO",
            "RU",
            "SK",
            "SV",
            "TR",
            "US"});
            this.language.Location = new System.Drawing.Point(344, 361);
            this.language.MaxDropDownItems = 20;
            this.language.MaximumSize = new System.Drawing.Size(350, 0);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(300, 35);
            this.language.Style = MetroFramework.MetroColorStyle.Red;
            this.language.TabIndex = 14;
            this.language.TabStop = false;
            this.language.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.language.UseSelectable = true;
            // 
            // ClearCache
            // 
            this.ClearCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearCache.Location = new System.Drawing.Point(3, 601);
            this.ClearCache.MaximumSize = new System.Drawing.Size(350, 50);
            this.ClearCache.Name = "ClearCache";
            this.ClearCache.Size = new System.Drawing.Size(150, 37);
            this.ClearCache.Style = MetroFramework.MetroColorStyle.Red;
            this.ClearCache.TabIndex = 10;
            this.ClearCache.Text = "Clear Cache";
            this.ClearCache.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ClearCache.UseSelectable = true;
            this.ClearCache.Click += new System.EventHandler(this.ClearCache_Click);
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Location = new System.Drawing.Point(344, 318);
            this.Login.MaximumSize = new System.Drawing.Size(350, 50);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(300, 37);
            this.Login.Style = MetroFramework.MetroColorStyle.Red;
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Login.UseSelectable = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            // 
            // 
            // 
            this.userNameTextbox.CustomButton.Image = null;
            this.userNameTextbox.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.userNameTextbox.CustomButton.Name = "";
            this.userNameTextbox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.userNameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextbox.CustomButton.TabIndex = 1;
            this.userNameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextbox.CustomButton.UseSelectable = true;
            this.userNameTextbox.CustomButton.Visible = false;
            this.userNameTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.userNameTextbox.Lines = new string[0];
            this.userNameTextbox.Location = new System.Drawing.Point(344, 240);
            this.userNameTextbox.MaximumSize = new System.Drawing.Size(350, 50);
            this.userNameTextbox.MaxLength = 32767;
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.PasswordChar = '\0';
            this.userNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextbox.SelectedText = "";
            this.userNameTextbox.SelectionLength = 0;
            this.userNameTextbox.SelectionStart = 0;
            this.userNameTextbox.ShortcutsEnabled = true;
            this.userNameTextbox.Size = new System.Drawing.Size(300, 33);
            this.userNameTextbox.Style = MetroFramework.MetroColorStyle.Red;
            this.userNameTextbox.TabIndex = 8;
            this.userNameTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userNameTextbox.UseSelectable = true;
            this.userNameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userPassTextbox
            // 
            this.userPassTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPassTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            // 
            // 
            // 
            this.userPassTextbox.CustomButton.Image = null;
            this.userPassTextbox.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.userPassTextbox.CustomButton.Name = "";
            this.userPassTextbox.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.userPassTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userPassTextbox.CustomButton.TabIndex = 1;
            this.userPassTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userPassTextbox.CustomButton.UseSelectable = true;
            this.userPassTextbox.CustomButton.Visible = false;
            this.userPassTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.userPassTextbox.Lines = new string[0];
            this.userPassTextbox.Location = new System.Drawing.Point(344, 279);
            this.userPassTextbox.MaximumSize = new System.Drawing.Size(350, 50);
            this.userPassTextbox.MaxLength = 32767;
            this.userPassTextbox.Name = "userPassTextbox";
            this.userPassTextbox.PasswordChar = '●';
            this.userPassTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userPassTextbox.SelectedText = "";
            this.userPassTextbox.SelectionLength = 0;
            this.userPassTextbox.SelectionStart = 0;
            this.userPassTextbox.ShortcutsEnabled = true;
            this.userPassTextbox.Size = new System.Drawing.Size(300, 33);
            this.userPassTextbox.Style = MetroFramework.MetroColorStyle.Red;
            this.userPassTextbox.TabIndex = 9;
            this.userPassTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userPassTextbox.UseSelectable = true;
            this.userPassTextbox.UseSystemPasswordChar = true;
            this.userPassTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userPassTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Discord
            // 
            this.Discord.AutoEllipsis = true;
            this.Discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Discord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discord.Image = global::SF_Client.Properties.Resources.discord;
            this.Discord.Location = new System.Drawing.Point(14, 12);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(96, 52);
            this.Discord.TabIndex = 2;
            this.Discord.UseVisualStyleBackColor = true;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.Discord);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(14, 70, 14, 14);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "SF-Client";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button Discord;
        private MetroFramework.Controls.MetroComboBox language;
        private MetroFramework.Controls.MetroButton Login;
        private MetroFramework.Controls.MetroTextBox userNameTextbox;
        private MetroFramework.Controls.MetroTextBox userPassTextbox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroButton ClearCache;
    }
}

