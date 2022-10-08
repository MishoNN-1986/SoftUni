using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    class Car
    {
        public Car (string type, string model, string color,double horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
    }
}
