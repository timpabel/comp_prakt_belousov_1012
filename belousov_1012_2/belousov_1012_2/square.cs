using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace belousov_1012_2
{
    public class Square
    {
        private Point TopLeft;
        private int SideLength;
        private Color Color;
    
        public Square(Point topLeft, int sideLength, Color color)
        {
            this.TopLeft = topLeft;
            SideLength = sideLength;
            Color = color;
        }
        public void DrawSquare(Panel panel, Pen pen)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(panel.BackColor);
            Pen pen1 = new Pen(Color, 3);
            int x = TopLeft.X;
            int y = TopLeft.Y;
            g.DrawRectangle(pen1, x, y, SideLength, SideLength);
        }
        public void MoveSquare(Point newTopLeft, Panel panel)
        {
            // Очищаем старую позицию (перерисовываем фон)
            using (Graphics g = panel.CreateGraphics())
            {
                g.Clear(panel.BackColor);
            }
            Pen pen1 = new Pen(Color, 3);
            TopLeft = newTopLeft;

            // Рисуем круг на новом месте
            DrawSquare(panel,pen1);
        }

        public void SizeCange(int delta)
        {
            SideLength += delta; 
        }
        public override string ToString()
        {
            return $"Квадрат [X:{TopLeft.X}, Y:{TopLeft.Y}, Сторона:{SideLength}, Цвет:{Color.Name}]";
        }
    }
    
}