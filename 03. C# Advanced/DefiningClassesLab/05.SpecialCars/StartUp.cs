using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string tiresCommand = Console.ReadLine();
            List<Tire[]> allInputTires = new List<Tire[]>();
            List<Engine> allEngines = new List<Engine>();

            while (tiresCommand != "No more tires")
            {
                string[] inputTires = tiresCommand
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Tire[] tires = new Tire[inputTires.Length / 2];

                for (int i = 0; i < inputTires.Length; i += 2)
                {
                    int year = int.Parse(inputTires[i]);
                    double pressure = double.Parse(inputTires[i + 1]);
                    Tire tire = new Tire(year, pressure);

                    tires[i / 2] = tire;
                }

                allInputTires.Add(tires);
                tiresCommand = Console.ReadLine();
            }

            string enginesCommand = Console.ReadLine();
            while (enginesCommand != "Engines done")
            {
                string[] inputEngines = enginesCommand
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(inputEngines[0]);
                double cubicCapacity = double.Parse(inputEngines[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                allEngines.Add(engine);
                enginesCommand = Console.ReadLine();
            }
            string specialCarsCommand = Console.ReadLine();
            //List<string> allSpecialCars = new List<string>();
            StringBuilder sb = new StringBuilder();

            while (specialCarsCommand != "Show special")
            {
                string[] inputSpecialCar = specialCarsCommand
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string make = inputSpecialCar[0];
                string model = inputSpecialCar[1];
                int year = int.Parse(inputSpecialCar[2]);
                double fuelQuantity = double.Parse(inputSpecialCar[3]);
                double fuelConsumption = double.Parse(inputSpecialCar[4]);
                int engineIndex = int.Parse(inputSpecialCar[5]);
                int horsePower = allEngines[engineIndex].HorsePower;
                int tiresIndex = int.Parse(inputSpecialCar[6]);
                Tire[] tires = allInputTires[tiresIndex];
                double sumPressure = 0;
                for (int i = 0; i < tires.Length; i++)
                {
                    double tirePressure = tires[i].Pressure;
                    sumPressure += tirePressure;
                }

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, allEngines[engineIndex], tires);
                car.Drive(20);
                if (year >= 2017 && horsePower > 330 && sumPressure > 9 && sumPressure < 10)
                {
                    sb.Append($"Make: {car.Make}{Environment.NewLine}");
                    sb.Append($"Model: {car.Model}{Environment.NewLine}");
                    sb.Append($"Year: {car.Year}{Environment.NewLine}");
                    sb.Append($"HorsePowers: {car.Engine.HorsePower}{Environment.NewLine}");
                    sb.Append($"FuelQuantity: {car.FuelQuantity}{Environment.NewLine}");
                }


                //var specialCar = car.SpecialCar();
                //allSpecialCars.Add(specialCar);
                specialCarsCommand = Console.ReadLine();
            }
            //foreach (var specialCar in allSpecialCars)
            //{
            //    Console.WriteLine(specialCar); // трябва да е Write, иначе са 2 празни реда
            //}
            Console.WriteLine(sb);
        }
    }
}
