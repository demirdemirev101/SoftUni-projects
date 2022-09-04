using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-Z]+?[a-z]*?)<<(?<price>\d+(\.?\d+)?)!(?<quantity>\d*)";
            List<string> list = new List<string>(); 
            double totalPrice = 0;
            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);
               
                Match match = regex.Match(input);
                if (match.Success)
                {
                    var name=match.Groups["name"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var quantity = int.Parse(match.Groups["quantity"].Value);
                    list.Add(name);
                    totalPrice+=price*quantity;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            list.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");

        }
    }
}
