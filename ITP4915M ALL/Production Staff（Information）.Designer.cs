using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_ALL
{
    partial class Form2
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
        /// </br> </summary>
        private void InitializeComponent()
        {
            button9 = new Button();
            button7 = new Button();
            label13 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label10 = new Label();
            checkBox6 = new CheckBox();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(9, 191);
            button9.Name = "button9";
            button9.Size = new Size(88, 33);
            button9.TabIndex = 121;
            button9.Text = "Information";
            button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(9, 191);
            button7.Name = "button7";
            button7.Size = new Size(88, 33);
            button7.TabIndex = 120;
            button7.Text = "Feedback";
            button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoEllipsis = true;
            label13.BackColor = SystemColors.ActiveCaption;
            label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label13.Location = new Point(375, 9);
            label13.Name = "label13";
            label13.Size = new Size(232, 38);
            label13.TabIndex = 119;
            label13.Text = "Information";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Location = new Point(9, 128);
            button5.Name = "button5";
            button5.Size = new Size(88, 33);
            button5.TabIndex = 117;
            button5.Text = "Timeline";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(9, 128);
            button4.Name = "button4";
            button4.Size = new Size(88, 33);
            button4.TabIndex = 116;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(9, 67);
            button3.Name = "button3";
            button3.Size = new Size(88, 33);
            button3.TabIndex = 115;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(665, 9);
            label4.Name = "label4";
            label4.Size = new Size(268, 38);
            label4.TabIndex = 114;
            label4.Text = "Hi:123456(Production Staff)";
            // 
            // button2
            // 
            button2.Location = new Point(939, 0);
            button2.Name = "button2";
            button2.Size = new Size(48, 50);
            button2.TabIndex = 113;
            button2.Text = "Sign out";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(0, 50);
            label3.Name = "label3";
            label3.Size = new Size(106, 570);
            label3.TabIndex = 112;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(363, 50);
            label2.TabIndex = 111;
            label2.Text = "Smile & Sunshine Toy Co, Ltd.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(-41, 0);
            label1.Name = "label1";
            label1.Size = new Size(1040, 50);
            label1.TabIndex = 110;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 67);
            label5.Name = "label5";
            label5.Size = new Size(78, 17);
            label5.TabIndex = 122;
            label5.Text = "Categories :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 95);
            label6.Name = "label6";
            label6.Size = new Size(61, 17);
            label6.TabIndex = 123;
            label6.Text = "Opinion :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 124;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Info;
            label7.Location = new Point(179, 95);
            label7.Name = "label7";
            label7.Size = new Size(231, 278);
            label7.TabIndex = 125;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 401);
            label8.Name = "label8";
            label8.Size = new Size(124, 17);
            label8.TabIndex = 126;
            label8.Text = "Employee Number :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(242, 401);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 127;
            textBox2.Text = "123456";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(112, 444);
            label9.Name = "label9";
            label9.Size = new Size(46, 17);
            label9.TabIndex = 128;
            label9.Text = "Date : ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(164, 444);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 23);
            textBox3.TabIndex = 129;
            textBox3.Text = "2025";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(220, 444);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(43, 23);
            textBox4.TabIndex = 130;
            textBox4.Text = "12";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(269, 444);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(43, 23);
            textBox5.TabIndex = 131;
            textBox5.Text = "29";
            // 
            // button1
            // 
            button1.Location = new Point(115, 487);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 132;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(427, 158);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(445, 21);
            checkBox5.TabIndex = 137;
            checkBox5.Text = "[Production Manager] | 2025-01-19 | 09:00 | Already sent your feedback";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(427, 131);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(445, 21);
            checkBox4.TabIndex = 136;
            checkBox4.Text = "[Production Manager] | 2025-01-18 | 09:00 | Already sent your feedback";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(427, 104);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(445, 21);
            checkBox3.TabIndex = 135;
            checkBox3.Text = "[Production Manager] | 2025-01-17 | 09:00 | Already sent your feedback";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(427, 77);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(445, 21);
            checkBox2.TabIndex = 134;
            checkBox2.Text = "[Production Manager] | 2025-01-16 | 09:00 | Already sent your feedback";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(427, 50);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(560, 21);
            checkBox1.TabIndex = 133;
            checkBox1.Text = "[Production Manager] | 2025-01-15 | 09:00 | Already sent your feedback";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.Info;
            label10.Location = new Point(427, 401);
            label10.Name = "label10";
            label10.Size = new Size(560, 203);
            label10.TabIndex = 138;
            label10.Text = "Categories : Machine\r\nOpinion : The machine cannot operate and cannot produce items.\r\nEmployee Number : 123456\r\nDate : 2025-01-15";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(427, 185);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(353, 21);
            checkBox6.TabIndex = 139;
            checkBox6.Text = "[Production Manager] | 2025-01-20 | 10:00 | You're fired";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 601);
            Controls.Add(checkBox6);
            Controls.Add(label10);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(label13);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Staff:123456(Production Staff)";
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button9;
        private Button button7;
        private Label label13;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label4;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label10;
        private CheckBox checkBox6;
    }
}