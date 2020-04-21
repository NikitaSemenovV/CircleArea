namespace Lab9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.interv = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.threadNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 404);
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resText);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.interv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.threadNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 423);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // resText
            // 
            this.resText.Enabled = false;
            this.resText.Location = new System.Drawing.Point(7, 336);
            this.resText.Name = "resText";
            this.resText.Size = new System.Drawing.Size(187, 23);
            this.resText.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Запустить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Стоп работа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += Button1_Click;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Результат, px^2";
            // 
            // interv
            // 
            this.interv.Location = new System.Drawing.Point(6, 133);
            this.interv.Name = "interv";
            this.interv.Size = new System.Drawing.Size(188, 23);
            this.interv.Value = 1000;
            this.interv.Maximum = 60000;
            this.interv.Minimum = 100;
            this.interv.Increment = 100;
            this.interv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Интервал сна, мсек";
            // 
            // threadNum
            // 
            this.threadNum.Location = new System.Drawing.Point(7, 85);
            this.threadNum.Name = "threadNum";
            this.threadNum.Size = new System.Drawing.Size(188, 23);
            this.threadNum.Value = 1;
            this.threadNum.Maximum = 20;
            this.threadNum.Minimum = 1;
            this.threadNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество потоков";
            // 
            // rad
            // 
            this.rad.Location = new System.Drawing.Point(6, 37);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(188, 23);
            this.rad.Maximum = 500;
            this.rad.Minimum = 10;
            this.rad.Value = 50;
            this.rad.Increment = 10;
            this.rad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус круга";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рисование";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown interv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown threadNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

