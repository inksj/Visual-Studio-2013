using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagetoGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(@"C:\Users\hylanduser\Pictures\logo.png");

            image.Save(@"C:\Users\hylanduser\Pictures\image1.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            image.Save(@"C:\Users\hylanduser\Pictures\image1.Bmp", System.Drawing.Imaging.ImageFormat.Bmp); image.Save(@"C:\Users\hylanduser\Pictures\image1.Gif", System.Drawing.Imaging.ImageFormat.Gif);
            image.Save(@"C:\Users\hylanduser\Pictures\image1.Tiff", System.Drawing.Imaging.ImageFormat.Tiff);
        }
    }
}
