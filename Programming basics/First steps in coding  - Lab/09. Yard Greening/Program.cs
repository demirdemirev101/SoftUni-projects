using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double greening = double.Parse(Console.ReadLine());
            Console.WriteLine($"The final price is: {greening * 7.61 - greening * 7.61 * 0.18} lv.");
            Console.WriteLine($"The discount is: {greening * 7.61 * 0.18} lv.");
        }
    }
}
