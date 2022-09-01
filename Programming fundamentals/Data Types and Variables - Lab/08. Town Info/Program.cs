using System;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            ulong population = ulong.Parse(Console.ReadLine());
            short area = short.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");

        }
    }
}
