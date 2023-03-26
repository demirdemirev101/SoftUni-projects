using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        private string firstName;
        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                if (value.Length < 3) throw new ArgumentException("First name cannot contain fewer than 3 symbols!");

                this.firstName = value;
            }
        }
        private string lastName;
        public string LastName 
        { 
            get { return this.lastName; } 
            private set
            {
                if (value.Length < 3) throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");

                this.lastName = value;
            } 
        }
        private int age;
        public int Age 
        { 
            get { return this.age; } 
            private set 
            {
                if (value <= 0) throw new ArgumentException("Age cannot be zero or a negative integer!");
                
                this.age = value;
            } 
        }
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 650) throw new ArgumentException("Salary cannot be less than 650 leva!");
                this.salary = value;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (Age<30)
            {
                Salary += Salary * percentage/200;
            }
            else
            {
                Salary+=Salary * percentage/100;
            }
        }
    }
}
