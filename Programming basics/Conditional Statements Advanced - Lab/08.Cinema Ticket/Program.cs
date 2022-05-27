using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int priceTicket = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    priceTicket = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    priceTicket = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    priceTicket = 16;
                    break;

            }
            Console.WriteLine(priceTicket);
        }
    }
}
