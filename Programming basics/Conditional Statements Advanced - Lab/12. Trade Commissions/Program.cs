using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double buyings = double.Parse(Console.ReadLine());
            double commision = 0;
            switch (city)
            {
                case "Sofia":
                    if (buyings >= 0 && buyings <= 500)
                    {
                        commision = buyings * 0.05;
                    }
                    else if (buyings > 500 && buyings <= 1000)
                    {
                        commision = buyings * 0.07;
                    }
                    else if (buyings > 1000 && buyings <= 10000)
                    {
                        commision = buyings * 0.08;
                    }
                    else if (buyings > 10000)
                    {
                        commision = buyings * 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (buyings >= 0 && buyings <= 500)
                    {
                        commision = buyings * 0.045;
                    }
                    else if (buyings > 500 && buyings <= 1000)
                    {
                        commision = buyings * 0.075;
                    }
                    else if (buyings > 1000 && buyings <= 10000)
                    {
                        commision = buyings * 0.10;
                    }
                    else if (buyings > 10000)
                    {
                        commision = buyings * 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (buyings >= 0 && buyings <= 500)
                    {
                        commision = buyings * 0.055;
                    }
                    else if (buyings > 500 && buyings <= 1000)
                    {
                        commision = buyings * 0.08;
                    }
                    else if (buyings > 1000 && buyings <= 10000)
                    {
                        commision = buyings * 0.12;
                    }
                    else if (buyings > 10000)
                    {
                        commision = buyings * 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
            if (commision != 0)
            {
                Console.WriteLine($"{commision:f2}");
            }
        }
    }
}
