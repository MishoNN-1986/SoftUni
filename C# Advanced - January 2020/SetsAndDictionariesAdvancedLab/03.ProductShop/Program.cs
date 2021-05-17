using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, double>> shopsWithProductsAndPrice = new SortedDictionary<string, Dictionary<string, double>>();
            while (input != "Revision")
            {
                string[] information = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = information[0];
                string product = information[1];
                double price = double.Parse(information[2]);
                if (!shopsWithProductsAndPrice.ContainsKey(shop))
                {
                    shopsWithProductsAndPrice.Add(shop, new Dictionary<string, double>());
                }
                if (!shopsWithProductsAndPrice[shop].ContainsKey(product))
                {
                    shopsWithProductsAndPrice[shop].Add(product, 0);
                }
                shopsWithProductsAndPrice[shop][product] = price;
                input = Console.ReadLine();
            }
            StringBuilder output = new StringBuilder();
            foreach (var shop in shopsWithProductsAndPrice.Keys)  //var (shop, product) in shopsWithProductsAndPrice.OrderBy(x=> x.Key)
            {
                output.Append($"{shop}->{Environment.NewLine}");
                foreach (var product in shopsWithProductsAndPrice[shop].Keys)
                {
                    output.Append($"Product: {product}, Price: {shopsWithProductsAndPrice[shop][product]} {Environment.NewLine}");
                }
            }
            Console.WriteLine(output);
        }
    }
}
