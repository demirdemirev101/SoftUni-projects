using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        private const double HenMultiPlayer = 0.35;
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiPlayer => HenMultiPlayer;

        public override IReadOnlyCollection<Type> FoodsCanEat => 
            new HashSet<Type> { typeof(Meat), typeof(Vegetable),typeof(Fruit), typeof(Seeds)};

        public override string ProducingSound()
        {
            return "Cluck";
        }
    }
}
