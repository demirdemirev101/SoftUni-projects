using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int enqueue = operations[0];
            int dequeue = operations[1];
            int elementToFind = operations[2];

            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int min = int.MaxValue;
           
            Queue<int> queue = new Queue<int>();

            int enqueueCounter = enqueue;
            for (int i = 0; i < enqueueCounter; i++)
            {
                queue.Enqueue(integers[i]);

            }

            int dequueCounter = dequeue;
            while (dequueCounter > 0)
            {
                queue.Dequeue();
                dequueCounter--;
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (queue.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else if (!queue.Contains(elementToFind))
            {
                foreach (var item in queue)
                {
                    if (min > item)
                    {
                        min = item;
                    }
                }
                Console.WriteLine(min);
            }

        }
    }
}
