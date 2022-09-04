using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict=new Dictionary<string, string>();
            string command=Console.ReadLine();
            string [] arguments=command.Split(' ');
            int studentsRegistered = 0;
            while (command!="end")
            {
                if (!dict.ContainsKey(arguments[0]))
                {
                    dict.Add(arguments[0], arguments[2]);
                    studentsRegistered=1;
                }
                else
                {
                    dict[arguments[0]]+=arguments[2];
                    studentsRegistered++;
                }

                command=Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {studentsRegistered}");
                Console.WriteLine($"-- {item.Value}");
            }
        }
    }
}
