using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int divise1 = 2;
            int divise2 = 3;
            int divise3 = 6;
            int divise4 = 7;
            int divise5 = 10;
            if (num % 2 == 0 && num % 10 == 0)
            {
                Console.WriteLine($"The number is divisible by {divise5}");
            }
            else if (num % 2 == 0 && num % 3 == 0 && num % 6 == 0)
            {
                Console.WriteLine($"The number is divisible by {divise3}");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine($"The number is divisible by {divise4}");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine($"The number is divisible by {divise1}");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"The number is divisible by {divise2}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}