﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02._VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double additionalConsumptionPerKm = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalConsumption => additionalConsumptionPerKm;
    }
}
