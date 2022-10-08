using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalog = new Catalogue();
            int countCars = 0;
            int countTrucks = 0;
            double carsHorsepower = 0;
            double trucksHorsepower = 0;
            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                if (command[0] == "truck")
                {
                    Truck truck = new Truck(command[0], command[1], command[2], double.Parse(command[3]));
                    countTrucks++;
                    trucksHorsepower += double.Parse(command[3]);
                    catalog.Trucks.Add(truck);
                }
                else if (command[0] == "car")
                {
                    Car car = new Car(command[0], command[1], command[2], double.Parse(command[3]));
                    countCars++;
                    carsHorsepower += double.Parse(command[3]);
                    catalog.Cars.Add(car);
                }
                command = Console.ReadLine().Split();
            }
            string model = Console.ReadLine();
            while (model != "Close the Catalogue")
            {
                foreach (Car car in catalog.Cars)
                {
                    if (car.Model == model)
                    {
                        Console.WriteLine($"Type: Car\nModel: {car.Model}\nColor: {car.Color}\nHorsepower: {car.HorsePower}");
                    }
                }
                foreach (Truck truck in catalog.Trucks)
                {
                    if (truck.Model == model)
                    {
                        Console.WriteLine($"Type: Truck\nModel: {truck.Model}\nColor: {truck.Color}\nHorsepower: {truck.HorsePower}");
                    }
                }
                model = Console.ReadLine();
            }
            double carsAverageHorsepower = 0;
            double trucksAverageHorsepower = 0;
            if (countCars > 0)
            {
                carsAverageHorsepower = carsHorsepower / countCars;
            }
            if (countTrucks > 0)
            {
                trucksAverageHorsepower = trucksHorsepower / countTrucks;
            }
            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsepower:F2}.");
        }
    }
}
