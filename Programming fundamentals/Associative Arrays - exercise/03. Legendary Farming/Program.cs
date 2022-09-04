using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> productsWithPrice=new Dictionary<string,double>();
            Dictionary<string,int> productsWithQuantity=new Dictionary<string,int>();

            string product=Console.ReadLine();
            while (product!="buy")
            {
                string[] tokens = product.Split(" ");
                double productPrice=double.Parse(tokens[1]);
                int quantity=int.Parse(tokens[2]);
                
                if (!productsWithPrice.ContainsKey(tokens[0]))
                {
                    productsWithPrice.Add(tokens[0], productPrice);
                    productsWithQuantity.Add(tokens[0],quantity);
                }
                else
                {
                    productsWithPrice.Remove(tokens[0]);
                    productsWithPrice.Add(tokens[0],productPrice);
                    productsWithQuantity[tokens[0]] += quantity;
                }
                product=Console.ReadLine();
            }
            foreach (var price in productsWithPrice)
            {
                foreach (var quantityOfProduct in productsWithQuantity)
                {
                    if (price.Key== quantityOfProduct.Key)
                    {
                     Console.WriteLine($"{price.Key} -> {price.Value * quantityOfProduct.Value:f2}");

                    }
                }
            }

        }
    }
}
