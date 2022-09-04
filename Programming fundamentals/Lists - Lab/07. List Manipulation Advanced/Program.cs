using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool isListChanged = false;
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        isListChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeAt);
                        isListChanged = true;
                        break;
                    case "Insert":
                        int numberToInsertAt = int.Parse(tokens[1]);
                        int indexToInsertAt = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsertAt, numberToInsertAt);
                        isListChanged = true;
                        break;
                    case "Contains":
                        int containsOrNot = int.Parse(tokens[1]);
                        bool isTrueOrFalse = numbers.Contains(containsOrNot);
                        if (isTrueOrFalse)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    case "GetSum":
                        GetSum(numbers);
                        break;
                    case "Filter":
                        int numberToFilter = int.Parse(tokens[2]);
                        string filter = tokens[1];
                        Filter(filter, numberToFilter, numbers);
                        break;
                }
                command = Console.ReadLine();
            }
            if (isListChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static void Filter(string filter, int numberToFilter, List<int> numbers)
        {
            switch (filter)
            {
                case "<":
                    foreach (var number in numbers)
                    {
                        if (number < numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    break;
                case ">":
                    foreach (var number in numbers)
                    {
                        if (number > numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    break;
                case "<=":
                    foreach (var number in numbers)
                    {
                        if (number <= numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    break;
                case ">=":
                    foreach (var number in numbers)
                    {
                        if (number >= numberToFilter)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    break;

            }
            Console.WriteLine();
        }

        static void PrintEven(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void PrintOdd(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
        static void GetSum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
