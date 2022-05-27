using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double swim = meters * seconds;
            double slowness;
            slowness = Math.Floor((meters / 15));
            slowness = slowness * 12.5;
            double sumTime;
            sumTime = swim + slowness;
            if (sumTime < worldRecord)
            {

                Console.WriteLine($" Yes, he succeeded! The new world record is {sumTime:f2} seconds.");
            }
            else
            {

                Console.WriteLine($"No, he failed! He was {sumTime - worldRecord:f2} seconds slower.");
            }
        }
    }
}
