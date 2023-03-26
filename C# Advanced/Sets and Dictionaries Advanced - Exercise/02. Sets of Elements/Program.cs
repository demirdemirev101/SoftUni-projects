using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int>firstSet=new HashSet<int>();
            HashSet<int>secondSet=new HashSet<int>();
            //HashSet<int>thirdSet=new HashSet<int>();

          int[] counts = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < counts[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int j = 0; j < counts[1]; j++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            //foreach (var item in firstSet)
            //{
            //    foreach (var item2 in secondSet)
            //    {
            //        if (item==item2)
            //        {
            //            thirdSet.Add(item);
            //        }
            //    }
            //}
            //Console.WriteLine(String.Join(" ", thirdSet));
            firstSet.IntersectWith(secondSet);
            Console.WriteLine(String.Join(" ", firstSet));
        }
    }
}
