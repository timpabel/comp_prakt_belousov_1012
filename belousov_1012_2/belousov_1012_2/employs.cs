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
            string fio = textBox_fio.Text;
            
            if (textBox_salary.Text != "")
            {
                decimal salary = Convert.ToDecimal(textBox_salary.Text);
                DateTime datebegining = monthCalendar1.SelectionStart;
                Employer employer = new Employer(fio, salary, datebegining);
                listBox1.Items.Add(employer);
            }
            else
            {
                DateTime datebegining = monthCalendar1.SelectionStart;
                Employer employer = new Employer(fio, datebegining);
                listBox1.Items.Add(employer);
            }

           
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int index = listBox1.SelectedIndex;
        //    Employer employer = (Employer)listBox1.Items[index];
        //    employer.setId();
        //    listBox1.Items[index] = employer;
        //}
    }
}
