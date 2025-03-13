namespace belousov_1012_2
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            colorDialog1 = new ColorDialog();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(119, 310);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 260);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(128, 209);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "oooooop";
            // 
            // panel1
            // 
            panel1.Location = new Point(375, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 184);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(264, 310);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(140, 362);
            button3.Name = "button3";
            button3.Size = new Size(75, 56);
            button3.TabIndex = 7;
            button3.Text = "вывести текст в лист бокс";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(443, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(175, 169);
            listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            ForeColor = Color.Blue;
            Name = "Form1";
            Text = "примеры элементов управления";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private ColorDialog colorDialog1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
    }
}