namespace C_Sharp_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ax = new System.Windows.Forms.NumericUpDown();
            this.ay = new System.Windows.Forms.NumericUpDown();
            this.az = new System.Windows.Forms.NumericUpDown();
            this.bz = new System.Windows.Forms.NumericUpDown();
            this.by = new System.Windows.Forms.NumericUpDown();
            this.bx = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.az)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.by)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bx)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(13, 54);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(22, 13);
            this.a.TabIndex = 0;
            this.a.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "z";
            // 
            // ax
            // 
            this.ax.Location = new System.Drawing.Point(41, 54);
            this.ax.Name = "ax";
            this.ax.Size = new System.Drawing.Size(33, 20);
            this.ax.TabIndex = 6;
            // 
            // ay
            // 
            this.ay.Location = new System.Drawing.Point(90, 54);
            this.ay.Name = "ay";
            this.ay.Size = new System.Drawing.Size(33, 20);
            this.ay.TabIndex = 7;
            // 
            // az
            // 
            this.az.Location = new System.Drawing.Point(138, 54);
            this.az.Name = "az";
            this.az.Size = new System.Drawing.Size(33, 20);
            this.az.TabIndex = 8;
            // 
            // bz
            // 
            this.bz.Location = new System.Drawing.Point(138, 80);
            this.bz.Name = "bz";
            this.bz.Size = new System.Drawing.Size(33, 20);
            this.bz.TabIndex = 11;
            // 
            // by
            // 
            this.by.Location = new System.Drawing.Point(90, 80);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(33, 20);
            this.by.TabIndex = 10;
            // 
            // bx
            // 
            this.bx.Location = new System.Drawing.Point(41, 80);
            this.bx.Name = "bx";
            this.bx.Size = new System.Drawing.Size(33, 20);
            this.bx.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Вычислить длину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Сложить вектора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Произведение ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 155);
            this.textBox1.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(571, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "найти вектор d";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(571, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "найти вектор c";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 431);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bz);
            this.Controls.Add(this.by);
            this.Controls.Add(this.bx);
            this.Controls.Add(this.az);
            this.Controls.Add(this.ay);
            this.Controls.Add(this.ax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.az)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.by)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ax;
        private System.Windows.Forms.NumericUpDown ay;
        private System.Windows.Forms.NumericUpDown az;
        private System.Windows.Forms.NumericUpDown bz;
        private System.Windows.Forms.NumericUpDown by;
        private System.Windows.Forms.NumericUpDown bx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

