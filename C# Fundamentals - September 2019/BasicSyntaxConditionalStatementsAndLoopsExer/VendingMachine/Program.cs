using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double allSum = 0;
            double priceForOneProduct = 0;
            double allPrice = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Start")
                {
                    while (true)
                    {
                        string product = Console.ReadLine();
                        if (product == "End")
                        {
                            Console.WriteLine($"Change: {allSum - allPrice:F2}");
                            return;
                        }
                        switch (product)
                        {
                            case "Nuts":
                                priceForOneProduct = 2.0;
                                break;
                            case "Water":
                                priceForOneProduct = 0.7;
                                break;
                            case "Crisps":
                                priceForOneProduct = 1.5;
                                break;
                            case "Soda":
                                priceForOneProduct = 0.8;
                                break;
                            case "Coke":
                                priceForOneProduct = 1.0;
                                break;
                            default:
                                Console.WriteLine("Invalid product");
                                break;
                        }
                        if (priceForOneProduct + allPrice > allSum)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            continue;
                        }
                        else
                        {
                            if (product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke")
                            {
                                Console.WriteLine($"Purchased {product.ToLower()}");
                                allPrice += priceForOneProduct;
                            }
                        }
                    }
                }
                double coin = double.Parse(command);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2.0)
                {
                    allSum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }
        }
    }
}
