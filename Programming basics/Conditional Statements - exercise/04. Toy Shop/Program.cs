using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForTrip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int puppet = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            int quantityOfToys = puzzle + puppet + bear + minion + truck;
            double sumPrice;
            sumPrice = puzzle * 2.60 + puppet * 3 + bear * 4.10 + minion * 8.20 + truck * 2;

            if (quantityOfToys >= 50)
            {
                double discount = sumPrice * 0.25;
                sumPrice = sumPrice - discount;
            }

            double rent = sumPrice * 0.1;
            sumPrice = sumPrice - rent;

            if (sumPrice >= priceForTrip)
            {
                sumPrice = sumPrice - priceForTrip;

                Console.WriteLine($"Yes! {sumPrice:f2} lv left.");
            }
            else
            {
                sumPrice = sumPrice - priceForTrip;

                Console.WriteLine($"Not enough money! {Math.Abs(sumPrice):f2} lv needed.");
            }
        }
    }
}
