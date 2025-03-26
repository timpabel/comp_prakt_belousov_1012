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
        public void drawCircle(Graphics g, Pen pen)
        {
            int x = centre_coord.X;
            int y = centre_coord.Y;
            g.DrawEllipse(pen, x, y,r*2,r*2);
        }

    }
}
