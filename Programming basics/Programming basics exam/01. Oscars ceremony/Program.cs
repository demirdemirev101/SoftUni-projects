using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rentForHall = int.Parse(Console.ReadLine());
            double statues = rentForHall - rentForHall*0.3;
            double catering  = statues - statues*0.15;
            double soundSystem = catering * 1 / 2;
            double sum = rentForHall + statues + catering + soundSystem;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
