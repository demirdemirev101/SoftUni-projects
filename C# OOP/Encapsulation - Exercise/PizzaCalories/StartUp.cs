using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main()
        {
            string[] pizzaArgm=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string pizzaName=pizzaArgm[1];
            
            string[] doughArgm = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string flourType=doughArgm[1];
            string bakingTechnique=doughArgm[2];
            int weight = int.Parse(doughArgm[3]);
            Dough dough = new Dough(flourType, bakingTechnique, weight);

            Pizza pizza = new Pizza(pizzaName,flourType, bakingTechnique, weight);

            string input;
            try
            {
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] toppingArgm = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                    string toppingType = toppingArgm[1];
                    int toppingWeight = int.Parse(toppingArgm[2]);
                    Topping topping = new Topping(toppingType, toppingWeight);
                    pizza.AddToping(topping);
                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2}");
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine(ar.Message);
            }
            
        }
    }
}
