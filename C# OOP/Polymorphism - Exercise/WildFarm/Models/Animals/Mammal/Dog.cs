namespace WildFarm.Models.Animals.Mammal
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Models.Foods;

    public class Dog : Mammal
    {
        private const double DogMultiPlayer = 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiPlayer => DogMultiPlayer;

        public override IReadOnlyCollection<Type> FoodsCanEat =>
            new HashSet<Type> { typeof(Meat) };

        public override string ProducingSound()
        {
            return "Woof!";
        }
        public override string ToString()
        {
            return base.ToString()+$"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
