using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayStay = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            double priceForNight = 0.0;
            dayStay = dayStay - 1;
            switch (typeRoom)
            {
                case "room for one person":
                    priceForNight = 18.00;
                    priceForNight = priceForNight * dayStay;
                    break;
                case "apartment":
                    priceForNight = 25.00;
                    priceForNight = priceForNight * dayStay;
                    if (dayStay < 10)
                    {
                        priceForNight = priceForNight - priceForNight * 0.3;
                    }
                    else if (dayStay >= 10 && dayStay <= 15)
                    {
                        priceForNight = priceForNight - priceForNight * 0.35;
                    }
                    else
                    {
                        priceForNight = priceForNight - priceForNight * 0.5;
                    }
                    break;
                case "president apartment":
                    priceForNight = 35.00;
                    priceForNight = priceForNight * dayStay;
                    if (dayStay < 10)
                    {
                        priceForNight = priceForNight - priceForNight * 0.1;
                    }
                    else if (dayStay >= 10 && dayStay <= 15)
                    {
                        priceForNight = priceForNight - priceForNight * 0.15;
                    }
                    else
                    {
                        priceForNight = priceForNight - priceForNight * 0.2;
                    }
                    break;

            }
            if (rating == "positive")
            {
                priceForNight = priceForNight + priceForNight * 0.25;
            }
            else if (rating == "negative")
            {
                priceForNight = priceForNight - priceForNight * 0.1;
            }
            Console.WriteLine($"{priceForNight:f2}");
        }
    }
}
