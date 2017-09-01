using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_lab
{
    public partial class Form1 : Form
    {
        private Bitmap _currentBitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                _currentBitmap = (Bitmap)pictureBox1.Image;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Bitmap bmap = (Bitmap)_currentBitmap.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;
                    nPixelR = c.R;
                    nPixelG = c.G - 255;
                    nPixelB = c.B - 255;

                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    bmap.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }
           
            pictureBox2.Image = (Bitmap)bmap.Clone();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmap = (Bitmap)_currentBitmap.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;
                    nPixelR = c.R-255;
                    nPixelG = c.G ;
                    nPixelB = c.B - 255;

                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    bmap.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }
            pictureBox3.Image = (Bitmap)bmap.Clone();
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmap = (Bitmap)_currentBitmap.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int nPixelR = 0;
                    int nPixelG = 0;
                    int nPixelB = 0;
                    nPixelR = c.R-255;
                    nPixelG = c.G - 255;
                    nPixelB = c.B;

                    nPixelR = Math.Max(nPixelR, 0);
                    nPixelR = Math.Min(255, nPixelR);

                    nPixelG = Math.Max(nPixelG, 0);
                    nPixelG = Math.Min(255, nPixelG);

                    nPixelB = Math.Max(nPixelB, 0);
                    nPixelB = Math.Min(255, nPixelB);

                    bmap.SetPixel(i, j, Color.FromArgb((byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }
            pictureBox4.Image = (Bitmap)bmap.Clone();
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
