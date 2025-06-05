using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_ALL
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
            button6 = new Button();
            label12 = new Label();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox8 = new TextBox();
            label14 = new Label();
            label11 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label15 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(12, 191);
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
            label13.Text = "Timeline";
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
            label4.Click += label4_Click;
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
            // button6
            // 
            button6.Location = new Point(900, 566);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 130;
            button6.TabStop = false;
            button6.Text = "Completed \\";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(335, 503);
            label12.Name = "label12";
            label12.Size = new Size(25, 17);
            label12.TabIndex = 155;
            label12.Text = "TO";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(363, 500);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 154;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(229, 500);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 153;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(120, 503);
            label10.Name = "label10";
            label10.Size = new Size(101, 17);
            label10.TabIndex = 152;
            label10.Text = "production time";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(605, 460);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 151;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(492, 463);
            label14.Name = "label14";
            label14.Size = new Size(75, 17);
            label14.TabIndex = 150;
            label14.Text = "Precedence";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(120, 537);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 149;
            label11.Text = "Material";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(229, 534);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(338, 23);
            textBox6.TabIndex = 148;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(229, 566);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 147;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 466);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 143;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 569);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 142;
            label9.Text = "Order Type";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(120, 466);
            label15.Name = "label15";
            label15.Size = new Size(95, 17);
            label15.TabIndex = 138;
            label15.Text = "Order Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(492, 506);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 156;
            label6.Text = "Guest Request";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Info;
            label7.Location = new Point(590, 503);
            label7.Name = "label7";
            label7.Size = new Size(203, 83);
            label7.TabIndex = 157;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(108, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(365, 21);
            checkBox1.TabIndex = 132;
            checkBox1.Text = "ORD-001 | Customized | Middle | 2025-02-03 | 2025-02-15\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(108, 110);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(340, 21);
            checkBox2.TabIndex = 133;
            checkBox2.Text = "ORD-002 | Standard | HIGH | 2025-02-01 | 2025-02-10";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(108, 137);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(332, 21);
            checkBox3.TabIndex = 134;
            checkBox3.Text = "ORD-003 | Standard | Low | 2025-02-05 | 2025-02-09";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(108, 164);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(355, 21);
            checkBox4.TabIndex = 135;
            checkBox4.Text = "ORD-004 | Customized | HIGH | 2025-02-07 | 2025-02-12\r\n";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(108, 191);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(347, 21);
            checkBox5.TabIndex = 136;
            checkBox5.Text = "ORD-005 | Customized | Mid | 2025-02-07 | 2025-02-14\r\n";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Location = new Point(108, 50);
            label5.Name = "label5";
            label5.Size = new Size(867, 30);
            label5.TabIndex = 137;
            label5.Text = "   Product Name | Order Type | Importance | Start Date | End Date\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 601);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label15);
            Controls.Add(label5);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button6);
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
            Name = "Form1";
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
        private Button button6;
        private Label label12;
        private TextBox textBox10;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox8;
        private Label label14;
        private Label label11;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox1;
        private Label label9;
        private Label label15;
        private Label label6;
        private Label label7;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label5;
    }
}