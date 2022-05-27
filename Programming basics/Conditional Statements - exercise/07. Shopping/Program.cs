using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ramStorage = int.Parse(Console.ReadLine());

            double videoCardsPrice = videoCards * 250;

            double priceOfProcessors = processors * (videoCardsPrice * 0.35);

            double priceOfRamStorage = ramStorage * (videoCardsPrice * 0.1);

            double allCost = videoCardsPrice + priceOfProcessors + priceOfRamStorage;
            if (videoCards > processors)
            {
                allCost = allCost - allCost * 0.15;
            }

            if (allCost <= budget)
            {
                budget = budget - allCost;
                Console.WriteLine($"You have {budget:f2} leva left!");
            }
            else
            {
                budget = budget - allCost;
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget):f2} leva more!");
            }
        }
    }
}
