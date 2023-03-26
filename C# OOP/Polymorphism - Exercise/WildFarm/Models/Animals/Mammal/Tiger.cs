using System;
using System.Collections.Generic;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammal
{
    public class Tiger : Feline
    {
        private const double TigerMultiPlayer = 1.0;
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiPlayer => TigerMultiPlayer;

        public override IReadOnlyCollection<Type> FoodsCanEat => 
            new HashSet<Type> { typeof(Meat) };

        public override string ProducingSound()
        {
            return "ROAR!!!";
        }
    }
}
