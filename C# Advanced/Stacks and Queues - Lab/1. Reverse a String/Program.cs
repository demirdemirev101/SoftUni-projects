using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToReverse = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var symboll in stringToReverse)
            {
            
                stack.Push(symboll);
            }
            while (stack.Count!=0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
