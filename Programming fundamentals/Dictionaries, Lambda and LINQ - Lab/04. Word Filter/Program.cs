using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> words=Console.ReadLine()
                .Split()
                .Where(w=>w.Length%2==0)
                .ToList();
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
