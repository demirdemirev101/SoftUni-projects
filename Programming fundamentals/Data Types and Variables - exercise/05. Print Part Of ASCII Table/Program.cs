using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingAscii = int.Parse(Console.ReadLine());
            int endingAscii = int.Parse(Console.ReadLine());

            for (int i = startingAscii; i <= endingAscii; i++)
            {
                char toAscii = (char)i;
                Console.Write($"{toAscii} ");
            }
        }
    }
}
