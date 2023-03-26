using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            
            string command=Console.ReadLine();
            while (command!="Revision")
            {
                string[] parts = command.Split(", ");
                string shopName=parts[0];
                string productName=parts[1];
                double productPrice=double.Parse(parts[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName,new Dictionary<string, double>());
                }
                shops[shopName].Add(productName,productPrice);
                
                command = Console.ReadLine();
            }
            shops = shops.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
