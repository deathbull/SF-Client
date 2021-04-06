using System.Drawing;

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
            this.Login = new MetroFramework.Controls.MetroButton();
            this.userNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.userPassTextbox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.DiscordRPC_Description = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.DiscordRPC_Image = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DiscordRPC_Active = new MetroFramework.Controls.MetroCheckBox();
            this.DiscordRPC_Image_Change = new System.Windows.Forms.Button();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.quality = new MetroFramework.Controls.MetroTrackBar();
            this.browser_option = new MetroFramework.Controls.MetroTrackBar();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Discord = new System.Windows.Forms.Button();
            this.clearCache = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordRPC_Image)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(96, 35);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 30);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.ShowToolTips = true;
            this.metroTabControl1.Size = new System.Drawing.Size(996, 724);
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
            this.metroTabPage1.Size = new System.Drawing.Size(988, 681);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Game    ";
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
            this.webBrowser1.Size = new System.Drawing.Size(988, 681);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.metroTabPage2.Controls.Add(this.Discord);
            this.metroTabPage2.Controls.Add(this.language);
            this.metroTabPage2.Controls.Add(this.clearCache);
            this.metroTabPage2.Controls.Add(this.Login);
            this.metroTabPage2.Controls.Add(this.userNameTextbox);
            this.metroTabPage2.Controls.Add(this.userPassTextbox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 0;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(988, 681);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Login    ";
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
            this.language.Location = new System.Drawing.Point(344, 381);
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
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Location = new System.Drawing.Point(344, 338);
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
            this.userNameTextbox.Location = new System.Drawing.Point(344, 260);
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
            this.userPassTextbox.Location = new System.Drawing.Point(344, 299);
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
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 0;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(988, 681);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Settings    ";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.flowLayoutPanel1.Controls.Add(this.metroPanel1);
            this.flowLayoutPanel1.Controls.Add(this.metroPanel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(988, 681);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.DiscordRPC_Description);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.DiscordRPC_Image);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.DiscordRPC_Active);
            this.metroPanel1.Controls.Add(this.DiscordRPC_Image_Change);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(350, 300);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DiscordRPC_Description
            // 
            // 
            // 
            // 
            this.DiscordRPC_Description.CustomButton.Image = null;
            this.DiscordRPC_Description.CustomButton.Location = new System.Drawing.Point(312, 2);
            this.DiscordRPC_Description.CustomButton.Name = "";
            this.DiscordRPC_Description.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.DiscordRPC_Description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DiscordRPC_Description.CustomButton.TabIndex = 1;
            this.DiscordRPC_Description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DiscordRPC_Description.CustomButton.UseSelectable = true;
            this.DiscordRPC_Description.CustomButton.Visible = false;
            this.DiscordRPC_Description.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.DiscordRPC_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DiscordRPC_Description.Lines = new string[0];
            this.DiscordRPC_Description.Location = new System.Drawing.Point(3, 263);
            this.DiscordRPC_Description.MaxLength = 32767;
            this.DiscordRPC_Description.Name = "DiscordRPC_Description";
            this.DiscordRPC_Description.PasswordChar = '\0';
            this.DiscordRPC_Description.PromptText = "Description";
            this.DiscordRPC_Description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DiscordRPC_Description.SelectedText = "";
            this.DiscordRPC_Description.SelectionLength = 0;
            this.DiscordRPC_Description.SelectionStart = 0;
            this.DiscordRPC_Description.ShortcutsEnabled = true;
            this.DiscordRPC_Description.Size = new System.Drawing.Size(342, 32);
            this.DiscordRPC_Description.Style = MetroFramework.MetroColorStyle.Red;
            this.DiscordRPC_Description.TabIndex = 4;
            this.DiscordRPC_Description.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DiscordRPC_Description.UseSelectable = true;
            this.DiscordRPC_Description.WaterMark = "Description";
            this.DiscordRPC_Description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DiscordRPC_Description.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.DiscordRPC_Description.TextChanged += new System.EventHandler(this.DiscordRPC_Description_TextChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 45);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(350, 1);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // DiscordRPC_Image
            // 
            this.DiscordRPC_Image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiscordRPC_Image.BackColor = System.Drawing.Color.Transparent;
            this.DiscordRPC_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscordRPC_Image.Location = new System.Drawing.Point(100, 103);
            this.DiscordRPC_Image.Name = "DiscordRPC_Image";
            this.DiscordRPC_Image.Size = new System.Drawing.Size(150, 150);
            this.DiscordRPC_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiscordRPC_Image.TabIndex = 2;
            this.DiscordRPC_Image.TabStop = false;
            this.DiscordRPC_Image.MouseEnter += new System.EventHandler(this.DiscordRPC_Image_MouseEnter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(120, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Discord RPC";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DiscordRPC_Active
            // 
            this.DiscordRPC_Active.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiscordRPC_Active.AutoSize = true;
            this.DiscordRPC_Active.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.DiscordRPC_Active.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DiscordRPC_Active.Location = new System.Drawing.Point(135, 64);
            this.DiscordRPC_Active.Name = "DiscordRPC_Active";
            this.DiscordRPC_Active.Size = new System.Drawing.Size(76, 25);
            this.DiscordRPC_Active.Style = MetroFramework.MetroColorStyle.Red;
            this.DiscordRPC_Active.TabIndex = 0;
            this.DiscordRPC_Active.Text = "Active";
            this.DiscordRPC_Active.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DiscordRPC_Active.UseCustomForeColor = true;
            this.DiscordRPC_Active.UseSelectable = true;
            this.DiscordRPC_Active.UseStyleColors = true;
            this.DiscordRPC_Active.CheckedChanged += new System.EventHandler(this.DiscordRPC_Active_CheckedChanged);
            // 
            // DiscordRPC_Image_Change
            // 
            this.DiscordRPC_Image_Change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DiscordRPC_Image_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordRPC_Image_Change.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DiscordRPC_Image_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscordRPC_Image_Change.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DiscordRPC_Image_Change.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DiscordRPC_Image_Change.Location = new System.Drawing.Point(100, 103);
            this.DiscordRPC_Image_Change.Name = "DiscordRPC_Image_Change";
            this.DiscordRPC_Image_Change.Size = new System.Drawing.Size(150, 150);
            this.DiscordRPC_Image_Change.TabIndex = 2;
            this.DiscordRPC_Image_Change.Text = "Change";
            this.DiscordRPC_Image_Change.UseVisualStyleBackColor = false;
            this.DiscordRPC_Image_Change.Click += new System.EventHandler(this.DiscordRPC_Image_Change_Click);
            this.DiscordRPC_Image_Change.MouseLeave += new System.EventHandler(this.DiscordRPC_Image_Change_MouseLeave);
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.metroLabel8);
            this.metroPanel4.Controls.Add(this.metroLabel7);
            this.metroPanel4.Controls.Add(this.metroLabel6);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.metroLabel5);
            this.metroPanel4.Controls.Add(this.metroLabel3);
            this.metroPanel4.Controls.Add(this.quality);
            this.metroPanel4.Controls.Add(this.browser_option);
            this.metroPanel4.Controls.Add(this.metroPanel5);
            this.metroPanel4.Controls.Add(this.metroLabel2);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(359, 3);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(350, 300);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroPanel4.TabIndex = 4;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(204, 160);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 25);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "High";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(80, 160);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(78, 25);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Medium";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(3, 160);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(44, 25);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Low";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 92);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 25);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "ActiveX";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(296, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Ultra";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(287, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "PPAPI";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // quality
            // 
            this.quality.BackColor = System.Drawing.Color.Transparent;
            this.quality.LargeChange = 1;
            this.quality.Location = new System.Drawing.Point(3, 120);
            this.quality.Maximum = 3;
            this.quality.MouseWheelBarPartitions = 1;
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(342, 37);
            this.quality.Style = MetroFramework.MetroColorStyle.Black;
            this.quality.TabIndex = 4;
            this.quality.Text = "metroTrackBar1";
            this.quality.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.quality.Value = 0;
            // 
            // browser_option
            // 
            this.browser_option.BackColor = System.Drawing.Color.Transparent;
            this.browser_option.LargeChange = 1;
            this.browser_option.Location = new System.Drawing.Point(3, 52);
            this.browser_option.Maximum = 1;
            this.browser_option.Name = "browser_option";
            this.browser_option.Size = new System.Drawing.Size(342, 37);
            this.browser_option.TabIndex = 4;
            this.browser_option.Text = "metroTrackBar1";
            this.browser_option.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.browser_option.Value = 0;
            // 
            // metroPanel5
            // 
            this.metroPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 45);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(350, 1);
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(0, -1);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(349, 47);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Browser Option";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Discord
            // 
            this.Discord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Discord.AutoEllipsis = true;
            this.Discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Discord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discord.Image = global::SF_Client.Properties.Resources.discord;
            this.Discord.Location = new System.Drawing.Point(860, 628);
            this.Discord.Name = "Discord";
            this.Discord.Size = new System.Drawing.Size(125, 50);
            this.Discord.TabIndex = 2;
            this.Discord.UseVisualStyleBackColor = false;
            this.Discord.Click += new System.EventHandler(this.Discord_Click);
            // 
            // clearCache
            // 
            this.clearCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearCache.Location = new System.Drawing.Point(3, 628);
            this.clearCache.MaximumSize = new System.Drawing.Size(350, 50);
            this.clearCache.Name = "clearCache";
            this.clearCache.Size = new System.Drawing.Size(125, 50);
            this.clearCache.Style = MetroFramework.MetroColorStyle.Red;
            this.clearCache.TabIndex = 10;
            this.clearCache.Text = "Clear Cache";
            this.clearCache.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.clearCache.UseSelectable = true;
            this.clearCache.Click += new System.EventHandler(this.clearCache_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.metroTabControl1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(14, 30, 14, 14);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "SF-Client by Deathbull";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordRPC_Image)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
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
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroCheckBox DiscordRPC_Active;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.PictureBox DiscordRPC_Image;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button DiscordRPC_Image_Change;
        private MetroFramework.Controls.MetroTextBox DiscordRPC_Description;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTrackBar quality;
        private MetroFramework.Controls.MetroTrackBar browser_option;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton clearCache;
    }
}

