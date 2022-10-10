﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04._NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;
        private int horsePower;
        private double fuel;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public virtual double FuelConsumption => DEFAULT_FUEL_CONSUMPTION;

        public virtual void Drive(double kilometers)
        {
            double consumptedFuel = kilometers * this.Fuel;

            if (this.Fuel >= consumptedFuel)
            {
                this.Fuel -= consumptedFuel;
            }
        }
    }
}
