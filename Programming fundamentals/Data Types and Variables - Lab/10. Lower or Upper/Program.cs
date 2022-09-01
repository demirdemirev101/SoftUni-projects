using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lowerOrUpperCase = char.Parse(Console.ReadLine());
            if (lowerOrUpperCase == Char.ToUpper(lowerOrUpperCase))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
