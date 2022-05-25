using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {


            double budget = double.Parse(Console.ReadLine());
            int numStatisticks = int.Parse(Console.ReadLine());
            double priceForStatisticks = double.Parse(Console.ReadLine());


            double price = priceForStatisticks * numStatisticks;
            double decor = budget * 0.1;

            if (numStatisticks >= 150)
            {
                price -= price * 0.1;
            }

            double sumForFilm = decor + price;


            if (budget >= sumForFilm)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - sumForFilm:f2} leva left.");
            }
            else
            {

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget - sumForFilm):f2} leva more.");
            }
        }
    }
}
