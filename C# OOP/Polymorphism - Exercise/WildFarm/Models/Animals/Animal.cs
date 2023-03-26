namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models.Interfaces;

    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        public abstract double WeightMultiPlayer { get; }
        public abstract IReadOnlyCollection<Type> FoodsCanEat {get;}
        public void EatFood(IFood food)
        {
            if (!FoodsCanEat.Any(f=>f.Name==food.GetType().Name))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            Weight += food.Quantity * WeightMultiPlayer;
            FoodEaten+=food.Quantity;
        }
        public virtual string ProducingSound()
        {
            return null;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, ";
        }
    }
}
