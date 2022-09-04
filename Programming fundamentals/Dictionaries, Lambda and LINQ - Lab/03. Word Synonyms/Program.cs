using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonymList=new Dictionary<string,List<string>>();


            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonymList.ContainsKey(word))
                {
                    synonymList[word].Add(synonym);
                }
                else
                {
                   List<string> newSynList = new List<string>();
                    newSynList.Add(synonym);
                    synonymList.Add(word,newSynList);
                }
            }
            foreach (var item in synonymList)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
    }
    }
}
