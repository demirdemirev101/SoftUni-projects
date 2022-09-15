using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue=new Queue<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                 queue.Enqueue(array[i]);

                }
            }
            while (queue.Count!=0)
            {
                Console.Write(queue.Dequeue());
                if (queue.Count==0)
                {
                    continue;
                }
                Console.Write(", ");
            }   
        }
    }
}
