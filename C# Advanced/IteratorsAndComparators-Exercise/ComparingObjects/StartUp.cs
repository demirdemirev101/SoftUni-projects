using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
          List<Person> people= new List<Person>();
            string command=Console.ReadLine();
            while (command!="END")
            {
                string[] tokens = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));

                command=Console.ReadLine();
            }
            int personToCompareIndex=int.Parse(Console.ReadLine())-1;
            Person personToCompare = people[personToCompareIndex];
            int equalCount = 0;
            int diffCount = 0;

            foreach (var person in people)
            {
                if(person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }
            if (equalCount==1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
             Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
            }
        }
    }
}
