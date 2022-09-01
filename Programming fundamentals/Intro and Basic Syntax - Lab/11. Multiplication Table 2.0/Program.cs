using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier > 10)
            {
                Console.WriteLine($"{theInteger} X {multiplier} = {theInteger * multiplier}");

            }
            while (multiplier <= 10)
            {
                Console.WriteLine($"{theInteger} X {multiplier} = {theInteger * multiplier}");
                multiplier++;


            }

        }
    }
}