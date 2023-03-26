using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammal
{
    public class Mouse : Mammal
    {
        private const double MouseMultiPlayer = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiPlayer => MouseMultiPlayer;

        public override IReadOnlyCollection<Type> FoodsCanEat => 
            new HashSet<Type> { typeof(Vegetable), typeof(Fruit)};

        public override string ProducingSound()
        {
            return "Squeak";
        }
        public override string ToString()
        {
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
