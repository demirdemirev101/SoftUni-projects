using System.Collections.Generic;
using System;

namespace WildFarm.Models.Interfaces
{
    public interface IAnimal
    {
        public string Name { get;}
        public double Weight { get;}
        public int FoodEaten { get;}

        public abstract string ProducingSound();
        public abstract double WeightMultiPlayer { get; }
        public void EatFood(IFood food);
        public abstract IReadOnlyCollection<Type> FoodsCanEat { get; }
        
    }
}
