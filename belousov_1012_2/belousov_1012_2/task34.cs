using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace belousov_1012_2
{
    public partial class task34 : Form
    {
        private Square square;
        private Color currentColor = Color.Blue;
        public task34()
        {
            InitializeComponent();
            colorDialog1.Color = currentColor;
        }

        private void butt_add_square_Click(object sender, EventArgs e)
        {
            //Square square = new Square(new Point(Convert.ToInt32(textBox_X.Text), Convert.ToInt32(textBox_Y.Text)),Convert.ToInt32(textBox_side),currentColor);
            if (int.TryParse(textBox_side.Text, out int length) && length > 0)
            {

                Square square = new Square(new Point(Convert.ToInt32(textBox_X.Text), Convert.ToInt32(textBox_Y.Text)), length, currentColor);
                Squares.Items.Add(square);
            }
        }

        private void Squares_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Squares.SelectedItem != null)
            {
                Square square = (Square)Squares.SelectedItem;
                square.DrawSquare(panel1, new Pen(Color.Aqua, 4));
            }
        }
        private void RedrawSelectedCircle()
        {
            if (Squares.SelectedItem != null)
            {
                panel1.Refresh(); // Очищаем панель перед отрисовкой
                Square square = (Square)Squares.SelectedItem;
                square.DrawSquare(panel1, new Pen(Color.Aqua, 4));
            }
        }


        private void butt_ChangeSize_Click(object sender, EventArgs e)
        {

            if (Squares.SelectedItem != null)
            {
                Square selectedsquare = (Square)Squares.SelectedItem;
                selectedsquare.SizeCange(10);
                int selectedIndex = Squares.SelectedIndex;
                Squares.Items[selectedIndex] = Squares.Items[selectedIndex];

                RedrawSelectedCircle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Squares.SelectedItem != null)
            {
                Square selectedsquare = (Square)Squares.SelectedItem;
                selectedsquare.SizeCange(-10);
                int selectedIndex = Squares.SelectedIndex;
                Squares.Items[selectedIndex] = Squares.Items[selectedIndex];

                RedrawSelectedCircle();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Squares.SelectedItem != null)
            {
                Point newTopLeft = (Point)e.Location;
                Square selectedsquare = (Square)Squares.SelectedItem;
                selectedsquare.MoveSquare(newTopLeft, panel1);
                int selectedIndex = Squares.SelectedIndex;
                Squares.Items[selectedIndex] = Squares.Items[selectedIndex];

                RedrawSelectedCircle();
            }

        }

        private void buut_color_Click(object sender, EventArgs e)
        {
         

        }
    }
}
