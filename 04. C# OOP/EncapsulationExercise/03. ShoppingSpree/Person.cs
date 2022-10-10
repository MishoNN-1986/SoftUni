using _03._ShoppingSpree.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03._ShoppingSpree
{
    public class Person
    {
        private const decimal MONEY_MIN_VALUE = 0m;

        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person()
        {
            this.bagOfProducts = new List<Product>();
        }

        public Person(string name, decimal money)
            : this()
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < MONEY_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyExceptionMessage);
                }
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProducts
        {
            get
            {
                return this.bagOfProducts.AsReadOnly();
            }

        }

        public void BuyProduct(Product product)
        {
            if (this.money >= product.Cost)
            {
                this.money -= product.Cost;
                this.bagOfProducts.Add(product);
            }
            else
            {
                throw new InvalidOperationException(string.Format(GlobalConstants.InsufficientMoneyExceptionMessage, this.Name, product.Name));
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            return this.BagOfProducts.Count > 0
                ? $"{this.Name} - {string.Join(", ", this.BagOfProducts)}"
                : $"{this.Name} - Nothing bought";
        }
    }
}
