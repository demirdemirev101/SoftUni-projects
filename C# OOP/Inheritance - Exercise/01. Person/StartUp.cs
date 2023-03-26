﻿using System;

namespace Person
{
    public class StartUp
    {
        static void Main()
        {

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age > 15)
            {
                Person person = new Person(name, age);
                Console.WriteLine(person.ToString());
            }
            else
            {
                Child child = new Child(name, age);
                Console.WriteLine(child.ToString());
            }

        }
    }
}
