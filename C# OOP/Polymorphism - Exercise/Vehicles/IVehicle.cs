using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get;}
        public double FuelConsumtionPerKM { get;}
        public double TankCapacity { get;}
        public void Drive(double distance);
        public void Refuel(double liters);
    }
}
