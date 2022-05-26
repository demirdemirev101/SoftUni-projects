using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());
            double priceOfOrder;
            double priceOfDesert;
            priceOfOrder = (10.35 * chickenMenus) + (12.40 * fishMenus) + (vegetarianMenus * 8.15);
            priceOfDesert = priceOfOrder * 0.2;
            priceOfOrder = (10.35 * chickenMenus) + (12.40 * fishMenus) + (vegetarianMenus * 8.15) + priceOfDesert + 2.50;
            Console.WriteLine(priceOfOrder);
        }
    }
}
