using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;
        public virtual double FuelConsumption =>DEFAULT_FUEL_CONSUMPTION;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual void Drive(double kilometers)
        {
            double leftFuel = Fuel - FuelConsumption * kilometers;
            if (leftFuel>=0)
            {
                Fuel = leftFuel;
            }
        }
    }
}
