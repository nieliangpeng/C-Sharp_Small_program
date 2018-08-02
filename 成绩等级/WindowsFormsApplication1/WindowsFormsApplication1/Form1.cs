using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你好");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "这是个应用程序";
            this.BackColor = Color.FromArgb(255,255,0);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.label1.BackColor = Color.FromArgb(255, 255, 255);
            this.label2.BackColor = Color.FromArgb(255, 255, 255);
            this.label3.BackColor = Color.FromArgb(255, 255, 255);
            double a = double.Parse(this.textBox1.Text);
            double b = double.Parse(this.textBox2.Text);
            double c = double.Parse(this.textBox3.Text);
            if (a < 60 || b < 60 || c < 60) {
                if (a < 60) {
                    this.label1.BackColor = Color.FromArgb(255, 0, 0);
                }
                if (b< 60)
                {
                    this.label2.BackColor = Color.FromArgb(255, 0, 0);
                }
                if (c< 60)
                {
                    this.label3.BackColor = Color.FromArgb(255, 0, 0);
                }
            }
            double avg_grade = (a + b + c) / 3;
            this.textBox4.Text = avg_grade.ToString();
            if(avg_grade>=90){
                MessageBox.Show("等级为A");
            }
            else if(avg_grade>=80){
                MessageBox.Show("等级为B");
            }
            else if (avg_grade >= 70)
            {
                MessageBox.Show("等级为C");
            }
            else if (avg_grade >= 60)
            {
                MessageBox.Show("等级为D");
            }
            else {
                MessageBox.Show("等级为E");
            }
        }
    }
}
