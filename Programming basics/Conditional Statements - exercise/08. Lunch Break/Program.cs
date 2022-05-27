using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOftheserial = Console.ReadLine();
            int lenghtOfTheEpisode = int.Parse(Console.ReadLine());
            int breaktimeLenght = int.Parse(Console.ReadLine());
            double timeLeft = 5.0 / 8 * breaktimeLenght;
            if (timeLeft >= lenghtOfTheEpisode)
            {

                Console.WriteLine($"You have enough time to watch {nameOftheserial} and left with {Math.Ceiling(timeLeft - lenghtOfTheEpisode)} minutes free time.");
            }
            else
            {

                Console.WriteLine($"You don't have enough time to watch {nameOftheserial}, you need {Math.Ceiling(lenghtOfTheEpisode - timeLeft)} more minutes.");
            }
        }
    }
}
