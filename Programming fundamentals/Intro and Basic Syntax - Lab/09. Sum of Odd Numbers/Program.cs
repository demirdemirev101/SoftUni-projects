using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentOddNumber = 1 + (i * 2);

                sum += currentOddNumber;
                Console.WriteLine(currentOddNumber);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}