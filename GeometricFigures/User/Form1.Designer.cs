﻿namespace GeometricFigures
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
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(58, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(231, 305);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 2;
            button1.Text = "Guardar y Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "";
            comboBox1.ForeColor = SystemColors.ActiveCaptionText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Círculo", "Cuadrado", "Triángulo", "Polígono Regular" });
            comboBox1.Location = new Point(12, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 5;
            label1.Text = "Seleccione figura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 87);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Radio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(58, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(58, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 116);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 10;
            label4.Text = "Lado 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 148);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Lado 2";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(58, 174);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 177);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Lado 3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(505, 117);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 15;
            label8.Text = "Área";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 163);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 16;
            label9.Text = "Perímetro";
            // 
            // label11
            // 
            label11.BackColor = SystemColors.Window;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(558, 117);
            label11.Name = "label11";
            label11.Size = new Size(152, 23);
            label11.TabIndex = 18;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.Window;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Location = new Point(558, 162);
            label12.Name = "label12";
            label12.Size = new Size(153, 23);
            label12.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(354, 305);
            button2.Name = "button2";
            button2.Size = new Size(117, 23);
            button2.TabIndex = 20;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(246, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 200);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 220);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 22;
            label3.Text = "Cantidad Lados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 261);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 23;
            label7.Text = "Medida";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(110, 258);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(753, 352);
            Controls.Add(textBox6);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Figuras Geométricas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox6;
    }
}
