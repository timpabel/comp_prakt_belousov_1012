namespace belousov_1012_2
{
    partial class task34
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
            butt_add_square = new Button();
            butt_move_square = new Button();
            butt_ChangeSize = new Button();
            buut_color = new Button();
            Squares = new ListBox();
            panel1 = new Panel();
            textBox_side = new TextBox();
            textBox_X = new TextBox();
            textBox_Y = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // butt_add_square
            // 
            butt_add_square.Location = new Point(344, 69);
            butt_add_square.Name = "butt_add_square";
            butt_add_square.Size = new Size(89, 23);
            butt_add_square.TabIndex = 0;
            butt_add_square.Text = "add_square";
            butt_add_square.UseVisualStyleBackColor = true;
            butt_add_square.Click += butt_add_square_Click;
            // 
            // butt_move_square
            // 
            butt_move_square.Location = new Point(344, 113);
            butt_move_square.Name = "butt_move_square";
            butt_move_square.Size = new Size(89, 23);
            butt_move_square.TabIndex = 1;
            butt_move_square.Text = "move_square";
            butt_move_square.UseVisualStyleBackColor = true;
            // 
            // butt_ChangeSize
            // 
            butt_ChangeSize.Location = new Point(344, 160);
            butt_ChangeSize.Name = "butt_ChangeSize";
            butt_ChangeSize.Size = new Size(89, 23);
            butt_ChangeSize.TabIndex = 2;
            butt_ChangeSize.Text = "CangeSize10";
            butt_ChangeSize.UseVisualStyleBackColor = true;
            butt_ChangeSize.Click += butt_ChangeSize_Click;
            // 
            // buut_color
            // 
            buut_color.Location = new Point(344, 243);
            buut_color.Name = "buut_color";
            buut_color.Size = new Size(89, 23);
            buut_color.TabIndex = 3;
            buut_color.Text = "Change_color";
            buut_color.UseVisualStyleBackColor = true;
            buut_color.Click += buut_color_Click;
            // 
            // Squares
            // 
            Squares.FormattingEnabled = true;
            Squares.ItemHeight = 15;
            Squares.Location = new Point(455, 218);
            Squares.Name = "Squares";
            Squares.Size = new Size(333, 124);
            Squares.TabIndex = 4;
            Squares.SelectedIndexChanged += Squares_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 453);
            panel1.TabIndex = 5;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // textBox_side
            // 
            textBox_side.Location = new Point(562, 74);
            textBox_side.Name = "textBox_side";
            textBox_side.Size = new Size(100, 23);
            textBox_side.TabIndex = 6;
            // 
            // textBox_X
            // 
            textBox_X.Location = new Point(562, 161);
            textBox_X.Name = "textBox_X";
            textBox_X.Size = new Size(100, 23);
            textBox_X.TabIndex = 7;
            // 
            // textBox_Y
            // 
            textBox_Y.Location = new Point(562, 114);
            textBox_Y.Name = "textBox_Y";
            textBox_Y.Size = new Size(100, 23);
            textBox_Y.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 77);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 9;
            label1.Text = "Сторона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 122);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 10;
            label2.Text = "У";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 169);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 11;
            label3.Text = "Х";
            // 
            // button1
            // 
            button1.Location = new Point(344, 202);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 12;
            button1.Text = "CangeSize-10";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // task34
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Y);
            Controls.Add(textBox_X);
            Controls.Add(textBox_side);
            Controls.Add(panel1);
            Controls.Add(Squares);
            Controls.Add(buut_color);
            Controls.Add(butt_ChangeSize);
            Controls.Add(butt_move_square);
            Controls.Add(butt_add_square);
            Name = "task34";
            Text = "task34";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butt_add_square;
        private Button butt_move_square;
        private Button butt_ChangeSize;
        private Button buut_color;
        private ListBox Squares;
        private Panel panel1;
        private TextBox textBox_side;
        private TextBox textBox_X;
        private TextBox textBox_Y;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColorDialog colorDialog1;
        private Button button1;
    }
}