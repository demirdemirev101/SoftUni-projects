using System;
using System.Linq;
namespace Vehicles
{

    public class StartUp
    {
        static void Main()
        {
            string[] carInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantityForCar=double.Parse(carInfo[1]);
            double fuelConsumptionForCar=double.Parse(carInfo[2]);
            double tankCapacityForCar=double.Parse(carInfo[3]);

            Car car = new Car(fuelQuantityForCar, fuelConsumptionForCar,tankCapacityForCar);


            string[] truckInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantityForTruck = double.Parse(truckInfo[1]);
            double fuelConsumptionForTruck = double.Parse(truckInfo[2]);
            double tankCapacityForTruck = double.Parse(truckInfo[3]);

            Truck truck = new Truck(fuelQuantityForTruck, fuelConsumptionForTruck,tankCapacityForTruck);

            string[] busInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantityForBus = double.Parse(busInfo[1]);
            double fuelConsumptionForBus = double.Parse(busInfo[2]);
            double tankCapacityForBus = double.Parse(busInfo[3]);

            Bus bus = new Bus(fuelQuantityForBus, fuelConsumptionForBus,tankCapacityForBus);


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string action = tokens[0] +" "+ tokens[1];
                if (action== "Drive Car")
                {
                    double carDistance=double.Parse(tokens[2]);
                    car.Drive(carDistance);
                }
                else if (action== "Drive Truck")
                {
                    double truckDistance = double.Parse(tokens[2]);
                    truck.Drive(truckDistance);
                }
                else if (action == "Drive Bus")
                {
                    double busDistance = double.Parse(tokens[2]);
                    bus.Drive(busDistance);
                }
                else if (action == "DriveEmpty Bus")
                {
                    double busDistance = double.Parse(tokens[2]);
                    bus.DriveEmpty(busDistance);
                }
                else if (action == "Refuel Car")
                {
                    double carLiters = double.Parse(tokens[2]);
                    car.Refuel(carLiters);
                }
                else if (action == "Refuel Truck")
                {
                    double truckLiters = double.Parse(tokens[2]);
                    truck.Refuel(truckLiters);
                }
                else if (action == "Refuel Bus")
                {
                    double busLiters = double.Parse(tokens[2]);
                    bus.Refuel(busLiters);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
