namespace belousov_1012_2
{
    partial class employs
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
            listBox1 = new ListBox();
            button_create = new Button();
            textBox_fio = new TextBox();
            textBox_salary = new TextBox();
            label1 = new Label();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            button_change_salary = new Button();
            button_stage = new Button();
            label4 = new Label();
            textBox_newsalary = new TextBox();
            checkBox_isManager = new CheckBox();
            textBox_bonus = new TextBox();
            label_bonus = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(378, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 154);
            listBox1.TabIndex = 0;
            // 
            // button_create
            // 
            button_create.Location = new Point(1, 136);
            button_create.Name = "button_create";
            button_create.Size = new Size(137, 23);
            button_create.TabIndex = 1;
            button_create.Text = "добавить сотрудника";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // textBox_fio
            // 
            textBox_fio.Location = new Point(12, 27);
            textBox_fio.Name = "textBox_fio";
            textBox_fio.Size = new Size(100, 23);
            textBox_fio.TabIndex = 2;
            // 
            // textBox_salary
            // 
            textBox_salary.Location = new Point(12, 82);
            textBox_salary.Name = "textBox_salary";
            textBox_salary.Size = new Size(100, 23);
            textBox_salary.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "введите фио";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 64);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Зарплата";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(161, 33);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 9);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 7;
            label3.Text = "Дата трудоустройства";
            // 
            // button_change_salary
            // 
            button_change_salary.Location = new Point(409, 288);
            button_change_salary.Name = "button_change_salary";
            button_change_salary.Size = new Size(132, 23);
            button_change_salary.TabIndex = 8;
            button_change_salary.Text = "изменить зарплату";
            button_change_salary.UseVisualStyleBackColor = true;
            button_change_salary.Click += button1_Click;
            // 
            // button_stage
            // 
            button_stage.Location = new Point(1, 266);
            button_stage.Name = "button_stage";
            button_stage.Size = new Size(114, 23);
            button_stage.TabIndex = 9;
            button_stage.Text = "посчитать стаж";
            button_stage.UseVisualStyleBackColor = true;
            button_stage.Click += button_stage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 269);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // textBox_newsalary
            // 
            textBox_newsalary.Location = new Point(303, 289);
            textBox_newsalary.Name = "textBox_newsalary";
            textBox_newsalary.Size = new Size(100, 23);
            textBox_newsalary.TabIndex = 11;
            // 
            // checkBox_isManager
            // 
            checkBox_isManager.AutoSize = true;
            checkBox_isManager.Location = new Point(15, 176);
            checkBox_isManager.Name = "checkBox_isManager";
            checkBox_isManager.Size = new Size(73, 19);
            checkBox_isManager.TabIndex = 12;
            checkBox_isManager.Text = "Manager";
            checkBox_isManager.UseVisualStyleBackColor = true;
            checkBox_isManager.CheckedChanged += checkBox_isManager_CheckedChanged;
            // 
            // textBox_bonus
            // 
            textBox_bonus.Enabled = false;
            textBox_bonus.Location = new Point(15, 219);
            textBox_bonus.Name = "textBox_bonus";
            textBox_bonus.Size = new Size(100, 23);
            textBox_bonus.TabIndex = 13;
            // 
            // label_bonus
            // 
            label_bonus.AutoSize = true;
            label_bonus.Location = new Point(15, 201);
            label_bonus.Name = "label_bonus";
            label_bonus.Size = new Size(40, 15);
            label_bonus.TabIndex = 14;
            label_bonus.Text = "bonus";
            // 
            // employs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_bonus);
            Controls.Add(textBox_bonus);
            Controls.Add(checkBox_isManager);
            Controls.Add(textBox_newsalary);
            Controls.Add(label4);
            Controls.Add(button_stage);
            Controls.Add(button_change_salary);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_salary);
            Controls.Add(textBox_fio);
            Controls.Add(button_create);
            Controls.Add(listBox1);
            Name = "employs";
            Text = "employs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button_create;
        private TextBox textBox_fio;
        private TextBox textBox_salary;
        private Label label1;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private Button button_change_salary;
        private Button button_stage;
        private Label label4;
        private TextBox textBox_newsalary;
        private CheckBox checkBox_isManager;
        private TextBox textBox_bonus;
        private Label label_bonus;
    }
}