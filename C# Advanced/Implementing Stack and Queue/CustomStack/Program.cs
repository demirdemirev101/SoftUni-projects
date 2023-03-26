using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class Program
    {
        static void Main()
        {

           CustomStack stack = new CustomStack();
            stack.Push(21);
            stack.Push(3);

            stack.ForEach(n => Console.WriteLine(n));
           
        }
    }
}
