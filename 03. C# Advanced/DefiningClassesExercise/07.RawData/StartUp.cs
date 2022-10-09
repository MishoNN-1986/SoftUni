using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int quantityCars = int.Parse(Console.ReadLine());
            List<Car> allCars = new List<Car>();  //може HashSet, вместо List, за да няма повтарящи
            for (int i = 0; i < quantityCars; i++)
            {
                string[] informationForCar = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = informationForCar[0];
                int engineSpeed = int.Parse(informationForCar[1]);
                int enginePower = int.Parse(informationForCar[2]);
                Engine engine = new Engine(engineSpeed, enginePower);
                int cargoWeight = int.Parse(informationForCar[3]);
                string cargoType = informationForCar[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                string[] allTiresInfo = informationForCar
                    .Skip(5)
                    .ToArray();
                List<Tire> tires = new List<Tire>();
                for (int j = 0; j < allTiresInfo.Length; j += 2)
                {
                    double pressure = double.Parse(allTiresInfo[j]);
                    int age = int.Parse(allTiresInfo[j + 1]);
                    Tire tire = new Tire(pressure, age);
                    tires.Add(tire);
                }
                Car car = new Car(model, engine, cargo, tires);
                allCars.Add(car);
            }
            string command = Console.ReadLine();

            //if (command == "fragile")
            //{
            //    allCars
            //        .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
            //        .Select(c => c.Model)
            //        .ToList()
            //        .ForEach(Console.WriteLine);
            //}
            //else if (command == "flamable")
            //{
            //    allCars
            //        .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
            //        .Select(c => c.Model)
            //        .ToList()
            //        .ForEach(Console.WriteLine);
            //}

            for (int i = 0; i < allCars.Count; i++)
            {
                Car car = allCars[i];

                if (command == "fragile")
                {
                    bool pressure = false;
                    for (int j = 0; j < car.Tires.Count; j++)
                    {
                        if (car.Tires[j].Pressure < 1) // поне 1 гума да е под 1
                        {
                            pressure = true;
                        }
                    }
                    if (car.Cargo.Type == command && pressure)
                    {
                        Console.WriteLine(car);
                    }
                }
                else if (command == "flamable" && car.Cargo.Type == command && car.Engine.Power > 250)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
