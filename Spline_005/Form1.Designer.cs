namespace Spline_005
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.labelGU = new System.Windows.Forms.Label();
            this.textBoxSa = new System.Windows.Forms.TextBox();
            this.labelSa = new System.Windows.Forms.Label();
            this.labelSb = new System.Windows.Forms.Label();
            this.textBoxSb = new System.Windows.Forms.TextBox();
            this.buttonGU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Table1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelMaxFD = new System.Windows.Forms.Label();
            this.labelMaxF = new System.Windows.Forms.Label();
            this.labelT2Nd = new System.Windows.Forms.Label();
            this.labelT2n = new System.Windows.Forms.Label();
            this.Table2 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(382, 31);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(947, 669);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // labelGU
            // 
            this.labelGU.AutoSize = true;
            this.labelGU.Location = new System.Drawing.Point(9, 194);
            this.labelGU.Name = "labelGU";
            this.labelGU.Size = new System.Drawing.Size(109, 13);
            this.labelGU.TabIndex = 2;
            this.labelGU.Text = "Граничные условия:";
            // 
            // textBoxSa
            // 
            this.textBoxSa.Location = new System.Drawing.Point(54, 208);
            this.textBoxSa.Name = "textBoxSa";
            this.textBoxSa.Size = new System.Drawing.Size(57, 20);
            this.textBoxSa.TabIndex = 3;
            this.textBoxSa.Text = "0";
            // 
            // labelSa
            // 
            this.labelSa.AutoSize = true;
            this.labelSa.Location = new System.Drawing.Point(12, 211);
            this.labelSa.Name = "labelSa";
            this.labelSa.Size = new System.Drawing.Size(36, 13);
            this.labelSa.TabIndex = 4;
            this.labelSa.Text = "S\'\'(a)=";
            // 
            // labelSb
            // 
            this.labelSb.AutoSize = true;
            this.labelSb.Location = new System.Drawing.Point(119, 210);
            this.labelSb.Name = "labelSb";
            this.labelSb.Size = new System.Drawing.Size(36, 13);
            this.labelSb.TabIndex = 5;
            this.labelSb.Text = "S\'\'(b)=";
            // 
            // textBoxSb
            // 
            this.textBoxSb.Location = new System.Drawing.Point(161, 208);
            this.textBoxSb.Name = "textBoxSb";
            this.textBoxSb.Size = new System.Drawing.Size(63, 20);
            this.textBoxSb.TabIndex = 6;
            this.textBoxSb.Text = "0";
            // 
            // buttonGU
            // 
            this.buttonGU.Location = new System.Drawing.Point(241, 205);
            this.buttonGU.Name = "buttonGU";
            this.buttonGU.Size = new System.Drawing.Size(124, 23);
            this.buttonGU.TabIndex = 7;
            this.buttonGU.Text = "Точные значения";
            this.buttonGU.UseVisualStyleBackColor = true;
            this.buttonGU.Click += new System.EventHandler(this.buttonGU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Число разибений:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(118, 245);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(44, 20);
            this.textBoxN.TabIndex = 12;
            this.textBoxN.Text = "2";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(12, 282);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(353, 23);
            this.buttonGo.TabIndex = 13;
            this.buttonGo.Text = "Рассчитать";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 309);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 327);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Table1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Коэффиценты сплайна";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Table1
            // 
            this.Table1.AllowUserToAddRows = false;
            this.Table1.AllowUserToDeleteRows = false;
            this.Table1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table1.ColumnHeadersVisible = false;
            this.Table1.Location = new System.Drawing.Point(6, 7);
            this.Table1.Name = "Table1";
            this.Table1.ReadOnly = true;
            this.Table1.RowHeadersVisible = false;
            this.Table1.Size = new System.Drawing.Size(326, 264);
            this.Table1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelMaxFD);
            this.tabPage2.Controls.Add(this.labelMaxF);
            this.tabPage2.Controls.Add(this.labelT2Nd);
            this.tabPage2.Controls.Add(this.labelT2n);
            this.tabPage2.Controls.Add(this.Table2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расчеты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelMaxFD
            // 
            this.labelMaxFD.AutoSize = true;
            this.labelMaxFD.Location = new System.Drawing.Point(7, 46);
            this.labelMaxFD.Name = "labelMaxFD";
            this.labelMaxFD.Size = new System.Drawing.Size(76, 13);
            this.labelMaxFD.TabIndex = 5;
            this.labelMaxFD.Text = "Max|f\'(x)-S\'(x)|=";
            // 
            // labelMaxF
            // 
            this.labelMaxF.AutoSize = true;
            this.labelMaxF.Location = new System.Drawing.Point(7, 33);
            this.labelMaxF.Name = "labelMaxF";
            this.labelMaxF.Size = new System.Drawing.Size(72, 13);
            this.labelMaxF.TabIndex = 4;
            this.labelMaxF.Text = "Max|f(x)-S(x)|=";
            // 
            // labelT2Nd
            // 
            this.labelT2Nd.AutoSize = true;
            this.labelT2Nd.Location = new System.Drawing.Point(6, 20);
            this.labelT2Nd.Name = "labelT2Nd";
            this.labelT2Nd.Size = new System.Drawing.Size(101, 13);
            this.labelT2Nd.TabIndex = 3;
            this.labelT2Nd.Text = "Дополн. сетка: N=";
            // 
            // labelT2n
            // 
            this.labelT2n.AutoSize = true;
            this.labelT2n.Location = new System.Drawing.Point(7, 7);
            this.labelT2n.Name = "labelT2n";
            this.labelT2n.Size = new System.Drawing.Size(100, 13);
            this.labelT2n.TabIndex = 2;
            this.labelT2n.Text = "Сетка сплайна: n=";
            // 
            // Table2
            // 
            this.Table2.AllowUserToAddRows = false;
            this.Table2.AllowUserToDeleteRows = false;
            this.Table2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table2.ColumnHeadersVisible = false;
            this.Table2.Location = new System.Drawing.Point(0, 72);
            this.Table2.Name = "Table2";
            this.Table2.ReadOnly = true;
            this.Table2.RowHeadersVisible = false;
            this.Table2.Size = new System.Drawing.Size(353, 212);
            this.Table2.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(382, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "График функции";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(497, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "График производной";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(635, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(170, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "График второй производной";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(1, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(1, 79);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 21;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 50);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(1, 135);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 23;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(238, 50);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 177);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGU);
            this.Controls.Add(this.textBoxSb);
            this.Controls.Add(this.labelSb);
            this.Controls.Add(this.labelSa);
            this.Controls.Add(this.textBoxSa);
            this.Controls.Add(this.labelGU);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label labelGU;
        private System.Windows.Forms.TextBox textBoxSa;
        private System.Windows.Forms.Label labelSa;
        private System.Windows.Forms.Label labelSb;
        private System.Windows.Forms.TextBox textBoxSb;
        private System.Windows.Forms.Button buttonGU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Table1;
        private System.Windows.Forms.DataGridView Table2;
        private System.Windows.Forms.Label labelT2n;
        private System.Windows.Forms.Label labelMaxFD;
        private System.Windows.Forms.Label labelMaxF;
        private System.Windows.Forms.Label labelT2Nd;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

