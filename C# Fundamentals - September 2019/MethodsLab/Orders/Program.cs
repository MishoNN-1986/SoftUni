using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            totalPrice(product, quantity);
        }
        static void totalPrice(string product, double quantity)
        {
            double price = 0.0;
            switch (product)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1.0;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2.0;
                    break;
            }
            double allPrice = price * quantity;
            Console.WriteLine($"{allPrice:F2}");
        }
    }
}
