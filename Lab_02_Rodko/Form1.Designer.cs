﻿namespace Lab_02_Rodko
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_16code = new System.Windows.Forms.TextBox();
            this.textBox_10code = new System.Windows.Forms.TextBox();
            this.textBox_2code = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "=p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "=Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "=C";
            // 
            // textBox_16code
            // 
            this.textBox_16code.Location = new System.Drawing.Point(347, 88);
            this.textBox_16code.Name = "textBox_16code";
            this.textBox_16code.Size = new System.Drawing.Size(100, 22);
            this.textBox_16code.TabIndex = 24;
            // 
            // textBox_10code
            // 
            this.textBox_10code.Location = new System.Drawing.Point(347, 60);
            this.textBox_10code.Name = "textBox_10code";
            this.textBox_10code.Size = new System.Drawing.Size(100, 22);
            this.textBox_10code.TabIndex = 23;
            // 
            // textBox_2code
            // 
            this.textBox_2code.Location = new System.Drawing.Point(347, 32);
            this.textBox_2code.Name = "textBox_2code";
            this.textBox_2code.Size = new System.Drawing.Size(100, 22);
            this.textBox_2code.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "XOR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Прибрати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(148, 85);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 22);
            this.textBox_C.TabIndex = 19;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(148, 57);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key.TabIndex = 18;
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(148, 29);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 22);
            this.textBox_P.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "C=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Key=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "P=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_16code);
            this.Controls.Add(this.textBox_10code);
            this.Controls.Add(this.textBox_2code);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_16code;
        private System.Windows.Forms.TextBox textBox_10code;
        private System.Windows.Forms.TextBox textBox_2code;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

