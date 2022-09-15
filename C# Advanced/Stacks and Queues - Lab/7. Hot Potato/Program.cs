using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int rounds = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(children);
            
            while (queue.Count > 1)
            {
                for (int round = 1; round < rounds; round++)
                {
                    
                    queue.Enqueue(queue.Dequeue());
                }
                    Console.WriteLine($"Removed {queue.Dequeue()}");
            
            }
                    Console.WriteLine("Last is "+queue.Dequeue());
        }
    }
}
