using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar(200, 10);
            sportCar.Drive(1);
            Console.WriteLine(sportCar.Fuel);
        }
    }
}
