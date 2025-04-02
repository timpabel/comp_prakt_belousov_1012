namespace belousov_1012_2
{
    partial class task31
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
            circle5 = new ListBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox_y = new TextBox();
            textBox_x = new TextBox();
            draw_circle = new Button();
            label3 = new Label();
            rad = new TextBox();
            button2 = new Button();
            panel2 = new Panel();
            butup = new Button();
            butdown = new Button();
            butleft = new Button();
            butright = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // circle5
            // 
            circle5.FormattingEnabled = true;
            circle5.ItemHeight = 15;
            circle5.Location = new Point(459, 272);
            circle5.Name = "circle5";
            circle5.Size = new Size(215, 139);
            circle5.TabIndex = 7;
            circle5.SelectedIndexChanged += circle5_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_y);
            panel1.Controls.Add(textBox_x);
            panel1.Controls.Add(draw_circle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rad);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(459, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 227);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 40);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "radius";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 188);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 9;
            label5.Text = "y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 133);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 8;
            label4.Text = "x";
            // 
            // textBox_y
            // 
            textBox_y.Location = new Point(112, 180);
            textBox_y.Name = "textBox_y";
            textBox_y.Size = new Size(100, 23);
            textBox_y.TabIndex = 7;
            // 
            // textBox_x
            // 
            textBox_x.Location = new Point(112, 130);
            textBox_x.Name = "textBox_x";
            textBox_x.Size = new Size(100, 23);
            textBox_x.TabIndex = 6;
            // 
            // draw_circle
            // 
            draw_circle.Location = new Point(3, 161);
            draw_circle.Name = "draw_circle";
            draw_circle.Size = new Size(75, 23);
            draw_circle.TabIndex = 5;
            draw_circle.Text = "add_circle";
            draw_circle.UseVisualStyleBackColor = true;
            draw_circle.Click += draw_circle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 70);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // rad
            // 
            rad.Location = new Point(75, 34);
            rad.Name = "rad";
            rad.Size = new Size(100, 23);
            rad.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(86, 66);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "pSkrug";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 372);
            panel2.TabIndex = 8;
            // 
            // butup
            // 
            butup.Location = new Point(359, 109);
            butup.Name = "butup";
            butup.Size = new Size(62, 23);
            butup.TabIndex = 9;
            butup.Text = "up10";
            butup.UseVisualStyleBackColor = true;
            butup.Click += butup_Click;
            // 
            // butdown
            // 
            butdown.Location = new Point(359, 200);
            butdown.Name = "butdown";
            butdown.Size = new Size(62, 23);
            butdown.TabIndex = 10;
            butdown.Text = "down10";
            butdown.UseVisualStyleBackColor = true;
            butdown.Click += butdown_Click;
            // 
            // butleft
            // 
            butleft.Location = new Point(322, 155);
            butleft.Name = "butleft";
            butleft.Size = new Size(52, 23);
            butleft.TabIndex = 11;
            butleft.Text = "left10";
            butleft.UseVisualStyleBackColor = true;
            butleft.Click += butleft_Click;
            // 
            // butright
            // 
            butright.Location = new Point(401, 155);
            butright.Name = "butright";
            butright.Size = new Size(52, 23);
            butright.TabIndex = 12;
            butright.Text = "right10";
            butright.UseVisualStyleBackColor = true;
            butright.Click += butright_Click;
            // 
            // task31
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butleft);
            Controls.Add(butright);
            Controls.Add(butdown);
            Controls.Add(butup);
            Controls.Add(panel2);
            Controls.Add(circle5);
            Controls.Add(panel1);
            Name = "task31";
            Text = "task31";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox circle5;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox_y;
        private TextBox textBox_x;
        private Button draw_circle;
        private Label label3;
        private TextBox rad;
        private Button button2;
        public Panel panel2;
        private Button butup;
        private Button butdown;
        private Button butleft;
        private Button butright;
    }
}