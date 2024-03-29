﻿using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> chars = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (!chars.ContainsKey(ch))
                {
                    chars.Add(ch,0);
                }
                chars[ch]++;
            }
            foreach (var character in chars)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }

        }
    }
}
