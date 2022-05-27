using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTournamets = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            double br = 0;
            double average = 0;
            double percentWinnings = 0;
            int newPoints = 0;
            for (int i = 0; i < numTournamets; i++)
            {
                string tournamentState = Console.ReadLine();
                switch (tournamentState)
                {
                    case "W":
                        newPoints += 2000;
                        startPoints = startPoints + 2000;

                        br++;
                        break;
                    case "F":
                        newPoints += 1200;
                        startPoints = startPoints + 1200;

                        break;
                    case "SF":
                        newPoints += 720;
                        startPoints = startPoints + 720;

                        break;
                }
                average = newPoints / numTournamets;
            }
            percentWinnings = br / numTournamets * 100;
            Console.WriteLine($"Final points: {startPoints}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percentWinnings:f2}%");
        }
    }
}
