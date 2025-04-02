using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace belousov_1012_2
{
    internal class Circle
    {
        private int r; private Point centre_coord;
        public Circle(int r, Point centre_coord)
        {
            this.r = r;
            this.centre_coord = centre_coord;
        }
        public void drawCircle(Panel panel, Pen pen)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(panel.BackColor);
            int x = centre_coord.X;
            int y = centre_coord.Y;
            g.DrawEllipse(pen, x-r, y-r,r*2,r*2);
        }
        public override string ToString()
        {
            return $"Круг: Центр ({centre_coord.X}, {centre_coord.Y}), Радиус {r}";
        }
        public void moveCircle(int dx, int dy)
        {
            this.centre_coord.X += dx;
            this.centre_coord.Y += dy;

        }
    }
}
