using System;
using System.Collections.Generic;
using System.Text;

namespace _02.PointInRectangle
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public bool Contains(Point point)
        {
            if (this.TopLeft.X <= point.X && point.X <= this.BottomRight.X
                && this.BottomRight.Y >= point.Y && point.Y >= this.TopLeft.Y)
            {
                return true;
            }
            return false;
        }
    }
}
