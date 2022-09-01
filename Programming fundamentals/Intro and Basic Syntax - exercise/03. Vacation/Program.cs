using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            switch (typeGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }

            if (typeGroup == "Students" && peopleCount >= 30)
            {
                totalPrice = price * peopleCount;
                totalPrice -= totalPrice * 0.15;
            }
            else if (typeGroup == "Business" && peopleCount >= 100)
            {
                peopleCount -= 10;
                totalPrice = price * peopleCount;
            }
            else if (typeGroup == "Regular" && (peopleCount >= 10 && peopleCount <= 20))
            {
                totalPrice = price * peopleCount;
                totalPrice -= totalPrice * 0.05;
            }
            else
            {
                totalPrice = price * peopleCount;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
