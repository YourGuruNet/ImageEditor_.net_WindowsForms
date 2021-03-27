using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Image Img;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Title = "Select Image";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                Img = Image.FromFile(Dlg.FileName);
                LoadImage();
            }
        }

        private void LoadImage()
        {
            ImageView.Image = Img;
            var imageSize = ImageView.Image.Size;
            var fitSize = ImageView.ClientSize;

            ImageView.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        private void btn_mirror_Click(object sender, EventArgs e)
        {
            ImageView.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            ImageView.Refresh();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ImageView.Image.Save(@"D:\Desktop\new.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}





