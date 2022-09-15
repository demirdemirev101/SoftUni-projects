using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
           
       
            Stack<string> stack = new Stack<string>(expression.Reverse());

            string operation = "";
            int number = 0;
            int sum = 0;
            while (stack.Count != 0)
            {
                if (stack.Peek()=="+"||stack.Peek()=="-")
                {
                 operation = stack.Pop();
                    if (operation == "+")
                    {
                        number = int.Parse(stack.Pop().ToString());
                        sum +=number;
                    }
                    else if (operation == "-")
                    {
                        number = int.Parse(stack.Pop().ToString());
                        sum -=number;
                    }
                }
                else
                {
                  sum=int.Parse(stack.Pop());

                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
