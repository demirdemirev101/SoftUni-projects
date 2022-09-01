using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int[] numbers2 = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();

            int sum = 0;

            for (int index = 0; index < numbers1.Length; index++)
            {
                if (numbers1[index] == numbers2[index])
                {
                    sum += numbers1[index];

                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    break;

                }
                if (index == numbers1.Length - 1)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");

                }
            }

        }
    }
}
