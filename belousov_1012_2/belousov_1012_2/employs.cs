using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belousov_1012_2
{
    public partial class employs : Form
    {
        private Employer employer;
        public employs()
        {
            InitializeComponent();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (checkBox_isManager.Checked)
            {
                if (textBox_salary.Text != "")
                {


                    DateTime datebegining = monthCalendar1.SelectionStart;
                    Manager manager = new Manager(textBox_fio.Text, Convert.ToDecimal(textBox_salary.Text), datebegining, Convert.ToDecimal(textBox_bonus.Text));
                    listBox1.Items.Add(manager);
                }
                else
                {
                    DateTime datebegining = monthCalendar1.SelectionStart;
                    Manager manager = new Manager(textBox_fio.Text, datebegining, Convert.ToDecimal(textBox_bonus.Text));
                    listBox1.Items.Add(manager);
                }
            }
            else
            {
                if (textBox_salary.Text != "")
                {


                    DateTime datebegining = monthCalendar1.SelectionStart;
                    Employer employer = new Employer(textBox_fio.Text, Convert.ToDecimal(textBox_salary.Text), datebegining);
                    listBox1.Items.Add(employer);
                }
                else
                {
                    DateTime datebegining = monthCalendar1.SelectionStart;
                    Employer employer = new Employer(textBox_fio.Text, datebegining);
                    listBox1.Items.Add(employer);
                }

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal newsalary = Convert.ToDecimal(textBox_newsalary.Text);
            int index = listBox1.SelectedIndex;
            Employer employer = (Employer)listBox1.Items[index];

            employer.ChangeSalary(newsalary);
            listBox1.Items[index] = employer;
        }

        private void button_stage_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Employer employer = (Employer)listBox1.Items[index];
            int stage = employer.CalculateStage();
            label4.Text = stage.ToString();
        }

        private void checkBox_isManager_CheckedChanged(object sender, EventArgs e)
        {
            textBox_bonus.Enabled = !textBox_bonus.Enabled;

        }
    }
}