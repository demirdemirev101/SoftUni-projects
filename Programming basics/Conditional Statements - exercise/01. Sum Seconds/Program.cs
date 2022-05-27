using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int ThirdTime = int.Parse(Console.ReadLine());
            int sum = firstTime + secondTime + ThirdTime;
            int sumMin = sum / 60;
            int sumSec = sum % 60;
            if (sumSec < 10)
            {
                Console.WriteLine($"{sumMin}:0{sumSec}");

            }
            else
            {
                Console.WriteLine($"{sumMin}:{sumSec}");
            }
        }
    }
}
