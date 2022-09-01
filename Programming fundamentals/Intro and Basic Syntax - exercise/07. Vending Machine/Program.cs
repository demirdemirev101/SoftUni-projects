using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalAccumulatedMoney = 0;
            while (command != "Start")
            {
                double inputMoney = double.Parse(command);
                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
                {
                    totalAccumulatedMoney += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                command = Console.ReadLine();
            }
            double priceOfProduct = 0;

            string product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        priceOfProduct = 2.0;
                        break;
                    case "Water":
                        priceOfProduct = 0.7;
                        break;
                    case "Crisps":
                        priceOfProduct = 1.5;
                        break;
                    case "Soda":
                        priceOfProduct = 0.8;
                        break;
                    case "Coke":
                        priceOfProduct = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;

                }
                if (priceOfProduct <= totalAccumulatedMoney)
                {
                    totalAccumulatedMoney -= priceOfProduct;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalAccumulatedMoney:f2}");

        }
    }
}
