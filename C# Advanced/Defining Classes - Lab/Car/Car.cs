
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string make,string model, int year):this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption):this(make,model,year)
        {
            FuelQuantity=fuelQuantity;
            FuelConsumption=fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine, Tire tire):this(make, model, year,fuelQuantity,fuelConsumption)
        {
            Engine = engine;
            Tire = tire;
        }

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire tire;
        public string Make 
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            } 
        }
        public string Model
        {
            get 
            { 
                return model; 
            }
            set 
            {
                model = value; 
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;   
            }
        }
        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            set
            {
                fuelQuantity = value;
            }
        }
        public double  FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
            set 
            { 
                fuelConsumption = value; 
            }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public Tire Tire
        {
            get { return tire; }
            set { tire = value; }
        }
        public void Drive(double distance)
        {
            
            double leftFuel = fuelQuantity - (distance * fuelConsumption);
            if (leftFuel < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
            fuelQuantity = leftFuel;
        }
        public  string WhoAmI()
        {
            return $"Make: {make}\nModel: {model}\nYear: {year}\nFuel: {fuelQuantity:F2}";
        }
    }
}
