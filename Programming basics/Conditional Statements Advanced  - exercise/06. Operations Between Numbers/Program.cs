using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;
            switch (operation)
            {
                case "+":
                    Console.Write($"{n1} + {n2} = {n1 + n2}");
                    if ((n1 + n2) % 2 == 0)
                    {
                        Console.Write(" - even");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write(" - odd");
                        Console.WriteLine("");
                    }
                    break;
                case "-":
                    Console.Write($"{n1} - {n2} = {n1 - n2}");
                    if ((n1 - n2) % 2 == 0)
                    {
                        Console.Write(" - even");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write(" - odd");
                        Console.WriteLine("");
                    }
                    break;
                case "*":
                    Console.Write($"{n1} * {n2} = {n1 * n2}");
                    if ((n1 * n2) % 2 == 0)
                    {
                        Console.Write(" - even");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write(" - odd");
                        Console.WriteLine("");
                    }
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else if (n2 != 0)
                    {
                        result = 1.0 * n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else if (n2 != 0)
                    {
                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                    }
                    break;
            }

        }
    }
}
