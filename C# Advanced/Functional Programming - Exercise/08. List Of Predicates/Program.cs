using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            for (int j = 0; j <= range; j++)
            {
                for (int i = 0; i <= dividers.Count; i++)
                {
                    if (j % dividers[i] == 0)
                    {
                        result.Add(j);
                        j -= 1;
                    }
                }

            }

            Console.WriteLine(String.Join(" ", result));

        }
    }
}
