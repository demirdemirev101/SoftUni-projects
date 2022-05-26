using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double areaOfSquare = a * a;
                Console.WriteLine($"{areaOfSquare:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double areaOfrectangle = a * b;
                Console.WriteLine($"{areaOfrectangle:f3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double areaOfcircle = r * r * Math.PI;
                Console.WriteLine($"{areaOfcircle:f3}");

            }
            else
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double areaOfTriangle = a * ha / 2;
                Console.WriteLine($"{areaOfTriangle:f3}");

            }
        }
    }
}
