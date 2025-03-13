namespace belousov_1012_2
{
    partial class Form2
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
            sum = new Button();
            vichitanie = new Button();
            del = new Button();
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // sum
            // 
            sum.BackColor = Color.FromArgb(128, 255, 128);
            sum.Location = new Point(174, 37);
            sum.Name = "sum";
            sum.Size = new Size(75, 41);
            sum.TabIndex = 0;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = false;
            sum.Click += sum_Click;
            // 
            // vichitanie
            // 
            vichitanie.BackColor = Color.Lime;
            vichitanie.Location = new Point(174, 84);
            vichitanie.Name = "vichitanie";
            vichitanie.Size = new Size(75, 43);
            vichitanie.TabIndex = 1;
            vichitanie.Text = "-";
            vichitanie.UseVisualStyleBackColor = false;
            vichitanie.Click += vichitanie_Click;
            // 
            // del
            // 
            del.BackColor = Color.FromArgb(0, 192, 0);
            del.Location = new Point(174, 133);
            del.Name = "del";
            del.Size = new Size(75, 47);
            del.TabIndex = 2;
            del.Text = "/";
            del.UseVisualStyleBackColor = false;
            del.Click += del_Click;
            // 
            // textBoxNum1
            // 
            textBoxNum1.BackColor = Color.FromArgb(192, 192, 255);
            textBoxNum1.Location = new Point(12, 38);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(100, 23);
            textBoxNum1.TabIndex = 3;
            textBoxNum1.TextChanged += textBoxNum1_TextChanged;
            // 
            // textBoxNum2
            // 
            textBoxNum2.BackColor = Color.FromArgb(192, 255, 255);
            textBoxNum2.Location = new Point(322, 37);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(100, 23);
            textBoxNum2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(346, 112);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxNum1);
            Controls.Add(del);
            Controls.Add(vichitanie);
            Controls.Add(sum);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sum;
        private Button vichitanie;
        private Button del;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private Label label1;
    }
}