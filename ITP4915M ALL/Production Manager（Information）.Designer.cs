using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ITP4915M_ALL
{
    partial class Form4
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
            label13 = new Label();
            label4 = new Label();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button6 = new Button();
            label5 = new Label();
            button8 = new Button();
            label6 = new Label();
            button9 = new Button();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
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
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(665, 9);
            label4.Name = "label4";
            label4.Size = new Size(268, 38);
            label4.TabIndex = 114;
            label4.Text = "Hi:123456(Production Manager)";
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(112, 53);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(398, 21);
            checkBox1.TabIndex = 122;
            checkBox1.Text = "[Confirm] | 2025-01-15 | 09:00 | Sales Dept | Order Confirmation";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(112, 80);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(406, 21);
            checkBox2.TabIndex = 123;
            checkBox2.Text = "[Confirm] | 2025-02-05 | 14:30 | Finance Dept | Payment Reminder";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(112, 107);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(456, 21);
            checkBox3.TabIndex = 124;
            checkBox3.Text = "[Confirm] | 2025-02-20 | 10:15 | Customer Service Dept | Inquiry Response";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(112, 134);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(387, 21);
            checkBox4.TabIndex = 125;
            checkBox4.Text = "[Confirm] | 2025-03-03 | 16:45 | Inventory Dept | Stock Update";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(112, 161);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(453, 21);
            checkBox5.TabIndex = 126;
            checkBox5.Text = "[Confirm] | 2025-03-18 | 13:20 | Supply Chain Dept | Delivery Delay Notice";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(900, 566);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 130;
            button6.TabStop = false;
            button6.Text = "Send";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Info;
            label5.Location = new Point(106, 376);
            label5.Name = "label5";
            label5.Size = new Size(704, 227);
            label5.TabIndex = 131;
            label5.Text = "Receiver：\r\n=============================================================================\r\nSubject ：\r\n=============================================================================";
            // 
            // button8
            // 
            button8.Location = new Point(816, 566);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 132;
            button8.Text = "Upload";
            button8.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.ForeColor = SystemColors.InactiveCaptionText;
            label6.Location = new Point(107, 256);
            label6.Name = "label6";
            label6.Size = new Size(880, 120);
            label6.TabIndex = 133;
            label6.Click += label6_Click;
            // 
            // button9
            // 
            button9.Location = new Point(9, 255);
            button9.Name = "button9";
            button9.Size = new Size(88, 33);
            button9.TabIndex = 138;
            button9.Text = "Information";
            button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(9, 189);
            button7.Name = "button7";
            button7.Size = new Size(88, 33);
            button7.TabIndex = 137;
            button7.Text = "Feedback";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(9, 128);
            button4.Name = "button4";
            button4.Size = new Size(88, 33);
            button4.TabIndex = 136;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(9, 67);
            button3.Name = "button3";
            button3.Size = new Size(88, 33);
            button3.TabIndex = 135;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(0, 50);
            label3.Name = "label3";
            label3.Size = new Size(106, 570);
            label3.TabIndex = 134;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 601);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(button8);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label13);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Staff:123456(Production Manager)";
            ResumeLayout(false);
            PerformLayout();
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
        private Label label13;
        private Label label4;
        private Button button2;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button6;
        private Label label5;
        private Button button8;
        private Label label6;
        private Button button9;
        private Button button7;
        private Button button4;
        private Button button3;
        private Label label3;
    }
}