using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Graphics g;
        Pen p;

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawEllipse(p, new Rectangle(4, 4, 50, 50));
            g.FillEllipse(Brushes.PaleGoldenrod, new Rectangle(4, 4, 50, 50));
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Brushes.PaleVioletRed, 4);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            g.DrawRectangle(p, new Rectangle(4, 60, 50, 50));
            g.FillRectangle(Brushes.PaleGoldenrod, new Rectangle(4, 60, 50, 50));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.DrawRectangle(p, new Rectangle(4, 120, 100,50 ));
            g.FillRectangle(Brushes.PaleGoldenrod, new Rectangle(4, 120, 100,50 ));
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // g.DrawLine(p, new Point(4, 230), new Point(50, 180));
           // g.DrawLine(p, new Point(50, 280), new Point(50, 180));
         //   g.DrawLine(p, new Point(50, 280), new Point(4, 230));
           
            Point[] a = {new Point(4, 230),new Point(50, 280),new Point(50, 180)};
            g.DrawPolygon(p,a);
            g.FillPolygon(Brushes.PaleGoldenrod, a);
        }

      
    }
}
