using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int min = int.MaxValue;
            int max = int.MinValue;
            int elements = int.Parse(Console.ReadLine());
            for (int i = 0; i < elements; i++)
            {
                int[] query=Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (query[0]==1)
                {
                    stack.Push(query[1]);
                }
                else if (query[0]==2 && stack.Count!=0)
                {
                      stack.Pop();
                }
                else if(query[0]==3 && stack.Count!=0)
                {
                    foreach (int item in stack)
                    {
                        if (max<item)
                        {
                            max = item;
                        }
                    }
                    Console.WriteLine(max);
                }
                else if (query[0]==4 && stack.Count!=0)
                {
                    foreach (int item in stack)
                    {
                        if (min > item)
                        {
                            min = item;
                        }
                    }
                    Console.WriteLine(min);
                }

            }
            for (int i = 0; i < stack.Count; i++)
            {
                int variable = stack.Pop();
                if (stack.Count != 0)
                {
                 Console.Write( variable+", ");

                     i = -1;
                }
                else
                {
                   Console.Write(variable);
                }
            }
        }
    }
}
