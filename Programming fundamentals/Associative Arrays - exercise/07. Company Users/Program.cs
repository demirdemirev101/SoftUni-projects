using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string,List<string>>();
            string input=Console.ReadLine();
            while (input !="End")
            {
                string[] actions = input.Split(" -> ");
                List<string> listOfEmployees = new List<string>();
                if (!companies.ContainsKey(actions[0]))
                {
                    listOfEmployees.Add(actions[1]);
                    companies.Add(actions[0], listOfEmployees);
                }
                else
                {
                    if (!companies[actions[0]].Contains(actions[1]))
                    {
                        companies[actions[0]].Add(actions[1]);
                       
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var company in companies)
            { 
                Console.WriteLine($"{company.Key}");
                    Console.WriteLine($"-- {string.Join("\n-- ",company.Value)}");
                
            }

        }
    }
}
