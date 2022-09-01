using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());
            double usd = britishPounds * 1.31;

            Console.WriteLine($"{usd:f3}");
        }
    }
}
