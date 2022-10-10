using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Restaurant
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
    }
}
