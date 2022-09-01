using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            bool odd = false;
            bool even = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    even = true;
                    evenSum += currentNumber;

                }
                else
                {
                    odd = true;
                    oddSum += currentNumber;

                }

            }
            int difference = evenSum - oddSum;
            Console.WriteLine(difference);


        }
    }
}
