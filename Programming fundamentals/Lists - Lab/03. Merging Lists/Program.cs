using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mergedNumbers = new List<int>();
            if (numbers1.Count > numbers2.Count)
            {
                for (int i = 0; i < numbers1.Count; i++)
                {
                    mergedNumbers.Add(numbers1[i]);
                    if (numbers2.Count > i)
                    {
                        mergedNumbers.Add(numbers2[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers2.Count; i++)
                {
                    if (numbers1.Count > i)
                    {
                        mergedNumbers.Add(numbers1[i]);
                    }
                    mergedNumbers.Add(numbers2[i]);

                }
            }

            Console.WriteLine(string.Join(" ", mergedNumbers));
        }
    }
}