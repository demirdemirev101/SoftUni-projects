using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        private const double OwlMultiPlayer = 0.25;
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiPlayer => OwlMultiPlayer;

        public override IReadOnlyCollection<Type> FoodsCanEat => 
            new HashSet<Type> { typeof(Meat)};

        public override string ProducingSound()
        {
            return "Hoot Hoot";
        }
    }
}
