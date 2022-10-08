using System;
using System.Collections.Generic;
using System.Linq;
namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            List<string> input = Console.ReadLine().Split("/").ToList();
            while (input[0] != "end")
            {

                if (input[0] == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = input[1],
                        Model = input[2],
                        HorsePower = double.Parse(input[3])
                    };
                    catalog.Cars.Add(car);
                }
                else if (input[0] == "Truck")
                {
                    Truck truck = new Truck()
                    {
                        Brand = input[1],
                        Model = input[2],
                        Weight = double.Parse(input[3])
                    };
                    catalog.Trucks.Add(truck);
                }
                input = Console.ReadLine().Split("/").ToList();
            }
            catalog.Cars.Sort((a, b) => string.Compare(a.Brand, b.Brand));
            catalog.Trucks.Sort((a, b) => string.Compare(a.Brand, b.Brand));
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
    }
}
