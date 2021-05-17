using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }

        public void Drive(double distance)
        {
            double neededFuel = distance / 100.0 * this.FuelConsumption;
            this.FuelQuantity -= neededFuel;
        }

        //public string SpecialCar()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    double sumPressure = 0;
        //    for (int i = 0; i < tires.Length; i++)
        //    {
        //        double tirePressure = tires[i].Pressure;
        //        sumPressure += tirePressure;
        //    }
        //    if (this.Year >= 2017 && this.Engine.HorsePower > 330 && sumPressure > 9 && sumPressure < 10)
        //    {
        //        sb.Append($"Make: {this.Make}{Environment.NewLine}");
        //        sb.Append($"Model: {this.Model}{Environment.NewLine}");
        //        sb.Append($"Year: {this.Year}{Environment.NewLine}");
        //        sb.Append($"HorsePowers: {this.Engine.HorsePower}{Environment.NewLine}");
        //        sb.Append($"FuelQuantity: {this.FuelQuantity}{Environment.NewLine}");
        //    }
        //    return sb.ToString();
        //}
    }
}
