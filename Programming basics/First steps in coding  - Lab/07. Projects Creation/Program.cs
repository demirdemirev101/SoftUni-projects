using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArchitect = Console.ReadLine();
            int numOfProjects = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {nameOfTheArchitect} will need {numOfProjects * 3} hours to complete {numOfProjects} project/s. ");
        }
    }
}
