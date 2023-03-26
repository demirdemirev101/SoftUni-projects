using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name; 
            this.Age = age; 
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Person> persons=new List<Person>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] people=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                persons.Add(new Person(people[0], int.Parse(people[1])));
            }
         
            string condition=Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format=Console.ReadLine();

            Func<Person, int,bool> filter = CreateFilter(condition);
            persons=persons.Where(x=>filter(x,ageThreshold)).ToList();
            
            Action<Person> printer = CreatePrinter(format);

            persons.ForEach(printer);
        }
        private static Action<Person> CreatePrinter(string format)
        {
            if (format == "name")
            {
                return p => Console.WriteLine(p.Name);
            }
            else if (format == "age")
            {


                return p => Console.WriteLine(p.Age);
            }
            else if (format=="name age")
            {
                return p => Console.WriteLine($"{p.Name} - {p.Age}");

            }
            return null;
        }

        private static Func<Person,int, bool> CreateFilter(string condition)
        {
            if (condition=="older")
            {
                return (p, age) => p.Age >= age;
            }
            else if (condition=="younger")
            {

                return (p, age) => p.Age < age;
            }
            return null;
        }
    }
}
