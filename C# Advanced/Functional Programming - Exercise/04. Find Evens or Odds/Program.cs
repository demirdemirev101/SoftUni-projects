using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = new List<int>();
            List<int> result = new List<int>();   

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }
            bool isEven = Console.ReadLine() == "even";

            Predicate<int> even = numbers => numbers % 2 == 0;
            Predicate<int> odd = numbers => numbers % 2 != 0;
            
            if (isEven)
            {
                result=numbers.FindAll(even);
            }
            else
            {
                result=numbers.FindAll(odd);

            }

            Console.WriteLine(String.Join(" ",result));
        }
    }
}
