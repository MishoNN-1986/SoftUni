using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int sumDays = int.Parse(Console.ReadLine());
            double price = 0;
            switch (destination)
            {
                case "Dubai":
                    switch (season)
                    {
                        case "Winter":
                            price = 45000;
                            break;
                        case "Summer":
                            price = 40000;
                            break;
                    }
                    break;
                case "Sofia":
                    switch (season)
                    {
                        case "Winter":
                            price = 17000;
                            break;
                        case "Summer":
                            price = 12500;
                            break;
                    }
                    break;
                case "London":
                    switch (season)
                    {
                        case "Winter":
                            price = 24000;
                            break;
                        case "Summer":
                            price = 20250;
                            break;
                    }
                    break;
            }
            if (destination == "Dubai")
            {
                price *= 0.7;
            }
            else if (destination == "Sofia")
            {
                price *= 1.25;
            }
            double allPrice = price * sumDays * 1.0;
            if (buget >= allPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {buget - allPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {allPrice - buget:F2} leva more!");
            }
        }
    }
}
