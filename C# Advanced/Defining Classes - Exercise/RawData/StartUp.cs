using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
           int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
Car car=new Car(
    carInfo[0], int.Parse(carInfo[1]),
    int.Parse(carInfo[2]),
    int.Parse(carInfo[3]),
    carInfo[4],
    double.Parse(carInfo[5]),
    int.Parse(carInfo[6]),
    double.Parse(carInfo[7]),
    int.Parse(carInfo[8]),
    double.Parse(carInfo[9]), 
    int.Parse(carInfo[10]), 
    double.Parse(carInfo[11]), 
    int.Parse(carInfo[12]) );

                cars.Add(car);
            }
            string[] filteredCars;
            string type=Console.ReadLine();
            if (type=="fragile")
            {
                 filteredCars =
                    cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(c=>c.Pressure<1))
                    .Select(c=>c.Model)
                    .ToArray();
            }
            else
            {
                filteredCars =
                    cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.EnginePower>250)
                    .Select(c => c.Model)
                    .ToArray();
            }
            foreach (var carModel in filteredCars)
            {
                Console.WriteLine(carModel);
            }
        }
    }
}
