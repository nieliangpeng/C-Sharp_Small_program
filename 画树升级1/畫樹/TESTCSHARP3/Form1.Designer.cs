namespace TESTCSHARP3
{
    partial class ControlPanel
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labLen = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.tkbLen = new System.Windows.Forms.TrackBar();
            this.tkbSize = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labAng = new System.Windows.Forms.Label();
            this.labNum = new System.Windows.Forms.Label();
            this.tkbAng = new System.Windows.Forms.TrackBar();
            this.tkbNum = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSubT = new System.Windows.Forms.NumericUpDown();
            this.numPos = new System.Windows.Forms.NumericUpDown();
            this.numAng = new System.Windows.Forms.NumericUpDown();
            this.numLen = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.rdbMode1 = new System.Windows.Forms.RadioButton();
            this.rdbMode2 = new System.Windows.Forms.RadioButton();
            this.ckbB = new System.Windows.Forms.CheckBox();
            this.ckbG = new System.Windows.Forms.CheckBox();
            this.ckbR = new System.Windows.Forms.CheckBox();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.btnRondom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSubT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLen)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labLen);
            this.groupBox1.Controls.Add(this.labSize);
            this.groupBox1.Controls.Add(this.tkbLen);
            this.groupBox1.Controls.Add(this.tkbSize);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主幹";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "長度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "大小";
            // 
            // labLen
            // 
            this.labLen.AutoSize = true;
            this.labLen.Location = new System.Drawing.Point(272, 83);
            this.labLen.Name = "labLen";
            this.labLen.Size = new System.Drawing.Size(28, 15);
            this.labLen.TabIndex = 3;
            this.labLen.Text = "100";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(279, 33);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(21, 15);
            this.labSize.TabIndex = 2;
            this.labSize.Text = "10";
            // 
            // tkbLen
            // 
            this.tkbLen.Location = new System.Drawing.Point(0, 73);
            this.tkbLen.Maximum = 200;
            this.tkbLen.Minimum = 50;
            this.tkbLen.Name = "tkbLen";
            this.tkbLen.Size = new System.Drawing.Size(253, 56);
            this.tkbLen.TabIndex = 1;
            this.tkbLen.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tkbLen.Value = 100;
            this.tkbLen.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // tkbSize
            // 
            this.tkbSize.AutoSize = false;
            this.tkbSize.Location = new System.Drawing.Point(-10, 24);
            this.tkbSize.Maximum = 20;
            this.tkbSize.Minimum = 1;
            this.tkbSize.Name = "tkbSize";
            this.tkbSize.Size = new System.Drawing.Size(263, 56);
            this.tkbSize.TabIndex = 1;
            this.tkbSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tkbSize.Value = 10;
            this.tkbSize.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labAng);
            this.groupBox2.Controls.Add(this.labNum);
            this.groupBox2.Controls.Add(this.tkbAng);
            this.groupBox2.Controls.Add(this.tkbNum);
            this.groupBox2.Location = new System.Drawing.Point(3, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分岔";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "角度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "數量";
            // 
            // labAng
            // 
            this.labAng.AutoSize = true;
            this.labAng.Location = new System.Drawing.Point(272, 79);
            this.labAng.Name = "labAng";
            this.labAng.Size = new System.Drawing.Size(21, 15);
            this.labAng.TabIndex = 4;
            this.labAng.Text = "30";
            // 
            // labNum
            // 
            this.labNum.AutoSize = true;
            this.labNum.Location = new System.Drawing.Point(272, 24);
            this.labNum.Name = "labNum";
            this.labNum.Size = new System.Drawing.Size(21, 15);
            this.labNum.TabIndex = 3;
            this.labNum.Text = "15";
            // 
            // tkbAng
            // 
            this.tkbAng.Location = new System.Drawing.Point(15, 66);
            this.tkbAng.Maximum = 60;
            this.tkbAng.Minimum = 25;
            this.tkbAng.Name = "tkbAng";
            this.tkbAng.Size = new System.Drawing.Size(263, 56);
            this.tkbAng.TabIndex = 2;
            this.tkbAng.Value = 30;
            this.tkbAng.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // tkbNum
            // 
            this.tkbNum.Location = new System.Drawing.Point(15, 24);
            this.tkbNum.Maximum = 20;
            this.tkbNum.Minimum = 5;
            this.tkbNum.Name = "tkbNum";
            this.tkbNum.Size = new System.Drawing.Size(263, 56);
            this.tkbNum.TabIndex = 1;
            this.tkbNum.Value = 15;
            this.tkbNum.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.numSubT);
            this.groupBox3.Controls.Add(this.numPos);
            this.groupBox3.Controls.Add(this.numAng);
            this.groupBox3.Controls.Add(this.numLen);
            this.groupBox3.Location = new System.Drawing.Point(3, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "調整";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "子主幹";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "位置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "角度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "長度";
            // 
            // numSubT
            // 
            this.numSubT.DecimalPlaces = 2;
            this.numSubT.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSubT.Location = new System.Drawing.Point(231, 77);
            this.numSubT.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            131072});
            this.numSubT.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSubT.Name = "numSubT";
            this.numSubT.Size = new System.Drawing.Size(120, 25);
            this.numSubT.TabIndex = 3;
            this.numSubT.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // numPos
            // 
            this.numPos.DecimalPlaces = 2;
            this.numPos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPos.Location = new System.Drawing.Point(234, 24);
            this.numPos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numPos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPos.Name = "numPos";
            this.numPos.Size = new System.Drawing.Size(120, 25);
            this.numPos.TabIndex = 2;
            this.numPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numAng
            // 
            this.numAng.DecimalPlaces = 2;
            this.numAng.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAng.Location = new System.Drawing.Point(51, 77);
            this.numAng.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numAng.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numAng.Name = "numAng";
            this.numAng.Size = new System.Drawing.Size(120, 25);
            this.numAng.TabIndex = 1;
            this.numAng.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // numLen
            // 
            this.numLen.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.numLen.DecimalPlaces = 2;
            this.numLen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numLen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numLen.Location = new System.Drawing.Point(51, 24);
            this.numLen.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.numLen.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numLen.Name = "numLen";
            this.numLen.Size = new System.Drawing.Size(120, 25);
            this.numLen.TabIndex = 1;
            this.numLen.UseWaitCursor = true;
            this.numLen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxColor);
            this.groupBox4.Controls.Add(this.rdbMode1);
            this.groupBox4.Controls.Add(this.rdbMode2);
            this.groupBox4.Controls.Add(this.ckbB);
            this.groupBox4.Controls.Add(this.ckbG);
            this.groupBox4.Controls.Add(this.ckbR);
            this.groupBox4.Controls.Add(this.numB);
            this.groupBox4.Controls.Add(this.numG);
            this.groupBox4.Controls.Add(this.numR);
            this.groupBox4.Location = new System.Drawing.Point(3, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color";
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Random"});
            this.cbxColor.Location = new System.Drawing.Point(15, 20);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 23);
            this.cbxColor.TabIndex = 12;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // rdbMode1
            // 
            this.rdbMode1.AutoSize = true;
            this.rdbMode1.Checked = true;
            this.rdbMode1.Location = new System.Drawing.Point(15, 63);
            this.rdbMode1.Name = "rdbMode1";
            this.rdbMode1.Size = new System.Drawing.Size(65, 19);
            this.rdbMode1.TabIndex = 11;
            this.rdbMode1.TabStop = true;
            this.rdbMode1.Text = "模組1";
            this.rdbMode1.UseVisualStyleBackColor = true;
            this.rdbMode1.CheckedChanged += new System.EventHandler(this.rdbMode_CheckedChanged);
            // 
            // rdbMode2
            // 
            this.rdbMode2.AutoSize = true;
            this.rdbMode2.Location = new System.Drawing.Point(15, 93);
            this.rdbMode2.Name = "rdbMode2";
            this.rdbMode2.Size = new System.Drawing.Size(65, 19);
            this.rdbMode2.TabIndex = 10;
            this.rdbMode2.Text = "模組2";
            this.rdbMode2.UseVisualStyleBackColor = true;
            this.rdbMode2.CheckedChanged += new System.EventHandler(this.rdbMode_CheckedChanged);
            // 
            // ckbB
            // 
            this.ckbB.AutoSize = true;
            this.ckbB.Checked = true;
            this.ckbB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbB.Location = new System.Drawing.Point(313, 88);
            this.ckbB.Name = "ckbB";
            this.ckbB.Size = new System.Drawing.Size(38, 19);
            this.ckbB.TabIndex = 9;
            this.ckbB.Text = "B";
            this.ckbB.UseVisualStyleBackColor = true;
            // 
            // ckbG
            // 
            this.ckbG.AutoSize = true;
            this.ckbG.Location = new System.Drawing.Point(313, 57);
            this.ckbG.Name = "ckbG";
            this.ckbG.Size = new System.Drawing.Size(39, 19);
            this.ckbG.TabIndex = 8;
            this.ckbG.Text = "G";
            this.ckbG.UseVisualStyleBackColor = true;
            // 
            // ckbR
            // 
            this.ckbR.AutoSize = true;
            this.ckbR.Location = new System.Drawing.Point(313, 20);
            this.ckbR.Name = "ckbR";
            this.ckbR.Size = new System.Drawing.Size(38, 19);
            this.ckbR.TabIndex = 7;
            this.ckbR.Text = "R";
            this.ckbR.UseVisualStyleBackColor = true;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(189, 87);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(120, 25);
            this.numB.TabIndex = 6;
            this.numB.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(189, 57);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(120, 25);
            this.numG.TabIndex = 5;
            this.numG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numR
            // 
            this.numR.Location = new System.Drawing.Point(189, 21);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(120, 25);
            this.numR.TabIndex = 4;
            this.numR.Value = new decimal(new int[] {
            111,
            0,
            0,
            0});
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(8, 513);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "預設";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnRedraw
            // 
            this.btnRedraw.Location = new System.Drawing.Point(123, 513);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(75, 23);
            this.btnRedraw.TabIndex = 5;
            this.btnRedraw.Text = "重畫";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.BtnRedraw_Click);
            // 
            // btnRondom
            // 
            this.btnRondom.Location = new System.Drawing.Point(237, 513);
            this.btnRondom.Name = "btnRondom";
            this.btnRondom.Size = new System.Drawing.Size(75, 23);
            this.btnRondom.TabIndex = 6;
            this.btnRondom.Text = "隨機";
            this.btnRondom.UseVisualStyleBackColor = true;
            this.btnRondom.Click += new System.EventHandler(this.btnRondom_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 548);
            this.Controls.Add(this.btnRondom);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlPanel";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSubT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLen)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labLen;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.TrackBar tkbLen;
        private System.Windows.Forms.TrackBar tkbSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labAng;
        private System.Windows.Forms.Label labNum;
        private System.Windows.Forms.TrackBar tkbAng;
        private System.Windows.Forms.TrackBar tkbNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSubT;
        private System.Windows.Forms.NumericUpDown numAng;
        private System.Windows.Forms.NumericUpDown numLen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.RadioButton rdbMode1;
        private System.Windows.Forms.RadioButton rdbMode2;
        private System.Windows.Forms.CheckBox ckbB;
        private System.Windows.Forms.CheckBox ckbG;
        private System.Windows.Forms.CheckBox ckbR;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPos;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button btnRondom;
    }
}

