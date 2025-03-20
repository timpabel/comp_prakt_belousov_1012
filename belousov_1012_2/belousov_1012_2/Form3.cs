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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double dic = (b * b) - (4 * a * c);

            if (dic > 0)
            {
                double x1 = ((-b + Math.Sqrt(dic)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(dic)) / (2 * a));
                label1.Text = $"{x1}, {x2}";

            }
            else if (dic == 0)
            {
                double x = (-b) / (2 * a);
                label1.Text = $"{x}";
            }
            else
            {
                label1.Text = " no solutions";
            }
        }
    }
}
