using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
          int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInfo=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                
                string carModel=carInfo[0];
                double fuelAmount=double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer=double.Parse(carInfo[2]);
           
                Car car = new Car(carModel,fuelAmount,fuelConsumptionPerKilometer);
                cars.Add(car);
            }
            string command=Console.ReadLine();
            while (command!="End")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel=arguments[1];
                double amountOfKilometers=double.Parse(arguments[2]);

                Car carToDrive = cars.Where(x => x.Model == carModel).ToList().First();
                carToDrive.Drive(carModel,amountOfKilometers);
                

                command =Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}