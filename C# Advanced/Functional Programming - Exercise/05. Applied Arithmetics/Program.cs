using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, List<int>> add = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]++;
                }
                return numbers;
            };
            Func<List<int>, List<int>> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]--;
                }
                return numbers;
            };
            Func<List<int>, List<int>> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]*=2;
                }
                return numbers;
            };
            Action<List<int>> print = numbers =>
            {
                Console.WriteLine(string.Join(" ", numbers));
            };

            string command=Console.ReadLine();
            while (command!="end")
            {
                switch (command)
                {
                    case"add":
                        numbers = add(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "multiply":
                        numbers = multiply(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
