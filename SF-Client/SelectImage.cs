using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SF_Client.DiscordRPC;
using System.Linq;

namespace SF_Client
{
    public partial class SelectImage : MetroForm
    {
        public SelectImage()
        {
            InitializeComponent();
        }

        public string Selected;

        private void SelectImage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Images.ImageList.Count; i++)
            {
                PictureBox Image = new PictureBox()
                {
                    Name = Images.ImageList.ElementAt(i).Key,
                    Size = new Size(150, 150),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Padding = new Padding(0, 0, 5, 5),
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Image = Images.ImageList.ElementAt(i).Value,
                    Cursor = Cursors.Hand,
                };
                Image.Click += new EventHandler(Image_Click);
                flowLayoutPanel1.Controls.Add(Image);
            }
        }

        private void Image_Click(object sender, EventArgs e)
        {
            Selected = (sender as Control).Name;
            this.Close();
        }
    }
}
