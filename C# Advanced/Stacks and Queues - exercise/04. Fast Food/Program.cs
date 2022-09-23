using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            
                int[] orderQuantity = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();
               
            Queue<int> queue = new Queue<int>(orderQuantity);
            Console.WriteLine(queue.Max());
            int order = 0;
            while (queue.Count!=0 && foodQuantity>=0)
            {
               order=queue.Peek();
                if (foodQuantity-order>=0)
                {
                    foodQuantity -= order;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }

            }
            if (queue.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.WriteLine(String.Join(" ",queue));
            }
        }
    }
}