using System;
using System.Numerics;

namespace T02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numbers=int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 2; i <= numbers; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
