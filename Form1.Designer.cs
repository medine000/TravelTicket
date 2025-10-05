namespace travelTicket
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PeachPuff;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 361);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marsurut";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(367, 51);
            button1.Name = "button1";
            button1.Size = new Size(42, 105);
            button1.TabIndex = 10;
            button1.Text = "<   >";
            button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(122, 223);
            maskedTextBox2.Mask = "90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(217, 27);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(123, 168);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(216, 27);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 286);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 6;
            label5.Text = "Yer :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 230);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 5;
            label4.Text = "Saat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 175);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Tarix :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 120);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Haraya :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Baki", "Berlin", "Amsterdam", "Frankfurt", "Roma" });
            comboBox2.Location = new Point(126, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 28);
            comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baki", "Berlin", "Amsterdam", "Frankfurt", "Roma" });
            comboBox1.Location = new Point(124, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Haradan :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.PeachPuff;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(563, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 361);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sernisin melumatlari";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(181, 271);
            button2.Name = "button2";
            button2.Size = new Size(226, 50);
            button2.TabIndex = 8;
            button2.Text = "Bilet al";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(184, 148);
            maskedTextBox4.Mask = "(999) 000-0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(223, 27);
            maskedTextBox4.TabIndex = 7;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(184, 96);
            maskedTextBox3.Mask = "00000-9999";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(220, 27);
            maskedTextBox3.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 212);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 5;
            label9.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 148);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 4;
            label8.Text = "Telefon :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 93);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 3;
            label7.Text = "SV/seriasi :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 45);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 2;
            label6.Text = "Ad ve Soyad :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 27);
            textBox2.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(43, 398);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(945, 84);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(43, 502);
            button3.Name = "button3";
            button3.Size = new Size(228, 58);
            button3.TabIndex = 3;
            button3.Text = "Siyahidan silmek";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(764, 502);
            button4.Name = "button4";
            button4.Size = new Size(227, 58);
            button4.TabIndex = 4;
            button4.Text = "Proqramdan cixis";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1023, 607);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
    }
}
