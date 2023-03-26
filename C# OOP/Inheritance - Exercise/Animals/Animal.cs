using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {

		public Animal(string name, int age, string gender)
		{
			Name = name;
			Age = age;
		    Gender = gender;
		}

		private string name;

		public string Name
		{
			get { return name; }
			private set 
			{
				if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid input!");
					
				name = value;
			}
		}
		private int age;

		public int Age
		{
			get { return age; }
			private set 
			{
				if (value < 0) throw new ArgumentException("Invalid input!");
				age = value;
			}
		}
		private string gender;

		public string Gender
		{
			get { return gender; }
			private set
			{
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid input!");
				
				gender = value;
            }
		}
		public virtual string ProduceSound() => "Noise";

		public override string ToString()
		{
			StringBuilder stringBuilder=new StringBuilder();
			stringBuilder.AppendLine(GetType().Name)
				.AppendLine($"{Name} {Age} {Gender}")
				.AppendLine(ProduceSound());

			return stringBuilder.ToString().Trim();
		}

	}
}
