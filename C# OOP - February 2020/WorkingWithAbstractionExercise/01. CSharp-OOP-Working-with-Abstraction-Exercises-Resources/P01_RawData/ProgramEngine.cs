using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_RawData
{
    public class ProgramEngine
    {
        private readonly ICollection<Car> cars; //!!!! чете всякакви колекции, не задължаваме някой да ползва конкретна 
        private readonly ICollection<Tire> carTires;

        public ProgramEngine()
        {
            this.cars = new List<Car>();
            this.carTires = new List<Tire>();
        }

        public void Run() // върти логиката, получава инпут, обработва го и връща аутпут
        {
            int lines = int.Parse(Console.ReadLine());
            ParseInput(lines);

            PrintOutput();
        }

        private void PrintOutput()
        {
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .Select(c => c.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }

        private void ParseInput(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                Engine engine = this.CreateEngine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                Cargo cargo = this.CreateCargo(cargoWeight, cargoType);

                this.ReadTires(parameters);

                Car car = this.CreateCar(model, engine, cargo, this.carTires);
                this.cars.Add(car);
            }
        }

        private Car CreateCar(string model, Engine engine, Cargo cargo, ICollection<Tire> carTires)
        {
            return new Car(model, engine, cargo, carTires.ToArray());
        }

        private void ReadTires(string[] parameters)
        {
            for (int j = 5; j <= 12; j += 2)
            {
                double tirePressure = double.Parse(parameters[j]);
                int tireAge = int.Parse(parameters[j + 1]);
                Tire currentTire = CreateTire(tireAge, tirePressure);
                this.carTires.Add(currentTire);
            }
        }

        private Tire CreateTire(int age, double pressure)
        {
            return new Tire(age, pressure);
        }

        private Cargo CreateCargo(int weight, string type)
        {
            return new Cargo(weight, type);
        }

        private Engine CreateEngine(int speed, int power)
        {
            return new Engine(speed, power);
        }
    }
}
