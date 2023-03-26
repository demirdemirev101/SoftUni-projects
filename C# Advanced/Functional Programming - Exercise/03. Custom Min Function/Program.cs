using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<HashSet<int>, int> min = numbers =>
            {
                int min = int.MaxValue;
                foreach (int number in numbers)
                {
                    if (min > number)
                    {
                        min = number;
                    }
                }
                return min;
            };
            HashSet<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            Console.WriteLine(min(numbers));

        }
    }
}
