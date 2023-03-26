using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
		public Product(string name,double cost)
		{
			Name = name;
			Cost = cost;
		}
		private string name;

		public string Name
		{
			get { return name; }
			private set 
			{
				if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");
				name = value;
			}
		}
		private double cost;

		public double Cost
		{
			get { return cost; }
			private set 
			{
				if (value < 0) throw new ArgumentException("Money cannot be negative");
				cost = value;
			}
		}


	}
}
