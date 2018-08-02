namespace WindowsFormsApplication2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnJudge = new System.Windows.Forms.Button();
            this.lstDisp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(30, 35);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 12);
            this.lblA.TabIndex = 0;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(88, 34);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(0, 12);
            this.lblB.TabIndex = 1;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(152, 34);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 12);
            this.lblOp.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.AutoSize = true;
            this.txtAnswer.Location = new System.Drawing.Point(274, 37);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(41, 12);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.Text = "answer";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(73, 107);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 36);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "出题";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(212, 108);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(91, 34);
            this.btnJudge.TabIndex = 6;
            this.btnJudge.Text = "判分";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // lstDisp
            // 
            this.lstDisp.FormattingEnabled = true;
            this.lstDisp.ItemHeight = 12;
            this.lstDisp.Location = new System.Drawing.Point(77, 171);
            this.lstDisp.Name = "lstDisp";
            this.lstDisp.Size = new System.Drawing.Size(211, 64);
            this.lstDisp.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 261);
            this.Controls.Add(this.lstDisp);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtAnswer;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.ListBox lstDisp;
    }
}