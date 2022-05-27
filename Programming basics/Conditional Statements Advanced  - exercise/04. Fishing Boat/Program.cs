using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (fishermen <= 6)
                    {
                        price = price - price * 0.1;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        price = price - price * 0.15;
                    }
                    else if (fishermen >= 12)
                    {
                        price = price - price * 0.25;
                    }
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 0.05;
                    }
                    break;
                case "Summer":
                    price = 4200;
                    if (fishermen <= 6)
                    {
                        price = price - price * 0.1;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        price = price - price * 0.15;
                    }
                    else if (fishermen >= 12)
                    {
                        price = price - price * 0.25;
                    }
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 0.05;
                    }
                    break;
                case "Autumn":
                    price = 4200;
                    if (fishermen <= 6)
                    {
                        price = price - price * 0.1;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        price = price - price * 0.15;
                    }
                    else if (fishermen >= 12)
                    {
                        price = price - price * 0.25;
                    }
                    break;
                case "Winter":
                    price = 2600;
                    if (fishermen <= 6)
                    {
                        price = price - price * 0.1;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        price = price - price * 0.15;
                    }
                    else if (fishermen >= 12)
                    {
                        price = price - price * 0.25;
                    }
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 0.05;
                    }
                    break;
            }
            double difference;
            difference = groupBudget - price;
            if (difference >= 0)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva.");
            }
        }
    }
}
