using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfCarsCanPass = int.Parse(Console.ReadLine());
            int counter = 0;
            Queue<string> queue = new Queue<string>();   
           
            string command=Console.ReadLine();
            while (command!="end")
            {

                if (command == "green")
                {
                    for (int i = 0; i < numOfCarsCanPass; i++)
                    {
                        if (queue.Count>0)
                        {
                            string car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            
                            counter++;
                        }
                        
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"{counter} cars passed the crossroads.");


        }
    }
}
