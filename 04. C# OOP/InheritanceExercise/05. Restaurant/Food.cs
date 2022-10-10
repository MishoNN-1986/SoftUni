using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Restaurant
{
    public class Food
    {
        private double grams;

        public Food(string name, decimal price, double grams)
        {
            this.Grams = grams;
        }

        public virtual double Grams { get; set; }
    }
}
