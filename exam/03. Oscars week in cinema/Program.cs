using System;

namespace _03._Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string hallType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double price = 0;
            switch (movie)
            {
                case "A Star Is Born":
                    if (hallType=="normal")
                    {
                        price = 7.50;
                    }
                    else if (hallType=="luxury")
                    {
                        price = 10.50;
                    }
                    else if (hallType=="ultra luxury")
                    {
                        price = 13.50;
                    }
                    break;
                case "Bohemian Rhapsody":
                    if (hallType == "normal")
                    {
                        price = 7.35;
                    }
                    else if (hallType == "luxury")
                    {
                        price = 9.45;
                    }
                    else if (hallType == "ultra luxury")
                    {
                        price = 12.75;
                    }
                    break;
                case "Green Book":
                    if (hallType == "normal")
                    {
                        price = 8.15;
                    }
                    else if (hallType == "luxury")
                    {
                        price = 10.25;
                    }
                    else if (hallType == "ultra luxury")
                    {
                        price = 13.25;
                    }
                    break;
                case "The Favourite":
                    if (hallType == "normal")
                    {
                        price = 8.75;
                    }
                    else if (hallType == "luxury")
                    {
                        price = 11.55;
                    }
                    else if (hallType == "ultra luxury")
                    {
                        price = 13.95;
                    }
                    break;
                
                   
            }
            price = tickets * price;
            Console.WriteLine($"{movie} -> {price:f2} lv.");
        }
    }
}
