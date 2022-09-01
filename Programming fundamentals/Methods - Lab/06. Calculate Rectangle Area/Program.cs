using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSide = int.Parse(Console.ReadLine());
            int secondSide = int.Parse(Console.ReadLine());

            int area = AreaOFRectangle(firstSide, secondSide);
            Console.WriteLine(area);
        }
        static int AreaOFRectangle(int firstSide, int secondSide)
        {
            return firstSide * secondSide;
        }
    }
}
