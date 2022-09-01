using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();

            for (int number = 0; number < numbers.Length; number++)
            {
                bool currentInterationalNumIsBigger = true;
                for (int j = number + 1; j < numbers.Length; j++)
                {
                    if (numbers[number] <= numbers[j])
                    {
                        currentInterationalNumIsBigger = false;
                        break;
                    }

                }
                if (currentInterationalNumIsBigger)
                {
                    Console.Write(numbers[number] + " ");
                }
            }

        }

    }

}
