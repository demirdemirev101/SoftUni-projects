using System;
using System.Collections.Generic;


namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
              
            Stack<char>stack = new Stack<char>();

            bool isBalanced = true;
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (symbol == '{'||symbol=='['||symbol=='(')
                {
                    stack.Push(symbol);
                    continue;
                }
                if (stack.Count==0)
                {
                    isBalanced = false;
                    break;
                }
                if (symbol == '}' && stack.Peek() =='{')
                {
                    stack.Pop();
                }
                else if (symbol == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (symbol == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                }
                
            }
     
            if (!isBalanced)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
