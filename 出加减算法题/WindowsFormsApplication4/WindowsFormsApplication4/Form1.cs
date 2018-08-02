using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int a, b;
        string op;
        int result;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            string str = this.answer.Text;
            int ans = int.Parse(str);
            if (ans == result)
            {
                this.answer.BackColor = Color.FromArgb(0, 255, 0);
                tf.Text = "正确";
            }
            else {
                this.answer.BackColor = Color.FromArgb(255, 0, 0);
                tf.Text = "错误";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = rnd.Next(100);
            b = rnd.Next(100);
            int c = rnd.Next(2);
            switch (c)
            {
                case 0: op = "+"; result = a + b; break;
                case 1: op = "-"; result = a - b; break;

            }
            labelA.Text = a.ToString();
            labelB.Text = b.ToString();
            labelOp.Text = op;
            answer.Text = "";
            answer.BackColor = Color.FromArgb(255, 255, 255);
            tf.Text = "";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a = rnd.Next(100);
            b = rnd.Next(100);
            int c = rnd.Next(2);
            switch (c)
            {
                case 0: op = "+"; result = a + b; break;
                case 1: op = "-"; result = a - b; break;

            }
            labelA.Text = a.ToString();
            labelB.Text = b.ToString();
            labelOp.Text = op;
            answer.Text = "";
            answer.BackColor = Color.FromArgb(255, 255, 255);
            tf.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = false;
        }
    }
}
