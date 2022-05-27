using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double priceForTrip = 0.0;
            string destination = "";
            string typeOfRest = "";
            if (budget <= 100)
            {

                if (season == "summer")
                {
                    priceForTrip = budget - budget * 0.3;
                    destination = "Bulgaria";
                    typeOfRest = "Camp";
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{typeOfRest} - {budget - priceForTrip:f2}");
                }
                else if (season == "winter")
                {
                    priceForTrip = budget - budget * 0.7;
                    destination = "Bulgaria";
                    typeOfRest = "Hotel";
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{typeOfRest} - {budget - priceForTrip:f2}");
                }

            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    priceForTrip = budget - budget * 0.4;
                    destination = "Balkans";
                    typeOfRest = "Camp";
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{typeOfRest} - {budget - priceForTrip:f2}");
                }
                else if (season == "winter")
                {
                    priceForTrip = budget - budget * 0.8;
                    destination = "Balkans";
                    typeOfRest = "Hotel";
                    Console.WriteLine($"Somewhere in {destination}");
                    Console.WriteLine($"{typeOfRest} - {budget - priceForTrip:f2}");
                }
            }
            else if (budget > 1000)
            {
                priceForTrip = budget - budget * 0.9;
                destination = "Europe";
                typeOfRest = "Hotel";
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{typeOfRest} - {budget - priceForTrip:f2}");
            }

        }
    }
}
