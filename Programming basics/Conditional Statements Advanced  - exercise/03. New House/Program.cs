using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFllower = Console.ReadLine();
            int numFllowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            switch (typeFllower)
            {
                case "Roses":
                    price = 5;
                    price = price * numFllowers;
                    if (numFllowers > 80)
                    {
                        price = price - price * 0.1;
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    price = price * numFllowers;
                    if (numFllowers > 90)
                    {
                        price = price - price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    price = price * numFllowers;
                    if (numFllowers > 80)
                    {
                        price = price - price * 0.15;
                    }

                    break;
                case "Narcissus":
                    price = 3;
                    price = price * numFllowers;
                    if (numFllowers < 120)
                    {
                        price = price + price * 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;
                    price = price * numFllowers;
                    if (numFllowers < 80)
                    {
                        price = price + price * 0.2;
                    }
                    break;
            }
            double difference = budget - price;
            if (difference >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFllowers} {typeFllower} and {difference:f2} leva left.");

            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
            }
        }
    }
}
