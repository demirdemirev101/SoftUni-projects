using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers=Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> numberTimes = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numberTimes.ContainsKey(numbers[i]))
                {
                    numberTimes.Add(numbers[i], 0);
                }
                numberTimes[numbers[i]]++;
            }

            foreach (var occurence in numberTimes)
            {
                Console.WriteLine($"{occurence.Key} - {occurence.Value} times");
            }
        }
    }
}
