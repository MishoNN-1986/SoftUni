using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumCustomer = int.Parse(Console.ReadLine());
            double price = 0;
            int count = 0;
            double allPrice = 0;
            for (int i = 0; i < sumCustomer; i++)
            {
                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "Finish")
                    {
                        if (count % 2 == 0)
                        {
                            price *= 0.8;
                        }
                        Console.WriteLine($"You purchased {count} items for {price:F2} leva.");
                        allPrice += price;
                        count = 0;
                        price = 0;
                        break;
                    }
                    string buy = command;
                    switch (buy)
                    {
                        case "basket":
                            price += 1.5;
                            break;
                        case "wreath":
                            price += 3.8;
                            break;
                        case "chocolate bunny":
                            price += 7.0;
                            break;
                    }
                    count++;
                }
            }
            Console.WriteLine($"Average bill per client is: {allPrice / sumCustomer * 1.0:F2} leva.");
        }
    }
}
