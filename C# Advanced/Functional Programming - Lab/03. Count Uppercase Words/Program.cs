using System;
using System.Linq;


namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpper = x => char.IsUpper(x[0]);
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join("\n", input.Where(isUpper)));
        }
    }
}
