using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main()
        {
            List<Engine> engines = new List<Engine>();  
        int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (engineInfo.Length == 2)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
                else if (engineInfo.Length == 3)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    if (int.TryParse(engineInfo[2], out int displacement))
                    {
                        Engine engine = new Engine(model,power,displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        string efficiency = engineInfo[2];
                        Engine engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }
                }
                else
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];

                    Engine engine = new Engine(model, power, displacement,efficiency);
                    engines.Add(engine);
                }
            }
            List<Car> cars = new List<Car>();
            int m=int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (carInfo.Length == 2)
                {
                    string carModel = carInfo[0];
                    string engineModel = carInfo[1];
                    if (engines.Exists(e => e.Model == engineModel))
                    {
                        Engine findEngine = engines.Where(e => e.Model == engineModel).First();

                        Car car = new Car(carModel, findEngine);
                        cars.Add(car);
                    }
                }
                else if (carInfo.Length == 3)
                {
                    string carModel = carInfo[0];
                    string engineModel = carInfo[1];
                    string thirdParameter = carInfo[2];
                    Engine findEngine = engines.Where(e => e.Model == engineModel).First();
                    if (int.TryParse(thirdParameter, out int weight))
                    {
                        if (engines.Exists(e => e.Model == engineModel))
                        {

                            Car car = new Car(carModel, findEngine, weight);
                            cars.Add(car);
                        }

                    }
                    else
                    {
                        string color = carInfo[2];
                        Car car = new Car(carModel, findEngine, color);
                        cars.Add(car);
                    }
                }
                else
                {
                    string carModel = carInfo[0];
                    string engineModel = carInfo[1];
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    if (engines.Exists(e => e.Model == engineModel))
                    {
                        Engine findedEngine = engines.Where(e => e.Model == engineModel).First();

                        Car car = new Car(carModel, findedEngine, weight, color);
                        cars.Add(car);
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}