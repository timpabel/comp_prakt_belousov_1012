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
    public partial class task31 : Form

    {
        private Circle circle;

        public task31()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(rad.Text);
            double s = Math.Round(Math.PI * r * r);
            label3.Text = $"{s}";
        }
        private void draw_circle_Click(object sender, EventArgs e)
        {

            //Point centre = new Point(Convert.ToInt32(textBox_x.Text), Convert.ToInt32(textBox_y.Text));
            circle = new Circle(Convert.ToInt32(rad.Text), new Point(Convert.ToInt32(textBox_x.Text), Convert.ToInt32(textBox_y.Text)));
            circle5.Items.Add(circle);


        }

        private void circle5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (circle5.SelectedItem != null)
            {
                Circle circle = (Circle)circle5.SelectedItem;
                circle.drawCircle(panel2, new Pen(Color.Aqua, 4));
            }

        }
        private void RedrawSelectedCircle()
        {
            if (circle5.SelectedItem != null)
            {
                panel2.Refresh(); // Очищаем панель перед отрисовкой
                Circle circle = (Circle)circle5.SelectedItem;
                circle.drawCircle(panel2, new Pen(Color.Aqua, 4));
            }
        }
        private void MoveSelectedCircle(int dx, int dy)
        {
            if (circle5.SelectedItem != null)
            {
                Circle selectedCircle = (Circle)circle5.SelectedItem;
                selectedCircle.moveCircle(dx, dy);

                // Обновляем отображение в ListBox
                int selectedIndex = circle5.SelectedIndex;
                circle5.Items[selectedIndex] = circle5.Items[selectedIndex];

                RedrawSelectedCircle();
            }
        }

        private void butup_Click(object sender, EventArgs e)
        {
            MoveSelectedCircle(0, -10);
        }

        private void butright_Click(object sender, EventArgs e)
        {
            MoveSelectedCircle(10, 0);
        }

        private void butleft_Click(object sender, EventArgs e)
        {
            MoveSelectedCircle(-10, 0);
        }

        private void butdown_Click(object sender, EventArgs e)
        {
            MoveSelectedCircle(0, 10);
        }
    }
}
