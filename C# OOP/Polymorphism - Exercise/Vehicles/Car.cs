using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumtionPerKM;
        private double tankCapacity;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumtionPerKM = 0.9+fuelConsumption;
            TankCapacity = tankCapacity;
            if (FuelQuantity > TankCapacity)
            {
                FuelQuantity = 0.0;
            }
        }
        public double FuelQuantity  
        {
            get { return fuelQuantity; }
            private set 
            {
                fuelQuantity = value;
            }
        }

        public double FuelConsumtionPerKM 
        {
            get { return fuelConsumtionPerKM; } 
            private set 
            {
                fuelConsumtionPerKM = value; 
            } 
        }
        public double TankCapacity 
        {
            get { return tankCapacity; }
            private set 
            { 
                tankCapacity = value;
            } 
        }
        public void Drive(double distance)
        {
            if (FuelQuantity-(FuelConsumtionPerKM*distance)>=0)
            {
                FuelQuantity -= FuelConsumtionPerKM * distance;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters;
            }
        }
    }
}
