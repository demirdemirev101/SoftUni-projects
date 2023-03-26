using System;
using System.Xml;

namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {
            Shape shape = null;
            string command;
            command = Console.ReadLine();
            
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length==1)
                {
                    double radius=double.Parse(tokens[0]);
                    shape = new Circle(radius);
                }
                else if (tokens.Length == 2)
                {
                    double height = double.Parse(tokens[0]);
                    double width = double.Parse(tokens[1]);
                    shape = new Rectangle(height, width);
                }
     
            Console.WriteLine(shape.Draw());
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.CalculateArea());
        }
    }
}
