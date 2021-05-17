using System;
using System.Collections.Generic;
using System.Linq;
namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            while (input[0] != "buy")
            {
                string productName = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);
                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new List<double> { price, quantity });
                }
                else
                {
                    var list = products[productName];
                    list[0] = price;
                    list[1] += quantity;
                }

                input = Console.ReadLine().Split();
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:F2}");
            }
        }
    }
}
