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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.func1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.func2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.func3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.func4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.derivative1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derivative2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table2)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(382, 27);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(608, 337);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem,
            this.graphicsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.func1ToolStripMenuItem,
            this.func2ToolStripMenuItem,
            this.func3ToolStripMenuItem,
            this.func4ToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.functionToolStripMenuItem.Text = "Функция";
            // 
            // func1ToolStripMenuItem
            // 
            this.func1ToolStripMenuItem.Name = "func1ToolStripMenuItem";
            this.func1ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.func1ToolStripMenuItem.Text = "Тестовая";
            this.func1ToolStripMenuItem.Click += new System.EventHandler(this.func1ToolStripMenuItem_Click);
            // 
            // func2ToolStripMenuItem
            // 
            this.func2ToolStripMenuItem.Name = "func2ToolStripMenuItem";
            this.func2ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.func2ToolStripMenuItem.Text = "f(x)";
            this.func2ToolStripMenuItem.Click += new System.EventHandler(this.func2ToolStripMenuItem_Click);
            // 
            // func3ToolStripMenuItem
            // 
            this.func3ToolStripMenuItem.Name = "func3ToolStripMenuItem";
            this.func3ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.func3ToolStripMenuItem.Text = "f(x)+cos(10x)";
            this.func3ToolStripMenuItem.Click += new System.EventHandler(this.func3ToolStripMenuItem_Click);
            // 
            // func4ToolStripMenuItem
            // 
            this.func4ToolStripMenuItem.Name = "func4ToolStripMenuItem";
            this.func4ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.func4ToolStripMenuItem.Text = "f(x)+cos(100x)";
            this.func4ToolStripMenuItem.Click += new System.EventHandler(this.func4ToolStripMenuItem_Click);
            // 
            // graphicsToolStripMenuItem
            // 
            this.graphicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem1,
            this.derivative1ToolStripMenuItem,
            this.derivative2ToolStripMenuItem});
            this.graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
            this.graphicsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.graphicsToolStripMenuItem.Text = "Графики";
            // 
            // functionToolStripMenuItem1
            // 
            this.functionToolStripMenuItem1.Name = "functionToolStripMenuItem1";
            this.functionToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.functionToolStripMenuItem1.Text = "Функция";
            this.functionToolStripMenuItem1.Click += new System.EventHandler(this.functionToolStripMenuItem1_Click);
            // 
            // derivative1ToolStripMenuItem
            // 
            this.derivative1ToolStripMenuItem.Name = "derivative1ToolStripMenuItem";
            this.derivative1ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.derivative1ToolStripMenuItem.Text = "Первая производная";
            this.derivative1ToolStripMenuItem.Click += new System.EventHandler(this.derivative1ToolStripMenuItem_Click);
            // 
            // derivative2ToolStripMenuItem
            // 
            this.derivative2ToolStripMenuItem.Name = "derivative2ToolStripMenuItem";
            this.derivative2ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.derivative2ToolStripMenuItem.Text = "Вторая производная";
            this.derivative2ToolStripMenuItem.Click += new System.EventHandler(this.derivative2ToolStripMenuItem_Click);
            // 
            // labelGU
            // 
            this.labelGU.AutoSize = true;
            this.labelGU.Location = new System.Drawing.Point(13, 28);
            this.labelGU.Name = "labelGU";
            this.labelGU.Size = new System.Drawing.Size(109, 13);
            this.labelGU.TabIndex = 2;
            this.labelGU.Text = "Граничные условия:";
            // 
            // textBoxSa
            // 
            this.textBoxSa.Location = new System.Drawing.Point(58, 42);
            this.textBoxSa.Name = "textBoxSa";
            this.textBoxSa.Size = new System.Drawing.Size(57, 20);
            this.textBoxSa.TabIndex = 3;
            this.textBoxSa.Text = "0";
            // 
            // labelSa
            // 
            this.labelSa.AutoSize = true;
            this.labelSa.Location = new System.Drawing.Point(16, 45);
            this.labelSa.Name = "labelSa";
            this.labelSa.Size = new System.Drawing.Size(36, 13);
            this.labelSa.TabIndex = 4;
            this.labelSa.Text = "S\'\'(a)=";
            // 
            // labelSb
            // 
            this.labelSb.AutoSize = true;
            this.labelSb.Location = new System.Drawing.Point(123, 44);
            this.labelSb.Name = "labelSb";
            this.labelSb.Size = new System.Drawing.Size(36, 13);
            this.labelSb.TabIndex = 5;
            this.labelSb.Text = "S\'\'(b)=";
            // 
            // textBoxSb
            // 
            this.textBoxSb.Location = new System.Drawing.Point(165, 42);
            this.textBoxSb.Name = "textBoxSb";
            this.textBoxSb.Size = new System.Drawing.Size(63, 20);
            this.textBoxSb.TabIndex = 6;
            this.textBoxSb.Text = "0";
            // 
            // buttonGU
            // 
            this.buttonGU.Location = new System.Drawing.Point(245, 39);
            this.buttonGU.Name = "buttonGU";
            this.buttonGU.Size = new System.Drawing.Size(109, 23);
            this.buttonGU.TabIndex = 7;
            this.buttonGU.Text = "Точные значения";
            this.buttonGU.UseVisualStyleBackColor = true;
            this.buttonGU.Click += new System.EventHandler(this.buttonGU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Число разибений:";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(122, 79);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(44, 20);
            this.textBoxN.TabIndex = 12;
            this.textBoxN.Text = "2";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(186, 77);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(168, 23);
            this.buttonGo.TabIndex = 13;
            this.buttonGo.Text = "Рассчитать";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 306);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Table1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Table1
            // 
            this.Table1.AllowUserToAddRows = false;
            this.Table1.AllowUserToDeleteRows = false;
            this.Table1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table1.ColumnHeadersVisible = false;
            this.Table1.Location = new System.Drawing.Point(0, 0);
            this.Table1.Name = "Table1";
            this.Table1.ReadOnly = true;
            this.Table1.RowHeadersVisible = false;
            this.Table1.Size = new System.Drawing.Size(240, 150);
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
            this.tabPage2.Size = new System.Drawing.Size(356, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблица 2";
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
            this.Table2.Size = new System.Drawing.Size(240, 150);
            this.Table2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 503);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem func1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem func2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem func3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem derivative1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derivative2ToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem func4ToolStripMenuItem;

    }
}

