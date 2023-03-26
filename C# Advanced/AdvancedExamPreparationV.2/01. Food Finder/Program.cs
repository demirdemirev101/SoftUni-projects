using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] input1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            Queue<char> vowels = new Queue<char>(input1);

            char[] input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            Stack<char> consanants = new Stack<char>(input2);

           
                Dictionary<string,HashSet<char>> wordsToCreate = new Dictionary<string, HashSet<char>>
                {
                    ["pear"]=new HashSet<char>(),
                    ["flour"] =new HashSet<char>(),
                    ["pork"] =new HashSet<char>(),
                    ["olive"] =new HashSet<char>()

                };
            

            while (consanants.Count!=0)
            {
                char currentVowel = vowels.Dequeue();
                char currentConsanant=consanants.Pop();

                foreach (var word in wordsToCreate)
                {
                    if (word.Key.Contains(currentVowel))
                    {
                        word.Value.Add(currentVowel);
                    }
                    if (word.Key.Contains(currentConsanant))
                    {
                        word.Value.Add(currentConsanant);
                    }
                }

                vowels.Enqueue(currentVowel); 
            }

             var foundedWords = wordsToCreate.Where(w => w.Key.Length == w.Value.Count)
                .Select(w=>w.Key)
                .ToList();
            Console.WriteLine($"Words found: {foundedWords.Count}");
            Console.WriteLine(String.Join(Environment.NewLine,foundedWords));
        }
    }
}
