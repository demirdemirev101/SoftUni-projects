﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

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
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeAt);
                        break;
                    case "Insert":
                        int numberToInsertAt = int.Parse(tokens[1]);
                        int indexToInsertAt = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsertAt, numberToInsertAt);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

    }
}
