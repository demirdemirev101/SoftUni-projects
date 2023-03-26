using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
          HashSet<string> set = new HashSet<string>();

            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }
            //Console.WriteLine("**********");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
