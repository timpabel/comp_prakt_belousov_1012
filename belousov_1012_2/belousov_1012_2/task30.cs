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
    public partial class task30 : Form
    {
        private Circle circle;
        private Point dragStart;
        

        public task30()
        {
            InitializeComponent();
            circle1 = new Circle(new Point(200, 200), 50);
            
        }

        private void plashdquadr_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(storona.Text);
            double s = a * a;
            label1.Text = $"{s}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(rad.Text);
            double s = Math.Round(Math.PI * r * r);
            label3.Text = $"{s}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(stra.Text);
            double b = Convert.ToDouble(strb.Text);
            double c = Convert.ToDouble(strc.Text);
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            label2.Text = $"{s}";
        }

        private void draw_circle_Click(object sender, EventArgs e)
        {
            Point centre;
            Graphics g = panel3.CreateGraphics();
            
            
            //Point centre = new Point(Convert.ToInt32(textBox_x.Text), Convert.ToInt32(textBox_y.Text));
            circle = new Circle(Convert.ToInt32(rad.Text), new Point(Convert.ToInt32(textBox_x.Text), Convert.ToInt32(textBox_y.Text)));
            

        }
    }
}
