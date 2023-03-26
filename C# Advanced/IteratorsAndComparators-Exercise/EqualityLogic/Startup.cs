using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class Startup
    {
        static void Main(string[] args)
        {
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            int n= int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] personsInfo = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person
                {
                    Name = personsInfo[0],
                    Age = int.Parse(personsInfo[1])
                };
                hashSet.Add(person);
                sortedSet.Add(person);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
