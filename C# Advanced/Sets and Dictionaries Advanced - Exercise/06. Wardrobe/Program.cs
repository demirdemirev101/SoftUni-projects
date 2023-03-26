using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,int>> clothesAndColours = new Dictionary<string,Dictionary<string,int>>();
            int count=int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens=Console.ReadLine().Split(new string[] {" -> ",","},StringSplitOptions.RemoveEmptyEntries).ToArray();

                string colour=tokens[0];
                if (!clothesAndColours.ContainsKey(colour))
                {
                    clothesAndColours.Add(colour,new Dictionary<string, int>());
                }
                for (int j = 1; j < tokens.Length; j++)
                {
                    if (!clothesAndColours[colour].ContainsKey(tokens[j]))
                    {
                        clothesAndColours[colour].Add(tokens[j], 0);
                    }
                clothesAndColours[colour][tokens[j]]++;
                }
            }

            string[] clothingAndDress= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in clothesAndColours)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in item.Value)
                {
                    if (item.Key == clothingAndDress[0]
                       && item2.Key == clothingAndDress[1])
                    {
                        Console.WriteLine($"* {item2.Key} - {item2.Value} (found!)");
                    }
                    else
                    {
                    Console.WriteLine($"* {item2.Key} - {item2.Value}");

                    }
                }
            }
        }
    }
}
