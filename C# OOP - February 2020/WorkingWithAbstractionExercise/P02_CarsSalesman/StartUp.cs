using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CarsSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var countEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            var cars = new List<Car>();
            for (int i = 0; i < countEngines; i++)
            {
                var engineDetails = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string engineModel = engineDetails[0];
                double enginePower = double.Parse(engineDetails[1]);
                double engineDisplacement;
                string engineEfficiency = null;
                Engine engine = null;
                if (engineDetails.Length == 4)
                {
                    engineDisplacement = double.Parse(engineDetails[2]);
                    engineEfficiency = engineDetails[3];
                    engine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
                }
                else if (engineDetails.Length == 3)
                {
                    bool isDouble = double.TryParse(engineDetails[2], out engineDisplacement);
                    if (isDouble)
                    {
                        engine = new Engine(engineModel, enginePower, engineDisplacement);
                    }
                    else
                    {
                        engineEfficiency = engineDetails[2];
                        engine = new Engine(engineModel, enginePower, engineEfficiency);
                    }
                }
                else if (engineDetails.Length == 2)
                {
                    engine = new Engine(engineModel, enginePower);
                }
                engines.Add(engine);
            }
            var countCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countCars; i++)
            {
                var carDetails = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string carModel = carDetails[0];
                string carEngineModel = carDetails[1];
                Engine engine = engines.FirstOrDefault(e => e.Model == carEngineModel);
                double carWeight;
                string carColor = null;
                Car car = null;
                if (carDetails.Length == 4)
                {
                    carWeight = double.Parse(carDetails[2]);
                    carColor = carDetails[3];
                    car = new Car(carModel, engine, carWeight, carColor);
                }
                else if (carDetails.Length == 3)
                {
                    bool isDouble = double.TryParse(carDetails[2], out carWeight);
                    if (isDouble)
                    {
                        car = new Car(carModel, engine, carWeight);
                    }
                    else
                    {
                        car = new Car(carModel, engine, carColor);
                    }
                }
                else if (carDetails.Length == 2)
                {
                    car = new Car(carModel, engine);
                }
                cars.Add(car);
            }
            PrintAllCars(cars);
        }

        static void PrintAllCars(List<Car> cars)
        {
            Console.WriteLine(string.Join($"{Environment.NewLine}", cars));
        }
    }
}
