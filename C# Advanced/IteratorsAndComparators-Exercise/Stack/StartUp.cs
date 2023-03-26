using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();

            string command = Console.ReadLine();
                
            while (command!="END")
            {
                string[] arguments = command
                    .Split(new char[] {' ', ','},
                    StringSplitOptions.RemoveEmptyEntries);
                string action=arguments[0];
                switch (action)
                {
                    case"Push":
                        string[] items = arguments.Skip(1).ToArray();
                        foreach (var item in items)
                        {
                            stack.Push(item);
                        }
                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (InvalidOperationException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        break;
                }
                command = Console.ReadLine();   
            }

            if (stack.Count != 0)
            {


                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
