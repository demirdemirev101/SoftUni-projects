using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalSteps = 10000;
            int totalStepsForTheDay = 0;
            int steps = 0;
            string input = Console.ReadLine();
            while (true)
            {
                if (input != "Going home")
                {
                 steps= int.Parse(input);
                 totalStepsForTheDay += steps;
                    
                    if (totalStepsForTheDay >= goalSteps)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{totalStepsForTheDay - goalSteps} steps over the goal!");
                        break;
                    }
                   else
                    {
                        Console.WriteLine($"{goalSteps - totalStepsForTheDay} more steps to reach goal.");

                        break;
                    }
                }

                if (input == "Going home")
                {
                   
                    input = Console.ReadLine();
                    totalStepsForTheDay += steps;
                    continue;
                }
           
            input= Console.ReadLine();
            }
        }
    }
}
