namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnJudge = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.answer = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(150, 164);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(65, 53);
            this.btnJudge.TabIndex = 0;
            this.btnJudge.Text = "判断";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(73, 60);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(0, 12);
            this.labelA.TabIndex = 1;
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Location = new System.Drawing.Point(138, 60);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(0, 12);
            this.labelOp.TabIndex = 2;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(210, 60);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(0, 12);
            this.labelB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(318, 57);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(48, 21);
            this.answer.TabIndex = 5;
            this.answer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer2
            // 
            this.timer2.Interval = 100000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "出题快";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 22);
            this.button3.TabIndex = 8;
            this.button3.Text = "出题慢";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tf
            // 
            this.tf.AutoSize = true;
            this.tf.Location = new System.Drawing.Point(372, 60);
            this.tf.Name = "tf";
            this.tf.Size = new System.Drawing.Size(0, 12);
            this.tf.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 292);
            this.Controls.Add(this.tf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelOp);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.btnJudge);
            this.Name = "Form1";
            this.Text = "加减算法";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label tf;
    }
}

