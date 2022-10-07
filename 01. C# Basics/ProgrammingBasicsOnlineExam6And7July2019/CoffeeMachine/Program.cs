using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string typeSugar = Console.ReadLine();
            int sumDrinks = int.Parse(Console.ReadLine());
            double priceForOneDrink = 0;
            double allPrice = 0;
            switch (drink)
            {
                case "Espresso":
                    switch (typeSugar)
                    {
                        case "Without":
                            priceForOneDrink = 0.9;
                            break;
                        case "Normal":
                            priceForOneDrink = 1.0;
                            break;
                        case "Extra":
                            priceForOneDrink = 1.2;
                            break;
                    }
                    break;
                case "Cappuccino":
                    switch (typeSugar)
                    {
                        case "Without":
                            priceForOneDrink = 1.0;
                            break;
                        case "Normal":
                            priceForOneDrink = 1.2;
                            break;
                        case "Extra":
                            priceForOneDrink = 1.6;
                            break;
                    }
                    break;
                case "Tea":
                    switch (typeSugar)
                    {
                        case "Without":
                            priceForOneDrink = 0.5;
                            break;
                        case "Normal":
                            priceForOneDrink = 0.6;
                            break;
                        case "Extra":
                            priceForOneDrink = 0.7;
                            break;
                    }
                    break;
            }
            allPrice = priceForOneDrink * sumDrinks;
            if (typeSugar == "Without")
            {
                allPrice *= 0.65;
            }
            if (drink == "Espresso" && sumDrinks >= 5)
            {
                allPrice *= 0.75;
            }
            if (allPrice > 15.0)
            {
                allPrice *= 0.8;
            }
            Console.WriteLine($"You bought {sumDrinks} cups of {drink} for {allPrice:F2} lv.");
        }
    }
}
