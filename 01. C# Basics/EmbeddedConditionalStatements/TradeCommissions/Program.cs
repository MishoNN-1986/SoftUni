using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double prices = double.Parse(Console.ReadLine());
            double commisson = 0.0;
            if (prices >= 0 && prices <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commisson = 0.05;
                        break;
                    case "Varna":
                        commisson = 0.045;
                        break;
                    case "Plovdiv":
                        commisson = 0.055;
                        break;
                }
            }
            else if (prices > 500 && prices <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commisson = 0.07;
                        break;
                    case "Varna":
                        commisson = 0.075;
                        break;
                    case "Plovdiv":
                        commisson = 0.08;
                        break;
                }
            }
            else if (prices > 1000 && prices <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commisson = 0.08;
                        break;
                    case "Varna":
                        commisson = 0.1;
                        break;
                    case "Plovdiv":
                        commisson = 0.12;
                        break;
                }
            }
            else if (prices > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commisson = 0.12;
                        break;
                    case "Varna":
                        commisson = 0.13;
                        break;
                    case "Plovdiv":
                        commisson = 0.145;
                        break;
                }
            }
            if (commisson == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                prices *= commisson;
                Console.WriteLine($"{prices:F2}");
            }
        }
    }
}
