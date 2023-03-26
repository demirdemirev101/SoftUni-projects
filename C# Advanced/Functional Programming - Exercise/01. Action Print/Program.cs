using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings=Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = strings => Console.WriteLine(string.Join(Environment.NewLine,strings));

            print(strings);
        }
    }
}
