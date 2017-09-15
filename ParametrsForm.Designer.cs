namespace Logistic
{
    partial class ParametrsForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorGraph = new System.Windows.Forms.Button();
            this.colorSetka = new System.Windows.Forms.Button();
            this.colorOsi = new System.Windows.Forms.Button();
            this.colorBackground = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.stepy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stepx = new System.Windows.Forms.TextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ymax = new System.Windows.Forms.TextBox();
            this.Ymin = new System.Windows.Forms.TextBox();
            this.Xmax = new System.Windows.Forms.TextBox();
            this.Xmin = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorPoint = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorPoint);
            this.groupBox2.Controls.Add(this.colorGraph);
            this.groupBox2.Controls.Add(this.colorSetka);
            this.groupBox2.Controls.Add(this.colorOsi);
            this.groupBox2.Controls.Add(this.colorBackground);
            this.groupBox2.Location = new System.Drawing.Point(212, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 205);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // colorGraph
            // 
            this.colorGraph.Location = new System.Drawing.Point(6, 130);
            this.colorGraph.Name = "colorGraph";
            this.colorGraph.Size = new System.Drawing.Size(113, 26);
            this.colorGraph.TabIndex = 19;
            this.colorGraph.Text = "Цвет графика...";
            this.colorGraph.UseVisualStyleBackColor = true;
            this.colorGraph.Click += new System.EventHandler(this.colorGraph_Click);
            // 
            // colorSetka
            // 
            this.colorSetka.Location = new System.Drawing.Point(5, 97);
            this.colorSetka.Name = "colorSetka";
            this.colorSetka.Size = new System.Drawing.Size(113, 28);
            this.colorSetka.TabIndex = 18;
            this.colorSetka.Text = "Цвет сетки...";
            this.colorSetka.UseVisualStyleBackColor = true;
            this.colorSetka.Click += new System.EventHandler(this.colorSetka_Click);
            // 
            // colorOsi
            // 
            this.colorOsi.Location = new System.Drawing.Point(6, 52);
            this.colorOsi.Name = "colorOsi";
            this.colorOsi.Size = new System.Drawing.Size(113, 39);
            this.colorOsi.TabIndex = 17;
            this.colorOsi.Text = "Цвет осей и подписей...";
            this.colorOsi.UseVisualStyleBackColor = true;
            this.colorOsi.Click += new System.EventHandler(this.colorOsi_Click);
            // 
            // colorBackground
            // 
            this.colorBackground.Location = new System.Drawing.Point(6, 19);
            this.colorBackground.Name = "colorBackground";
            this.colorBackground.Size = new System.Drawing.Size(113, 28);
            this.colorBackground.TabIndex = 16;
            this.colorBackground.Text = "Цвет фона...";
            this.colorBackground.UseVisualStyleBackColor = true;
            this.colorBackground.Click += new System.EventHandler(this.colorBackground_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Шаг сетки по вертикали";
            // 
            // stepy
            // 
            this.stepy.Location = new System.Drawing.Point(26, 215);
            this.stepy.Name = "stepy";
            this.stepy.Size = new System.Drawing.Size(136, 20);
            this.stepy.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Шаг сетки по горизонтали";
            // 
            // stepx
            // 
            this.stepx.Location = new System.Drawing.Point(26, 176);
            this.stepx.Name = "stepx";
            this.stepx.Size = new System.Drawing.Size(136, 20);
            this.stepx.TabIndex = 21;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(218, 232);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(113, 28);
            this.Apply.TabIndex = 20;
            this.Apply.Text = "Применить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ymax);
            this.groupBox1.Controls.Add(this.Ymin);
            this.groupBox1.Controls.Add(this.Xmax);
            this.groupBox1.Controls.Add(this.Xmin);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 132);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Границы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Верхняя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Нижняя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Правая";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Левая";
            // 
            // Ymax
            // 
            this.Ymax.Location = new System.Drawing.Point(63, 97);
            this.Ymax.Name = "Ymax";
            this.Ymax.Size = new System.Drawing.Size(113, 20);
            this.Ymax.TabIndex = 3;
            // 
            // Ymin
            // 
            this.Ymin.Location = new System.Drawing.Point(63, 71);
            this.Ymin.Name = "Ymin";
            this.Ymin.Size = new System.Drawing.Size(113, 20);
            this.Ymin.TabIndex = 2;
            // 
            // Xmax
            // 
            this.Xmax.Location = new System.Drawing.Point(63, 45);
            this.Xmax.Name = "Xmax";
            this.Xmax.Size = new System.Drawing.Size(113, 20);
            this.Xmax.TabIndex = 1;
            // 
            // Xmin
            // 
            this.Xmin.Location = new System.Drawing.Point(63, 19);
            this.Xmin.Name = "Xmin";
            this.Xmin.Size = new System.Drawing.Size(113, 20);
            this.Xmin.TabIndex = 0;
            // 
            // colorPoint
            // 
            this.colorPoint.Location = new System.Drawing.Point(5, 160);
            this.colorPoint.Name = "colorPoint";
            this.colorPoint.Size = new System.Drawing.Size(113, 36);
            this.colorPoint.TabIndex = 20;
            this.colorPoint.Text = "Цвет точек бифуркации...";
            this.colorPoint.UseVisualStyleBackColor = true;
            this.colorPoint.Click += new System.EventHandler(this.colorPoint_Click);
            // 
            // ParametrsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(342, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stepy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stepx);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ParametrsForm";
            this.Text = "Параметры графика";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button colorGraph;
        private System.Windows.Forms.Button colorSetka;
        private System.Windows.Forms.Button colorOsi;
        private System.Windows.Forms.Button colorBackground;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stepy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stepx;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ymax;
        private System.Windows.Forms.TextBox Ymin;
        private System.Windows.Forms.TextBox Xmax;
        private System.Windows.Forms.TextBox Xmin;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorPoint;
    }
}