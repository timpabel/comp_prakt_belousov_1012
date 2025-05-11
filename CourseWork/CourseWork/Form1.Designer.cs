namespace CourseWork
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
            textBox_ans = new TextBox();
            button_solve = new Button();
            label1 = new Label();
            matrix_size = new NumericUpDown();
            orig_matrix = new DataGridView();
            button_rnd_value = new Button();
            ((System.ComponentModel.ISupportInitialize)matrix_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orig_matrix).BeginInit();
            SuspendLayout();
            // 
            // textBox_ans
            // 
            textBox_ans.AccessibleRole = AccessibleRole.ScrollBar;
            textBox_ans.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_ans.Location = new Point(12, 423);
            textBox_ans.Multiline = true;
            textBox_ans.Name = "textBox_ans";
            textBox_ans.ReadOnly = true;
            textBox_ans.ScrollBars = ScrollBars.Vertical;
            textBox_ans.Size = new Size(756, 129);
            textBox_ans.TabIndex = 0;
            textBox_ans.TextChanged += textBox_ans_TextChanged;
            // 
            // button_solve
            // 
            button_solve.AutoSize = true;
            button_solve.Location = new Point(20, 380);
            button_solve.Name = "button_solve";
            button_solve.Size = new Size(150, 40);
            button_solve.TabIndex = 1;
            button_solve.Text = "Решить систему";
            button_solve.UseVisualStyleBackColor = true;
            button_solve.Click += button_solve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 2;
            label1.Text = "Размер системы:";
            // 
            // matrix_size
            // 
            matrix_size.Location = new Point(146, 18);
            matrix_size.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            matrix_size.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            matrix_size.Name = "matrix_size";
            matrix_size.Size = new Size(33, 23);
            matrix_size.TabIndex = 3;
            matrix_size.Value = new decimal(new int[] { 3, 0, 0, 0 });
            matrix_size.ValueChanged += matrix_size_ValueChanged;
            // 
            // orig_matrix
            // 
            orig_matrix.AllowUserToAddRows = false;
            orig_matrix.AllowUserToDeleteRows = false;
            orig_matrix.AllowUserToOrderColumns = true;
            orig_matrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orig_matrix.Location = new Point(20, 60);
            orig_matrix.Name = "orig_matrix";
            orig_matrix.RowHeadersVisible = false;
            orig_matrix.Size = new Size(740, 300);
            orig_matrix.TabIndex = 4;
            // 
            // button_rnd_value
            // 
            button_rnd_value.AutoSize = true;
            button_rnd_value.Location = new Point(214, 18);
            button_rnd_value.Name = "button_rnd_value";
            button_rnd_value.Size = new Size(134, 25);
            button_rnd_value.TabIndex = 5;
            button_rnd_value.Text = "Случайные значения";
            button_rnd_value.UseVisualStyleBackColor = true;
            button_rnd_value.Click += button_rnd_value_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(780, 552);
            Controls.Add(button_rnd_value);
            Controls.Add(orig_matrix);
            Controls.Add(matrix_size);
            Controls.Add(label1);
            Controls.Add(button_solve);
            Controls.Add(textBox_ans);
            Name = "Form1";
            Text = "Решение СЛАУ методом Гаусса";
            ((System.ComponentModel.ISupportInitialize)matrix_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)orig_matrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ans;
        private Button button_solve;
        private Label label1;
        private NumericUpDown matrix_size;
        private DataGridView orig_matrix;
        private Button button_rnd_value;
    }
}
