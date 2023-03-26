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
            this.height = height;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return Math.Round(height * width,2);
        }

        public override double CalculatePerimeter()
        {
           return Math.Round(2*(height+width),2);
        }
        public override string Draw()
        {
            return $"Drawing {typeof(Rectangle).Name}";
        }
    }
}
