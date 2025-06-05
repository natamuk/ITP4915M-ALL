using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_ALL
{
    partial class Quality_Control_Reports_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button7 = new Button();
            button8 = new Button();
            button10 = new Button();
            button11 = new Button();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
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
            label13.Text = "Reports";
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
            label5.AutoSize = true;
            label5.Location = new Point(117, 67);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 124;
            label5.Text = "Stage : ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 126;
            textBox2.Text = "2025-01-01";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(329, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 127;
            textBox3.Text = "2025-03-15";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 111);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 129;
            label6.Text = "Start :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 111);
            label7.Name = "label7";
            label7.Size = new Size(37, 17);
            label7.TabIndex = 130;
            label7.Text = "End :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 191);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 131;
            label8.Text = "Report";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(117, 161);
            label9.Name = "label9";
            label9.Size = new Size(59, 17);
            label9.TabIndex = 132;
            label9.Text = "Defecte :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(117, 329);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 133;
            label10.Text = "Detailed";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(117, 448);
            label11.Name = "label11";
            label11.Size = new Size(81, 17);
            label11.TabIndex = 134;
            label11.Text = "Notifications";
            // 
            // button7
            // 
            button7.Location = new Point(861, 320);
            button7.Name = "button7";
            button7.Size = new Size(114, 23);
            button7.TabIndex = 138;
            button7.Text = "View Full";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(320, 158);
            button8.Name = "button8";
            button8.Size = new Size(109, 23);
            button8.TabIndex = 139;
            button8.Text = "Apply Filters";
            button8.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(254, 566);
            button10.Name = "button10";
            button10.Size = new Size(109, 23);
            button10.TabIndex = 140;
            button10.Text = "Generate PDF";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(117, 566);
            button11.Name = "button11";
            button11.Size = new Size(113, 23);
            button11.TabIndex = 141;
            button11.Text = "Export Report";
            button11.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ButtonHighlight;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(115, 208);
            label12.Name = "label12";
            label12.Size = new Size(860, 109);
            label12.TabIndex = 142;
            label12.Text = "Total Defects: 15\r\nRaw Materials: 5 (Impurities: 3, Color Variation: 2)\r\nSemi-Finished: 6 (Scratches: 3, Deformation: 3)\r\nFinal Packaging: 4 (Incorrect Label: 2, Torn Packaging: 2)";
            // 
            // label14
            // 
            label14.BackColor = SystemColors.ButtonHighlight;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Location = new Point(119, 346);
            label14.Name = "label14";
            label14.Size = new Size(856, 102);
            label14.TabIndex = 143;
            label14.Text = resources.GetString("label14.Text");
            // 
            // label15
            // 
            label15.BackColor = SystemColors.ButtonHighlight;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(119, 465);
            label15.Name = "label15";
            label15.Size = new Size(856, 98);
            label15.TabIndex = 144;
            label15.Text = "2025-03-15: Notified Supplier (Impurities in plastic, 3 units)\r\n2025-03-14: Notified Production Manager (Scratches on 3 units)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 145;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(182, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 25);
            comboBox2.TabIndex = 146;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 601);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
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
            Name = "Form2";
            Text = "Staff:123456(Quality Control)";
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button11;
        private Label label12;
        private Label label14;
        private Label label15;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}