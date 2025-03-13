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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            int sum = num1 + num2;
            label1.Text = $"{num1} + {num2} = {sum.ToString()}";
            textBoxNum1.Text = "";
            textBoxNum2.Text = "";
        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vichitanie_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            int razn = num1 - num2;
            label1.Text = $"{num1} - {num2} = {razn.ToString()}";
            textBoxNum1.Text = "";
            textBoxNum2.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBoxNum1.Text);
            double num2 = Convert.ToInt32(textBoxNum2.Text);
            double chastn = num1 / num2;
            label1.Text = $"{num1} / {num2} = {chastn.ToString()}";
            textBoxNum1.Text = "";
            textBoxNum2.Text = "";
        }
    }
}
