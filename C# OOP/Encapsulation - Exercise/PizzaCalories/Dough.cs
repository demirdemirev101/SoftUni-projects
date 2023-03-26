using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
       private Dictionary<string, double> modifiers = new Dictionary<string, double>
       {
           {"white",1.5 },
           {"wholegrain",1.0 },
           {"crispy",0.9 },
           {"chewy",1.1 },
           {"homemade",1.0 }
       };

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType,string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;

        }
        public string FlourType
        {
            get { return flourType; }
            private set 
            {
                if (!modifiers.ContainsKey(value.ToLower())) throw new ArgumentException("Invalid type of dough.");
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set 
            {
                bakingTechnique = value; 
            }
        }

        public int Weight
        {
            get { return weight; }
            private set 
            {
                if (value < 1 || value > 200) throw new ArgumentException("Dough weight should be in the range [1..200].");
                weight = value;
            }
        }

        public double Calories =>Math.Round(
            (2 * (double)Weight) 
            * modifiers[FlourType.ToLower()]
            * modifiers[BakingTechnique.ToLower()],2);
    }
}
