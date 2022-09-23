using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ")
                .ToArray();
            
            Queue<string> queue = new Queue<string>(songs);

            string command=Console.ReadLine();
            while (queue.Count!=0)
            {
                string[] tokens = command.Split();
                string action=tokens[0];
                switch (action)
                {

                    case"Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ",tokens);
                        song=song.Remove(0,action.Length+1);
                        if (!queue.Contains(song))
                        {
                            queue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",queue));
                        break;
                }

                command=Console.ReadLine();
            }
            if (queue.Count==0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
