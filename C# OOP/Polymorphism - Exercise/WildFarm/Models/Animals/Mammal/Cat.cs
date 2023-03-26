using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammal
{
    public class Cat : Feline
    {
        private const double CatWeightMultiPlayer = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiPlayer => CatWeightMultiPlayer;

        public override IReadOnlyCollection<Type> FoodsCanEat => 
            new HashSet<Type> { typeof(Vegetable), typeof(Meat)};

        public override string ProducingSound()
        {
            return "Meow";
        }
    }
}
