using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTree_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_graph.Refresh();
            graphics = this.panel_graph.CreateGraphics();
            if (txtBx_winkel.Text!=String.Empty)
            {
                ReadWinkel();
                double len = trackBar1.Value*5;
                drawTree(10, 200, 310, len, -th1);
            }
            else
            {
                MessageBox.Show("请输入角度");
            }
            
        }

        private Color coloroftree = Color.Blue;

        private Graphics graphics;

        const double PI = Math.PI;

        double th1;

        double th2;

        double per1 = 0.6;

        double per2 = 0.75;

        private void button3_Click(object sender, EventArgs e)
        {
            panel_graph.Refresh();
            graphics = this.panel_graph.CreateGraphics();
            drawTree_random(10, 200, 310, 100, -PI/2);
        }

        void drawTree_random(int n,  double x0, double y0, int leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);

            double y1 = y0 + leng * Math.Sin(th);

            double th11 = 35 * Math.PI / 180;

            double th22 = 25 * Math.PI / 180;

            drawLine(x0, y0, x1, y1, n / 2);
            Random rdm = new Random();
            int tem = rdm.Next(leng / 2, leng);
            double x2 = x0 + tem * Math.Cos(th);
            double y2 = y0 + tem * Math.Sin(th);

            drawTree_random(n - 1, x1, y1, rdm.Next(leng / 2, leng), th - th11 * (0.5 + rdm.NextDouble()));
            drawTree_random(n - 1, x2, y2, rdm.Next(leng / 2, leng), th + th22 * (0.5 + rdm.NextDouble()));
        }

        void drawTree(int n,  double x0, double y0, double leng, double th)
        {

            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);

            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1, n / 2);

            drawTree(n - 1, x1, y1, per1 * leng, th + th1);

            drawTree(n - 1, x1, y1, per2 * leng, th - th2);

        }


        void drawLine(double x0, double y0, double x1, double y1, int width)
        {

            graphics.DrawLine(new Pen(coloroftree, width),(int)x0, (int)y0, (int)x1, (int)y1);

        }

        void ReadWinkel()
        {

            string Wink_str = txtBx_winkel.Text;
            try
            {
                th1 = Convert.ToDouble(Wink_str);
                th2 = Convert.ToDouble(Wink_str);
                th1 = th1 * PI / 180;
                th2 = th2 * PI / 180;
            }
            catch (Exception e)
            {
                MessageBox.Show("输入格式不正确");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = Color.Green;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                coloroftree = MyDialog.Color;
        }

        
    }
}
