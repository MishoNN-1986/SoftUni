using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get { return width; }
            private set { width = value; }
        }

        public double Height
        {
            get { return height; }
            private set { height = value; }
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return this.Height * 2 + this.Width * 2;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
