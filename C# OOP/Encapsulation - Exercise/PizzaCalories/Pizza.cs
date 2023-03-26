using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
		private string name;
		private List<Topping> toppings;
		public Pizza(string name, string flourType, string bakingTechnique, int weight)
		{
	    	Name = name;
			toppings = new List<Topping>();
			this.Dough =new Dough(flourType, bakingTechnique, weight);
		}
		public void AddToping(Topping topping)
		{
			if (toppings.Count == 10)
			{
				throw new ArgumentException("Number of toppings should be in range [0..10].");
			}
			toppings.Add(topping);
        }
		public Dough Dough { get; private set; }

        public string Name
		{
			get { return name; }
			private set 
			{
				if (string.IsNullOrWhiteSpace(value)|| value.Length < 1 || value.Length > 15) throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
				name = value;
			}
		}
		public double TotalCalories => Math.Round(Dough.Calories+toppings.Sum(t=>t.Calories),2);
	}
}
