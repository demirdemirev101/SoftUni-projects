
using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
             
         int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens=input
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
           
              Person person=new Person(tokens[0], int.Parse(tokens[1]));
                family.AddMember(person);

            }
            var filteredMembers = family.GetOldestMember();

            foreach (var person in filteredMembers)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            
        }
    }
}