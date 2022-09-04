using System;
using System.Collections.Generic;
using System.Linq;
namespace Y05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
           string command = Console.ReadLine();
            while (command != "end")
            {
                string[] data = command.Split();

                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];


                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                if (student == null)
                {

                    student.FirstName = firstName;
                     student.LastName = lastName;
                     student.Age = age;
                    student.HomeTown = homeTown;

                    students.Add(new Student());
               
                     }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
               

                command = Console.ReadLine();
            }
            string cityName = Console.ReadLine();
           
            
            
        }
    }
    class Student
    {
        

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
