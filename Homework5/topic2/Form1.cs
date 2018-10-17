using System;
using System.Drawing;
using System.Windows.Forms;

namespace topic2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        double th1 , th2;
        double per1 = 0.6;
        double per2 = 0.7;
        double k;

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();

            string s1 = textBox1.Text;
            string s2 = this.textBox2.Text;
            string s3 = this.textBox3.Text;
            double d1 = double.Parse(s1);
            th1 = d1 * Math.PI / 180;
            double d2 = double.Parse(s2);
            th2 = d2 * Math.PI / 180;
            k = double.Parse(s3);

            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
            drawGayleyTree2(10, 200, 310, 100, -Math.PI / 2);
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawGayleyTree2(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = x0 + leng * k * Math.Sin(th);
            drawLine(x0, y0, x2, y2);
            drawGayleyTree2(n - 1, x2, y2, per1 * leng, th + th1);
            drawGayleyTree2(n - 1, x2, y2, per2 * leng, th - th2);
        }


        void drawLine(double x0, double y0, double x, double y)
        {
            graphics.DrawLine(
                Pens.Blue,
            (int)x0, (int)y0, (int)x, (int)y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
