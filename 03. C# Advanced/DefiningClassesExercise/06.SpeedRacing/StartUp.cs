using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] driveInfo = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = driveInfo[1];
                int amountOfKm = int.Parse(driveInfo[2]);
                Car car = cars.First(c => c.Model == model);
                if (!car.Drive(amountOfKm))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                command = Console.ReadLine();
            }
            cars.ForEach(Console.WriteLine);
            //Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
