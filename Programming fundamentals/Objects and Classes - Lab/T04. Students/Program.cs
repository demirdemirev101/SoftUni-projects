using System;
using System.Collections.Generic;

namespace T04._Students
{
    class Program
    {
         static void Main()
        {
            List<Student> students = new List<Student>();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] data=command.Split();

                string firstName=data[0];
                string lastName=data[1];
                int  age=int.Parse(data[2]);
                string homeTown=data[3];


                Student student=new Student();

                student.FirstName=firstName;
                student.LastName=lastName;
                student.Age=age;
                student.HomeTown=homeTown;

                students.Add(student);

                command=Console.ReadLine();
            }
            string cityName=Console.ReadLine();
           foreach (Student student in students)
            {
                if (cityName==student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
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
