using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private Dictionary<string, double> modifiers = new Dictionary<string, double>
        {
            {"meat",1.2 },
            {"veggies",0.8 },
            {"cheese",1.1 },
            {"sauce",0.9 }
        };


        private string toppingType;
        private int weight;

        public Topping(string toppingType, int weight)
        {
            ToppingType = toppingType;
            Weight = weight;
        }
        public string ToppingType
        {
            get { return toppingType; }
            private set 
            {
                if (!modifiers.ContainsKey(value.ToLower())) throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                toppingType = value; 
            }
        }
        public int Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 50) throw new ArgumentException($"{ToppingType} weight should be in the range [1..50].");
                weight = value;
            }
        }
            public double Calories =>Math.Round(
            (2 * (double)Weight) 
            * modifiers[ToppingType.ToLower()],2);

    }
}
