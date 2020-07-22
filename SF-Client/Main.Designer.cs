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
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.language = new MetroFramework.Controls.MetroComboBox();
            this.Login = new MetroFramework.Controls.MetroButton();
            this.userNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.userPassTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Discord = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
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
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.ShowToolTips = true;
            this.metroTabControl1.Size = new System.Drawing.Size(996, 684);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.axShockwaveFlash1);
            this.metroTabPage1.Controls.Add(this.webBrowser1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
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
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(0, 0);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(988, 641);
            this.axShockwaveFlash1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(988, 641);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.metroTabPage2.Controls.Add(this.language);
            this.metroTabPage2.Controls.Add(this.Login);
            this.metroTabPage2.Controls.Add(this.userNameTextbox);
            this.metroTabPage2.Controls.Add(this.userPassTextbox);
            this.metroTabPage2.CustomBackground = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarSize = 0;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(988, 641);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Login   ";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarSize = 0;
            // 
            // language
            // 
            this.language.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.language.FontSize = MetroFramework.MetroLinkSize.Tall;
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
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Highlight = true;
            this.Login.Location = new System.Drawing.Point(344, 318);
            this.Login.MaximumSize = new System.Drawing.Size(350, 50);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(300, 37);
            this.Login.Style = MetroFramework.MetroColorStyle.Red;
            this.Login.TabIndex = 10;
            this.Login.Text = "Login";
            this.Login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.userNameTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.userNameTextbox.Location = new System.Drawing.Point(344, 240);
            this.userNameTextbox.MaximumSize = new System.Drawing.Size(350, 50);
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.Size = new System.Drawing.Size(300, 33);
            this.userNameTextbox.Style = MetroFramework.MetroColorStyle.Red;
            this.userNameTextbox.TabIndex = 8;
            this.userNameTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userNameTextbox.UseStyleColors = true;
            // 
            // userPassTextbox
            // 
            this.userPassTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userPassTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.userPassTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.userPassTextbox.Location = new System.Drawing.Point(344, 279);
            this.userPassTextbox.MaximumSize = new System.Drawing.Size(350, 50);
            this.userPassTextbox.Name = "userPassTextbox";
            this.userPassTextbox.PasswordChar = '●';
            this.userPassTextbox.Size = new System.Drawing.Size(300, 33);
            this.userPassTextbox.Style = MetroFramework.MetroColorStyle.Red;
            this.userPassTextbox.TabIndex = 9;
            this.userPassTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userPassTextbox.UseStyleColors = true;
            this.userPassTextbox.UseSystemPasswordChar = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(14, 12);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 52);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Browser";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(116, 12);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(96, 52);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Game";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Discord
            // 
            this.Discord.AutoEllipsis = true;
            this.Discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Discord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discord.Image = global::SF_Client.Properties.Resources.discord;
            this.Discord.Location = new System.Drawing.Point(218, 12);
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
            this.ControlBox = false;
            this.Controls.Add(this.Discord);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(14, 70, 14, 14);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "SF-Client";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Button Discord;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private MetroFramework.Controls.MetroComboBox language;
        private MetroFramework.Controls.MetroButton Login;
        private MetroFramework.Controls.MetroTextBox userNameTextbox;
        private MetroFramework.Controls.MetroTextBox userPassTextbox;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

