
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            double totalPressure = 0;
            List<Tire> tires = new List<Tire>();
            List<double> pressures= new List<double>();
            string tiresInfo = Console.ReadLine();
            while (tiresInfo != "No more tires")
            {
                string[] arguments = tiresInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < arguments.Length - 1; i += 2)
                {
                    int year = int.Parse(arguments[i]);
                    double pressure = double.Parse(arguments[i + 1]);

                    tires.Add(new Tire(year, pressure));
                }
                 totalPressure = GetSumOfTirePressure(tires);
                pressures.Add(totalPressure);
                tires.Clear();
                tiresInfo = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();
            string engineInfo = Console.ReadLine();
            while (engineInfo != "Engines done")
            {
                string[] arguments = engineInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse((string)arguments[0]);
                double cubicCapacity = double.Parse((string)arguments[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));

               
                engineInfo = Console.ReadLine();
            }

            List<Car> cars = new List<Car>();
            string carInfo = Console.ReadLine();
            while (carInfo != "Show special")
            {
                string[] arguments = carInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
                string make = arguments[0];
                string model = arguments[1];
                int year = int.Parse(arguments[2]);
                double fuelQuantity = double.Parse(arguments[3]);
                double fuelConsumption = double.Parse(arguments[4]);
                int engineIndex = int.Parse(arguments[5]);
                int tiresIndex = int.Parse(arguments[6]);

                
                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]));
              

                carInfo = Console.ReadLine();
            }
            //&& (cars[i].Tire.Pressure>=9&& cars[i].Tire.Pressure<=10)
            for (int i = 0; i < cars.Count; i++)
            {
              
                if (cars[i].Engine.HorsePower >= 330 
                    && cars[i].Year >= 2017
                    && (pressures[i] > 9 && pressures[i] < 10))
                {
                    cars[i].FuelQuantity=cars[i].FuelQuantity - (0.20 * cars[i].FuelConsumption);

                        Console.WriteLine($"Make: {cars[i].Make}");
                        Console.WriteLine($"Model: {cars[i].Model}");
                        Console.WriteLine($"Year: {cars[i].Year}");
                        Console.WriteLine($"HorsePowers: {cars[i].Engine.HorsePower}");
                        Console.WriteLine($"FuelQuantity: {cars[i].FuelQuantity}");
                    
                }
            }
        }

        private static double GetSumOfTirePressure(List<Tire> tires)
        {
            double sum = 0;
            for (int i = 0; i < tires.Count; i++)
            {
                sum+=tires[i].Pressure;
            }
            return sum;
        }
    }
}
