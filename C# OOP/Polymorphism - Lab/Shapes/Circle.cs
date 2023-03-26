using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return  Math.Round(Math.PI * Math.Pow(radius,2),2);
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * radius,2);
        }
        public override string Draw()
        {
            return $"Drawing {typeof(Circle).Name}";
        }
    }
}
