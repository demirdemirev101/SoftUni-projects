using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string[] names=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            Func<string[], string[]> result = names =>
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Length>n)
                    {
                       names[i] = names[i].Replace(names[i],string.Empty);
          
                    }
                }
                return names;
            };
            names=result(names);
            names = names.Where(o => o != string.Empty).ToArray();
            Console.WriteLine(string.Join("\n",names).TrimEnd());

        }
    }
}
