namespace WildFarm.Factories
{
    using System;
    using Interfaces;
    using Models.Foods;
    using Models.Interfaces;
    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string type, int quantity)
        {
            Food food = null;
            if (type=="Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (type=="Fruit")
            {
                food = new Fruit(quantity);
            }
            else if (type=="Seeds")
            {
                food = new Seeds(quantity);
            }
            else if (type=="Meat")
            {
                food = new Meat(quantity);
            }
            else
            {
                throw new ArgumentException("Invalid food type!");
            }
            return food;
        }
    }
}
