using System;
using System.Collections.Generic;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
        public Product()
        {
            this.Sales = new HashSet<Sale>();
            this.Descriptions = "No description"; // дефолтна стойност
        }

        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        public int MyProperty { get; set; }

        public string Descriptions { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
