using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_ALL
{
    partial class Form3
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button6 = new Button();
            label11 = new Label();
            label14 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox10 = new TextBox();
            label12 = new Label();
            button9 = new Button();
            button7 = new Button();
            label13 = new Label();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox7 = new TextBox();
            button8 = new Button();
            label15 = new Label();
            textBox11 = new TextBox();
            label16 = new Label();
            textBox12 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label19 = new Label();
            textBox9 = new TextBox();
            label20 = new Label();
            label21 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 419);
            label5.Name = "label5";
            label5.Size = new Size(95, 17);
            label5.TabIndex = 14;
            label5.Text = "Order Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 456);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 15;
            label6.Text = "Product Name";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(128, 493);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 16;
            label7.Text = "Order Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(128, 530);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 17;
            label8.Text = "Delivery date";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(343, 419);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 18;
            label9.Text = "Order Type";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 416);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 453);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 490);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(237, 527);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(503, 416);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(503, 456);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(237, 23);
            textBox6.TabIndex = 25;
            // 
            // button6
            // 
            button6.Location = new Point(1255, 579);
            button6.Name = "button6";
            button6.Size = new Size(150, 23);
            button6.TabIndex = 26;
            button6.Text = "Confirmation Review";
            button6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(343, 459);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 28;
            label11.Text = "Material";
            label11.Click += label11_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(343, 493);
            label14.Name = "label14";
            label14.Size = new Size(75, 17);
            label14.TabIndex = 34;
            label14.Text = "Precedence";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(503, 490);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 530);
            label10.Name = "label10";
            label10.Size = new Size(162, 17);
            label10.TabIndex = 36;
            label10.Text = "Estimated production time";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(648, 527);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 38;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(613, 530);
            label12.Name = "label12";
            label12.Size = new Size(25, 17);
            label12.TabIndex = 39;
            label12.Text = "TO";
            // 
            // button9
            // 
            button9.Location = new Point(9, 255);
            button9.Name = "button9";
            button9.Size = new Size(88, 33);
            button9.TabIndex = 109;
            button9.Text = "Information";
            button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(9, 189);
            button7.Name = "button7";
            button7.Size = new Size(88, 33);
            button7.TabIndex = 108;
            button7.Text = "Feedback";
            button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoEllipsis = true;
            label13.BackColor = SystemColors.ActiveCaption;
            label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label13.Location = new Point(590, 9);
            label13.Name = "label13";
            label13.Size = new Size(232, 38);
            label13.TabIndex = 107;
            label13.Text = "Order";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Location = new Point(9, 128);
            button4.Name = "button4";
            button4.Size = new Size(88, 33);
            button4.TabIndex = 104;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(9, 67);
            button3.Name = "button3";
            button3.Size = new Size(88, 33);
            button3.TabIndex = 103;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(1096, 9);
            label4.Name = "label4";
            label4.Size = new Size(268, 38);
            label4.TabIndex = 102;
            label4.Text = "Hi:123456(Production Manager)";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1370, 0);
            button2.Name = "button2";
            button2.Size = new Size(48, 50);
            button2.TabIndex = 101;
            button2.Text = "Sign out";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(0, 50);
            label3.Name = "label3";
            label3.Size = new Size(106, 570);
            label3.TabIndex = 100;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(363, 50);
            label2.TabIndex = 99;
            label2.Text = "Smile & Sunshine Toy Co, Ltd.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(-41, 0);
            label1.Name = "label1";
            label1.Size = new Size(1495, 50);
            label1.TabIndex = 98;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Info;
            textBox7.Location = new Point(1172, 413);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(148, 23);
            textBox7.TabIndex = 111;
            // 
            // button8
            // 
            button8.Location = new Point(1330, 413);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 110;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(128, 566);
            label15.Name = "label15";
            label15.Size = new Size(36, 17);
            label15.TabIndex = 112;
            label15.Text = "Price";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(237, 560);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(100, 23);
            textBox11.TabIndex = 113;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(343, 566);
            label16.Name = "label16";
            label16.Size = new Size(57, 17);
            label16.TabIndex = 114;
            label16.Text = "Machine";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(503, 563);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 115;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1172, 439);
            label17.Name = "label17";
            label17.Size = new Size(92, 17);
            label17.TabIndex = 116;
            label17.Text = "Guest Request";
            // 
            // label18
            // 
            label18.BackColor = SystemColors.Info;
            label18.Location = new Point(1172, 459);
            label18.Name = "label18";
            label18.Size = new Size(233, 104);
            label18.TabIndex = 117;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(503, 527);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(112, 23);
            dateTimePicker1.TabIndex = 118;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(636, 527);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(112, 23);
            dateTimePicker2.TabIndex = 119;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(761, 419);
            label19.Name = "label19";
            label19.Size = new Size(56, 17);
            label19.TabIndex = 120;
            label19.Text = "Quantity";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(827, 416);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 121;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(746, 459);
            label20.Name = "label20";
            label20.Size = new Size(81, 17);
            label20.TabIndex = 122;
            label20.Text = "Specification";
            // 
            // label21
            // 
            label21.BackColor = SystemColors.ButtonHighlight;
            label21.Location = new Point(827, 456);
            label21.Name = "label21";
            label21.Size = new Size(334, 107);
            label21.TabIndex = 123;
            label21.Text = "Good toys\t          Material: Plastic\r\n                         Color: Black";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1312, 267);
            dataGridView1.TabIndex = 124;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(106, 50);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1312, 92);
            dataGridView2.TabIndex = 125;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 601);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(textBox9);
            Controls.Add(label19);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(textBox12);
            Controls.Add(label16);
            Controls.Add(textBox11);
            Controls.Add(label15);
            Controls.Add(textBox7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(label13);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(textBox10);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(button6);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "Form3";
            Text = "Staff:123456(Production Manager)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button6;
        private Label label11;
        private Label label14;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox10;
        private Label label12;
        private Button button9;
        private Button button7;
        private Label label13;
        private Button button4;
        private Button button3;
        private Label label4;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private Button button8;
        private Label label15;
        private TextBox textBox11;
        private Label label16;
        private TextBox textBox12;
        private Label label17;
        private Label label18;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label19;
        private TextBox textBox9;
        private Label label20;
        private Label label21;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}