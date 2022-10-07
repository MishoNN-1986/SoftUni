using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typePlace = "";
            string destination = "";
            double neededMoney = 0.0;
            switch (season)
            {
                case "summer":
                    typePlace = "Camp";
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        neededMoney = budget * 0.3;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        neededMoney = budget * 0.4;
                    }
                    else
                    {
                        typePlace = "Hotel";
                        destination = "Europe";
                        neededMoney = budget * 0.9;
                    }
                    break;

                case "winter":
                    typePlace = "Hotel";
                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        neededMoney = budget * 0.7;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        destination = "Balkans";
                        neededMoney = budget * 0.8;
                    }
                    else
                    {
                        destination = "Europe";
                        neededMoney = budget * 0.9;
                    }
                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typePlace} - {neededMoney:F2}");
        }
    }
}
