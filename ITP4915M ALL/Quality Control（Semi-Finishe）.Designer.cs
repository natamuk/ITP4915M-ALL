using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_ALL
{
    partial class Quality_Control_Semi_Finishe_
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
            label13 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button6 = new Button();
            label5 = new Label();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            textBox1 = new TextBox();
            label10 = new Label();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            label11 = new Label();
            textBox2 = new TextBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            label12 = new Label();
            textBox3 = new TextBox();
            label14 = new Label();
            checkBox13 = new CheckBox();
            button7 = new Button();
            label15 = new Label();
            label16 = new Label();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button9
            // 
            button9.Location = new Point(9, 191);
            button9.Name = "button9";
            button9.Size = new Size(88, 33);
            button9.TabIndex = 121;
            button9.Text = "Semi-Finished";
            button9.UseVisualStyleBackColor = true;
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
            label13.Text = "Semi-Finishe";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Location = new Point(9, 128);
            button5.Name = "button5";
            button5.Size = new Size(88, 33);
            button5.TabIndex = 117;
            button5.Text = "RawMaterials";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(9, 321);
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
            label4.Text = "Hi:123456(Quality Control)";
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
            label3.Size = new Size(111, 570);
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
            // button1
            // 
            button1.Location = new Point(3, 258);
            button1.Name = "button1";
            button1.Size = new Size(102, 33);
            button1.TabIndex = 122;
            button1.Text = "FinalPackaging";
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(9, 321);
            button6.Name = "button6";
            button6.Size = new Size(88, 33);
            button6.TabIndex = 123;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Location = new Point(117, 70);
            label5.Name = "label5";
            label5.Size = new Size(867, 30);
            label5.TabIndex = 143;
            label5.Text = " Order Name | Order Type | Importance | Start Date | End Date\r\n";
            label5.Click += label5_Click;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(132, 211);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(347, 21);
            checkBox5.TabIndex = 142;
            checkBox5.Text = "ORD-005 | Customized | Mid | 2025-02-07 | 2025-02-13\r\n";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(132, 184);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(355, 21);
            checkBox4.TabIndex = 141;
            checkBox4.Text = "ORD-004 | Customized | HIGH | 2025-02-07 | 2025-02-12\r\n";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(132, 157);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(337, 21);
            checkBox3.TabIndex = 140;
            checkBox3.Text = "ORD-003 | Standard | LOW | 2025-02-07 | 2025-02-15";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(132, 130);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(340, 21);
            checkBox2.TabIndex = 139;
            checkBox2.Text = "ORD-002 | Standard | HIGH | 2025-02-07 | 2025-02-10";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(132, 103);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(352, 21);
            checkBox1.TabIndex = 138;
            checkBox1.Text = "ORD-001 | Customized | LOW | 2025-02-07 | 2025-02-15\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Location = new Point(120, 50);
            label6.Name = "label6";
            label6.Size = new Size(855, 20);
            label6.TabIndex = 144;
            label6.Text = "Today's Order";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 266);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 145;
            label7.Text = "Appearance";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(117, 329);
            label8.Name = "label8";
            label8.Size = new Size(96, 17);
            label8.TabIndex = 146;
            label8.Text = "Size and shape";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(117, 393);
            label9.Name = "label9";
            label9.Size = new Size(105, 17);
            label9.TabIndex = 147;
            label9.Text = "Assembly quality";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(120, 299);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(82, 21);
            checkBox6.TabIndex = 148;
            checkBox6.Text = "Scratches";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(208, 299);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(59, 21);
            checkBox7.TabIndex = 149;
            checkBox7.Text = "dents";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(273, 299);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(74, 21);
            checkBox8.TabIndex = 150;
            checkBox8.Text = "bubbles";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(398, 297);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 151;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(353, 300);
            label10.Name = "label10";
            label10.Size = new Size(39, 17);
            label10.TabIndex = 152;
            label10.Text = "other";
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(120, 360);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(93, 21);
            checkBox9.TabIndex = 153;
            checkBox9.Text = "Wrong size";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(219, 360);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(139, 21);
            checkBox10.TabIndex = 154;
            checkBox10.Text = "Shape deformation";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(364, 364);
            label11.Name = "label11";
            label11.Size = new Size(39, 17);
            label11.TabIndex = 156;
            label11.Text = "other";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(409, 361);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 155;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(120, 422);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(62, 21);
            checkBox11.TabIndex = 157;
            checkBox11.Text = "Loose";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(188, 422);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(51, 21);
            checkBox12.TabIndex = 158;
            checkBox12.Text = "Gap";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(245, 423);
            label12.Name = "label12";
            label12.Size = new Size(39, 17);
            label12.TabIndex = 160;
            label12.Text = "other";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 421);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 159;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(120, 455);
            label14.Name = "label14";
            label14.Size = new Size(60, 17);
            label14.TabIndex = 161;
            label14.Text = "Qualified";
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(120, 485);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(45, 21);
            checkBox13.TabIndex = 162;
            checkBox13.Text = "OK";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(120, 542);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 163;
            button7.Text = "save";
            button7.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.Info;
            label15.Location = new Point(557, 321);
            label15.Name = "label15";
            label15.Size = new Size(418, 84);
            label15.TabIndex = 165;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(557, 297);
            label16.Name = "label16";
            label16.Size = new Size(54, 17);
            label16.TabIndex = 166;
            label16.Text = "Opinion";
            // 
            // button8
            // 
            button8.Location = new Point(800, 417);
            button8.Name = "button8";
            button8.Size = new Size(175, 27);
            button8.TabIndex = 167;
            button8.Text = "Notify Production Manager";
            button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(571, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 203);
            pictureBox1.TabIndex = 168;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 601);
            Controls.Add(pictureBox1);
            Controls.Add(button8);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(button7);
            Controls.Add(checkBox13);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(textBox3);
            Controls.Add(checkBox12);
            Controls.Add(checkBox11);
            Controls.Add(label11);
            Controls.Add(textBox2);
            Controls.Add(checkBox10);
            Controls.Add(checkBox9);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button9);
            Controls.Add(label13);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Staff:123456(Quality Control)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSubmitReportRaw_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSaveRaw_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSubmitNotifyRaw_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonRecordDefectRaw_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button9;
        private Label label13;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label4;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button6;
        private Label label5;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private TextBox textBox1;
        private Label label10;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private Label label11;
        private TextBox textBox2;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private Label label12;
        private TextBox textBox3;
        private Label label14;
        private CheckBox checkBox13;
        private Button button7;
        private Label label15;
        private Label label16;
        private Button button8;
        private PictureBox pictureBox1;
    }
}