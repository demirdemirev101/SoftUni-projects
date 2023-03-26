using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        public Box(double lenth, double width, double height)
        {
            Length = lenth;
            Width = width;
            Height = height;
        }
        private double length;
        public double Length 
        {
            get => length;
            private set
            {
                if (value <= 0) throw new ArgumentException($"Length cannot be zero or negative.");

                length = value;
            }
        }
        private double width;

        public double Width
        {
            get => width;
            set 
            { 
                if(value <= 0) throw new ArgumentException($"Width cannot be zero or negative.");
                width = value;
            }
        }
        private double height;

        public double Height
        {
            get => height;
            set 
            {
                if(value <= 0) throw new ArgumentException($"Height cannot be zero or negative.");
                height = value;
            }
        }

        public double SurfaceArea()
        {
            //2lw+2lh+2hw
            double area = 2 * Length * Width + 2 * Length * Height + 2 * Height * Width;
            return area;
        }
        public double LateralSurfaceArea()
        {
            //2h(l + w)
            double lateralArea = 2 * Height * (Length + Width);
            return lateralArea;
        }
        public double Volume()
        {
            double volume = Length * Width * Height;
            return volume;
        }
    }
}
