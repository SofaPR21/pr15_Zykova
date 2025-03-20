namespace pr15_Zukova
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
            textBox1 = new TextBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            listBox3 = new ListBox();
            button3 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            button1 = new Button();
            listBox2 = new ListBox();
            panel1 = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите размерность массива:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(250, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 64);
            listBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(250, 95);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 6;
            button2.Text = "Вывести элемент";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 192);
            label3.Location = new Point(250, 32);
            label3.Name = "label3";
            label3.Size = new Size(149, 30);
            label3.TabIndex = 8;
            label3.Text = "Введите индекс элемента,\r\nкоторый хотите вывести:";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(37, 357);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 64);
            listBox3.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(37, 328);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Вывести";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(128, 128, 255);
            label5.Location = new Point(37, 266);
            label5.Name = "label5";
            label5.Size = new Size(185, 30);
            label5.TabIndex = 10;
            label5.Text = "Введите число, на которое\r\nумножаются элементы массива";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 299);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Location = new Point(237, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 180);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Location = new Point(20, 259);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 172);
            panel3.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(37, 130);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 5;
            label2.Text = "Вывести весь массив:";
            // 
            // button1
            // 
            button1.Location = new Point(37, 150);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Вывести";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(37, 179);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 64);
            listBox2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Location = new Point(21, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 129);
            panel1.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(button4);
            panel4.Location = new Point(20, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 100);
            panel4.TabIndex = 17;
            // 
            // button4
            // 
            button4.Location = new Point(17, 62);
            button4.Name = "button4";
            button4.Size = new Size(120, 23);
            button4.TabIndex = 18;
            button4.Text = "Создать массив";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private ListBox listBox3;
        private Button button3;
        private Label label5;
        private TextBox textBox3;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button button1;
        private ListBox listBox2;
        private Panel panel1;
        private Panel panel4;
        private Button button4;
    }
}
