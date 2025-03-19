using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "мышка";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
