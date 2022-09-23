using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] operations=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int push = operations[0];
            int pop = operations[1];
            int elementToFind = operations[2];

            int[] integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();
           
            int pushCounter = push;
                for (int i = 0; i < pushCounter; i++)
                {
                    stack.Push(integers[i]);
                    
                }

            int popCounter = pop;
            while (popCounter > 0)
            {
                stack.Pop();
                popCounter--;
            }
            
            if (stack.Count==0)
            {
                Console.WriteLine(0);
                return;
            }
            
            if (stack.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            
            int min = int.MaxValue;
             if(!stack.Contains(elementToFind))
             {
                foreach(var item in stack)
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
