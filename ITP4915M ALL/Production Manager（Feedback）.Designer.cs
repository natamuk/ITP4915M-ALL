using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_ALL
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            label5 = new Label();
            button8 = new Button();
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
            label13.Text = "Feedback";
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
            checkBox1.Size = new Size(391, 21);
            checkBox1.TabIndex = 122;
            checkBox1.Text = "2025-01-15: Material quality issues: Machine 1A (Human Error)\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(112, 80);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(441, 21);
            checkBox2.TabIndex = 123;
            checkBox2.Text = "2025-02-05: Equipment malfunction: Machine 1A (Machine Malfunction)\n";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(112, 107);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(366, 21);
            checkBox3.TabIndex = 124;
            checkBox3.Text = "2025-02-20: Production delays: Machine 2B (Human Error)\n";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(112, 134);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(372, 21);
            checkBox4.TabIndex = 125;
            checkBox4.Text = "2025-03-03: Poor workmanship: Machine 3C (Human Error)\n";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(112, 161);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(362, 21);
            checkBox5.TabIndex = 126;
            checkBox5.Text = "2025-03-18: Packaging issues: Machine 4D (Human Error)\n";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(106, 359);
            label5.Name = "label5";
            label5.Size = new Size(669, 242);
            label5.TabIndex = 129;
            label5.Text = resources.GetString("label5.Text");
            label5.Click += label5_Click;
            // 
            // button8
            // 
            button8.Location = new Point(781, 578);
            button8.Name = "button8";
            button8.Size = new Size(194, 23);
            button8.TabIndex = 132;
            button8.Text = "Save";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(9, 255);
            button9.Name = "button9";
            button9.Size = new Size(88, 33);
            button9.TabIndex = 137;
            button9.Text = "Information";
            button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(9, 189);
            button7.Name = "button7";
            button7.Size = new Size(88, 33);
            button7.TabIndex = 136;
            button7.Text = "Feedback";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(9, 128);
            button4.Name = "button4";
            button4.Size = new Size(88, 33);
            button4.TabIndex = 135;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(9, 67);
            button3.Name = "button3";
            button3.Size = new Size(88, 33);
            button3.TabIndex = 134;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(0, 50);
            label3.Name = "label3";
            label3.Size = new Size(106, 570);
            label3.TabIndex = 133;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 601);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button8);
            Controls.Add(label5);
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
            Name = "Form4";
            Text = "Staff:123456(Production Manager)";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label5_Click(object sender, EventArgs e)
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
        private Label label5;
        private Button button8;
        private Button button9;
        private Button button7;
        private Button button4;
        private Button button3;
        private Label label3;
    }
}