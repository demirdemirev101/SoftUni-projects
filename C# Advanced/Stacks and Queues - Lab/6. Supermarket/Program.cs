using System;
using System.Collections.Generic;
using System.Drawing;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();  

            string customer=Console.ReadLine();
            while (customer!="End")
            {
                if (customer!="Paid")
                {
                 queue.Enqueue(customer);

                }
                else if(customer=="Paid")
                {
                    while (queue.Count!=0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }  
                }
                customer = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
