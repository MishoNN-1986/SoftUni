using System;
using System.Collections.Generic;
using System.Text;

namespace _01._ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double widht, double height)
        {
            this.Length = length;
            this.Width = widht;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                ValidationSide(value, nameof(Length));
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                ValidationSide(value, nameof(Width));
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                ValidationSide(value, nameof(Height));
                this.height = value;
            }

        }

        private void ValidationSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative");
            }
        }

        public double CalculateSurfaceArea()
        {
            return (2 * this.length * this.width) + CalculateLateralSurfaceArea();
        }

        public double CalculateLateralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double CalculateVolume()
        {
            return this.length * this.height * this.width;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Surface Area - {this.CalculateSurfaceArea():F2}");
            stringBuilder.AppendLine($"Lateral Surface Area - {this.CalculateLateralSurfaceArea():F2}");
            stringBuilder.AppendLine($"Volume - {this.CalculateVolume():F2}");

            return stringBuilder.ToString().TrimEnd();
        }
    }

}
