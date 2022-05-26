using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            percent = percent / 100;
            int volumeInTank = lenght * width * height;
            double volumeInLiters = volumeInTank * 0.001;
            double litersNeeded = volumeInLiters * (1 - percent);
            Console.WriteLine(litersNeeded);
        }
    }
}
