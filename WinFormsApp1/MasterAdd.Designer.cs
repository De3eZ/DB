﻿namespace WinFormsApp1
{
    partial class MasterAdd
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
            textBox11 = new TextBox();
            button1 = new Button();
            label11 = new Label();
            textBox10 = new TextBox();
            label10 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox11
            // 
            textBox11.Location = new Point(403, 91);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(125, 27);
            textBox11.TabIndex = 94;
            // 
            // button1
            // 
            button1.Location = new Point(305, 350);
            button1.Name = "button1";
            button1.Size = new Size(142, 47);
            button1.TabIndex = 93;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(270, 94);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 92;
            label11.Text = "Имя";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(403, 145);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 91;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(270, 148);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 90;
            label10.Text = "Отчество";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(403, 255);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 258);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 78;
            label4.Text = "Зарплата";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(403, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 198);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 74;
            label2.Text = "Стаж";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(403, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 45);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 72;
            label1.Text = "Фамилия";
            // 
            // MasterAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox11);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(textBox10);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MasterAdd";
            Text = "MasterAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox11;
        private Button button1;
        private Label label11;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}