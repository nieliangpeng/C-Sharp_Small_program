﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    class PTree
    {
        delegate void MyDelegate(int value);
        Thread thread;
        Form frm1;
        Graphics graphics;
        const double PI = Math.PI;
        double th1 = 35 * Math.PI / 180;
        double th2 = 25 * Math.PI / 180;
        double per1 = 0.8;
        double per2 = 0.7;
        Random rnd = new Random();

        public void Show()
        {
            frm1 = new Form();
            frm1.Text = "Tree";
            frm1.WindowState = FormWindowState.Maximized;
            graphics = frm1.CreateGraphics();
            frm1.Show();

            thread = new Thread(Paint);
            thread.Start();
        }

        public void Hide()
        {
            thread.Abort();
            frm1.Hide();
            frm1.Dispose();
            graphics.Dispose();
        }

        private void Paint()
        {
            int x = frm1.Width / 2;
            int y = frm1.Height;
            drawTree(13, x, y, 150, -PI / 2);
        }


        double rand()

        {
            return rnd.NextDouble();
        }

        void drawTree(int n, double x0, double y0, double leng, double th)

        {

            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);

            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawTree(n - 1, x1, y1, per1 * leng * (0.5 + rand()), th + th1 * (0.5 + rand()));

            drawTree(n - 1, x1, y1, per2 * leng * (0.4 + rand()), th - th2 * (0.5 + rand()));

            if (rand() > 0.6)

                drawTree(n - 1, x1, y1, per2 * leng * (0.4 + rand()), th - th2 * (0.5 + rand()));

        }

        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                Pens.Green,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
