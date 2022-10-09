using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int quantityEngines = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < quantityEngines; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                int displacement;
                string efficiency = null;
                Engine engine = null;
                if (engineInfo.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (engineInfo.Length == 4)
                {
                    displacement = int.Parse(engineInfo[2]);
                    efficiency = engineInfo[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }
                else if (engineInfo.Length == 3)
                {
                    bool isInt = int.TryParse(engineInfo[2], out displacement);
                    if (!isInt)
                    {
                        efficiency = engineInfo[2];
                        engine = new Engine(model, power, efficiency);
                    }
                    else
                    {
                        engine = new Engine(model, power, displacement);
                    }
                }
                engines.Add(engine);
            }
            int quantityCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantityCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engineModel = carInfo[1];
                Engine engine = engines.First(e => e.Model == engineModel);
                int weight;
                string color = null;
                Car car = null;
                if (carInfo.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (carInfo.Length == 3)
                {
                    bool isInt = int.TryParse(carInfo[2], out weight);
                    if (!isInt)
                    {
                        color = carInfo[2];
                        car = new Car(model, engine, color);
                    }
                    else
                    {
                        car = new Car(model, engine, weight);
                    }
                }
                else
                {
                    weight = int.Parse(carInfo[2]);
                    color = carInfo[3];
                    car = new Car(model, engine, weight, color);
                }
                allCars.Add(car);
            }
            Console.WriteLine(string.Join("", allCars));
            //allCars.ForEach(Console.WriteLine);
        }
    }
}
