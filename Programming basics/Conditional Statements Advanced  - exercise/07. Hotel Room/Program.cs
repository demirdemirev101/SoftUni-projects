using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double apartamentPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartamentPrice = 65;
                    if (numNights > 7 && numNights < 14)
                    {
                        studioPrice = studioPrice - studioPrice * 0.05;


                    }
                    if (numNights > 14)
                    {
                        studioPrice = studioPrice - studioPrice * 0.3;
                        apartamentPrice = apartamentPrice - apartamentPrice * 0.1;

                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartamentPrice = 68.70;
                    if (numNights > 14)
                    {

                        studioPrice = studioPrice - studioPrice * 0.2;
                        apartamentPrice = apartamentPrice - apartamentPrice * 0.1;

                    }

                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartamentPrice = 77;
                    if (numNights > 14)
                    {
                        apartamentPrice = apartamentPrice - apartamentPrice * 0.1;
                    }
                    break;
            }
            studioPrice = studioPrice * numNights;
            apartamentPrice = apartamentPrice * numNights;
            Console.WriteLine($"Apartment: {apartamentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");

        }
    }
}
