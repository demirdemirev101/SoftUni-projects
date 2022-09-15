using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack=new Stack<int>(numbers);
            string command=Console.ReadLine().ToLower();
            while (command!="end")
            {
                string[] options=command.Split(' ');

                string actions=options[0];
                switch (actions)
                {
                    case"add":
                        int firstNumber=int.Parse(options[1]);
                        int secondNumber=int.Parse(options[2]);

                        stack.Push(firstNumber);
                        stack.Push(secondNumber);
                        break;
                    case "remove":
                        int count = int.Parse(options[1]);
                        if (count <= stack.Count)
                        {


                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }

                command = Console.ReadLine().ToLower();
            }
            int sum = 0;
            while (stack.Count!=0)
            {
                sum+=stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
