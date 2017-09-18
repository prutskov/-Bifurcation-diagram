namespace Logistic
{
    partial class LogGraph
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
            this.Graph = new System.Windows.Forms.PictureBox();
            this.Ndot = new System.Windows.Forms.TextBox();
            this.parametrsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createdotsBtn = new System.Windows.Forms.Button();
            this.firstx = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Accuracy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ndot2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxR = new System.Windows.Forms.TextBox();
            this.SolidLine = new System.Windows.Forms.CheckBox();
            this.CloseForm = new System.Windows.Forms.Button();
            this.first_point = new System.Windows.Forms.Label();
            this.checkPoint = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioRyad = new System.Windows.Forms.RadioButton();
            this.radioDiagram = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Graph.Dock = System.Windows.Forms.DockStyle.Top;
            this.Graph.Location = new System.Drawing.Point(0, 0);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(1026, 500);
            this.Graph.TabIndex = 0;
            this.Graph.TabStop = false;
            this.Graph.Paint += new System.Windows.Forms.PaintEventHandler(this.Graph_Paint);
            // 
            // Ndot
            // 
            this.Ndot.Location = new System.Drawing.Point(87, 23);
            this.Ndot.Name = "Ndot";
            this.Ndot.Size = new System.Drawing.Size(54, 20);
            this.Ndot.TabIndex = 1;
            // 
            // parametrsBtn
            // 
            this.parametrsBtn.Location = new System.Drawing.Point(899, 515);
            this.parametrsBtn.Name = "parametrsBtn";
            this.parametrsBtn.Size = new System.Drawing.Size(113, 34);
            this.parametrsBtn.TabIndex = 2;
            this.parametrsBtn.Text = "Параметры рисунка...";
            this.parametrsBtn.UseVisualStyleBackColor = true;
            this.parametrsBtn.Click += new System.EventHandler(this.parametrsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число точек";
            // 
            // createdotsBtn
            // 
            this.createdotsBtn.Location = new System.Drawing.Point(899, 553);
            this.createdotsBtn.Name = "createdotsBtn";
            this.createdotsBtn.Size = new System.Drawing.Size(113, 34);
            this.createdotsBtn.TabIndex = 4;
            this.createdotsBtn.Text = "Построить";
            this.createdotsBtn.UseVisualStyleBackColor = true;
            this.createdotsBtn.Click += new System.EventHandler(this.createdotsBtn_Click);
            // 
            // firstx
            // 
            this.firstx.Location = new System.Drawing.Point(87, 49);
            this.firstx.Name = "firstx";
            this.firstx.Size = new System.Drawing.Size(54, 20);
            this.firstx.TabIndex = 5;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(87, 75);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(54, 20);
            this.R.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "R";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.R);
            this.groupBox1.Controls.Add(this.firstx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ndot);
            this.groupBox1.Location = new System.Drawing.Point(382, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры для ряда";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Accuracy);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.K);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.minR);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NumberX);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Ndot2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MaxR);
            this.groupBox2.Location = new System.Drawing.Point(12, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 108);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры для бифуркационной диаграммы";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Порог сравнения";
            // 
            // Accuracy
            // 
            this.Accuracy.Location = new System.Drawing.Point(290, 75);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(54, 20);
            this.Accuracy.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Число повторений";
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(290, 49);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(54, 20);
            this.K.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Минимальный R";
            // 
            // minR
            // 
            this.minR.Location = new System.Drawing.Point(107, 75);
            this.minR.Name = "minR";
            this.minR.Size = new System.Drawing.Size(54, 20);
            this.minR.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер рисуемого X";
            // 
            // NumberX
            // 
            this.NumberX.Location = new System.Drawing.Point(290, 23);
            this.NumberX.Name = "NumberX";
            this.NumberX.Size = new System.Drawing.Size(54, 20);
            this.NumberX.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Число точек";
            // 
            // Ndot2
            // 
            this.Ndot2.Location = new System.Drawing.Point(107, 23);
            this.Ndot2.Name = "Ndot2";
            this.Ndot2.Size = new System.Drawing.Size(54, 20);
            this.Ndot2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Максимальный R";
            // 
            // MaxR
            // 
            this.MaxR.Location = new System.Drawing.Point(107, 49);
            this.MaxR.Name = "MaxR";
            this.MaxR.Size = new System.Drawing.Size(54, 20);
            this.MaxR.TabIndex = 1;
            // 
            // SolidLine
            // 
            this.SolidLine.AutoSize = true;
            this.SolidLine.Location = new System.Drawing.Point(6, 64);
            this.SolidLine.Name = "SolidLine";
            this.SolidLine.Size = new System.Drawing.Size(135, 17);
            this.SolidLine.TabIndex = 12;
            this.SolidLine.Text = "Непрерывной линией";
            this.SolidLine.UseVisualStyleBackColor = true;
            this.SolidLine.CheckedChanged += new System.EventHandler(this.SolidLine_CheckedChanged);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(899, 593);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(113, 32);
            this.CloseForm.TabIndex = 13;
            this.CloseForm.Text = "Закрыть";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // first_point
            // 
            this.first_point.AutoSize = true;
            this.first_point.Location = new System.Drawing.Point(6, 19);
            this.first_point.Name = "first_point";
            this.first_point.Size = new System.Drawing.Size(129, 13);
            this.first_point.TabIndex = 14;
            this.first_point.Text = "Постройте диаграмму...";
            // 
            // checkPoint
            // 
            this.checkPoint.AutoSize = true;
            this.checkPoint.Location = new System.Drawing.Point(6, 85);
            this.checkPoint.Name = "checkPoint";
            this.checkPoint.Size = new System.Drawing.Size(120, 17);
            this.checkPoint.TabIndex = 17;
            this.checkPoint.Text = "Точки бифуркации";
            this.checkPoint.UseVisualStyleBackColor = true;
            this.checkPoint.CheckedChanged += new System.EventHandler(this.checkPoint_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.first_point);
            this.groupBox3.Location = new System.Drawing.Point(547, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 107);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Точки бифуркации";
            // 
            // radioRyad
            // 
            this.radioRyad.AutoSize = true;
            this.radioRyad.Checked = true;
            this.radioRyad.Location = new System.Drawing.Point(6, 17);
            this.radioRyad.Name = "radioRyad";
            this.radioRyad.Size = new System.Drawing.Size(44, 17);
            this.radioRyad.TabIndex = 19;
            this.radioRyad.TabStop = true;
            this.radioRyad.Text = "Ряд";
            this.radioRyad.UseVisualStyleBackColor = true;
            this.radioRyad.Click += new System.EventHandler(this.radioRyad_Click);
            // 
            // radioDiagram
            // 
            this.radioDiagram.AutoSize = true;
            this.radioDiagram.Location = new System.Drawing.Point(6, 38);
            this.radioDiagram.Name = "radioDiagram";
            this.radioDiagram.Size = new System.Drawing.Size(171, 17);
            this.radioDiagram.TabIndex = 20;
            this.radioDiagram.Text = "Бифуркационная диаграмма";
            this.radioDiagram.UseVisualStyleBackColor = true;
            this.radioDiagram.Click += new System.EventHandler(this.radioDiagram_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkPoint);
            this.groupBox4.Controls.Add(this.radioDiagram);
            this.groupBox4.Controls.Add(this.radioRyad);
            this.groupBox4.Controls.Add(this.SolidLine);
            this.groupBox4.Location = new System.Drawing.Point(711, 515);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 108);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тип графика";
            // 
            // LogGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1026, 635);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createdotsBtn);
            this.Controls.Add(this.parametrsBtn);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логистическая модель";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Graph;
        public System.Windows.Forms.TextBox Ndot;
        private System.Windows.Forms.Button parametrsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createdotsBtn;
        public System.Windows.Forms.TextBox firstx;
        public System.Windows.Forms.TextBox R;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox NumberX;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Ndot2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox MaxR;
        public System.Windows.Forms.TextBox minR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox K;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox Accuracy;
        private System.Windows.Forms.CheckBox SolidLine;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Label first_point;
        private System.Windows.Forms.CheckBox checkPoint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioRyad;
        private System.Windows.Forms.RadioButton radioDiagram;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

