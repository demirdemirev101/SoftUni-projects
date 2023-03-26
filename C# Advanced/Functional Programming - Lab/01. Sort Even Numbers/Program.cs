﻿using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] output=input.Where(x=>x%2==0).OrderBy(x=>x).ToArray();
            Console.WriteLine(string.Join(", ",output));

        }
    }
}
