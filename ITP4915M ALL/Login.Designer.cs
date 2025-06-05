using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITP4915M_ALL
{
    partial class Login
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new System.Drawing.Font("Mistral", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, -1);
            label2.Name = "label2";
            label2.Size = new Size(334, 66);
            label2.TabIndex = 28;
            label2.Text = "Smile & Sunshine Toy\r\n";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(-53, -1);
            label1.Name = "label1";
            label1.Size = new Size(1076, 66);
            label1.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 123);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 31;
            label3.Text = "Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 204);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 32;
            label4.Text = "password:";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(0, 310);
            label5.Name = "label5";
            label5.Size = new Size(895, 101);
            label5.TabIndex = 33;
            label5.Text = "Customer Service Number:12345456   Company WhatsApp:123124124521412   Customer Service Hours:7:00am-10:30pm";
            // 
            // button1
            // 
            button1.Location = new Point(395, 256);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 34;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(476, 256);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 35;
            button2.Text = "register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(598, 256);
            button3.Name = "button3";
            button3.Size = new Size(120, 23);
            button3.TabIndex = 36;
            button3.Text = "Forgot Password";
            button3.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 380);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Smile & Sunshine Toy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}