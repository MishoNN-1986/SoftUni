using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Restaurant
{
    public class Beverage : Product
    {
        private double milliters;

        public Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliters = milliliters;
        }

        public double Milliters { get; set; }
    }
}
