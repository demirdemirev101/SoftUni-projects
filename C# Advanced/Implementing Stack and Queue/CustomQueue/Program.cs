using System;
using System.Collections.Generic;

namespace CustomQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomQueue customQueue = new CustomQueue();
            customQueue.Enquque(4);
            customQueue.Enquque(76);
            customQueue.Enquque(3);
            customQueue.Enquque(8);
            customQueue.Enquque(34);

            customQueue.Dequeue();
            Console.WriteLine(customQueue.Peek());
            customQueue.ForEach(n => Console.WriteLine(n));
            customQueue.Clear();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Clear();
        }
    }
}
