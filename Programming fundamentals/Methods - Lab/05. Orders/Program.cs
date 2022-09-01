using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantityOfProduct = int.Parse(Console.ReadLine());

            Price(product, quantityOfProduct);
        }
        static void Price(string product, int quantityOfProduct)
        {
            double price = 0.0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            price *= quantityOfProduct;
            Console.WriteLine($"{price:f2}");
        }
    }
}
