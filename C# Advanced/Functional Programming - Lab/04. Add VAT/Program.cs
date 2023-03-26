using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<decimal> prices=Console.ReadLine().Split(", ").Select(decimal.Parse).ToList();

            Func<decimal, decimal> addVad = x => x + x * 0.2m;
            prices = prices.Select(addVad).ToList();
            prices.ForEach(x => Console.WriteLine($"{x:f2}"));
        }
    }
}
