using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            char[] characters = Console.ReadLine().ToCharArray();
           foreach(var character in characters)
            {
                if (character==' ')
                {
                    continue;
                }
                if (occurrences.ContainsKey(character.ToString()))
                {
                    occurrences[character.ToString()]++;
                }
                else
                {
                    occurrences.Add(character.ToString(),1);
                }
            }
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
