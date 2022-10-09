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

        public void Drive(double distance)
        {
            double neededFuel = distance / 100 * this.FuelConsumption;
            bool canContinue = this.FuelQuantity - neededFuel >= 0;
            if (canContinue)
            {
                this.FuelQuantity -= neededFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            //return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: {this.Make}{Environment.NewLine}");
            sb.Append($"Model: {this.Model}{Environment.NewLine}");
            sb.Append($"Year: {this.Year}{Environment.NewLine}");
            sb.Append($"Fuel: {this.FuelQuantity:F2}L");
            return sb.ToString();
        }
    }
}
