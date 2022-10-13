using P03_SalesDatabase.Data;
using P03_SalesDatabase.Data.Models;
using System;
using System.Collections.Generic;

namespace P03_SalesDatabase
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var db = new SalesContext())
            {
                var productsToAdd = GetProductsToSeed();

                db.Products.AddRange(productsToAdd);

                db.SaveChanges();
            }
        }

        private static List<Product> GetProductsToSeed()
        {
            List<Product> products = new List<Product>();

            var product1 = new Product
            {
                Name = "Banana",
                Price = 2.50M,
                Quantity = 10
            };

            var product2 = new Product
            {
                Name = "Tomatoes",
                Price = 4.0M,
                Quantity = 20
            };

            var product3 = new Product
            {
                Name = "Apple",
                Price = 1.50M,
                Quantity = 15
            };

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            return products;
        }
    }
}
