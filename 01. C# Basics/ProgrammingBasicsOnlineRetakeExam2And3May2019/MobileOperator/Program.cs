using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string termContract = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int sumMonths = int.Parse(Console.ReadLine());
            double priceForOneMonth = 0;
            switch (termContract)
            {
                case "one":
                    switch (typeContract)
                    {
                        case "Small":
                            priceForOneMonth = 9.98;
                            break;
                        case "Middle":
                            priceForOneMonth = 18.99;
                            break;
                        case "Large":
                            priceForOneMonth = 25.98;
                            break;
                        case "ExtraLarge":
                            priceForOneMonth = 35.99;
                            break;
                    }
                    break;
                case "two":
                    switch (typeContract)
                    {
                        case "Small":
                            priceForOneMonth = 8.58;
                            break;
                        case "Middle":
                            priceForOneMonth = 17.09;
                            break;
                        case "Large":
                            priceForOneMonth = 23.59;
                            break;
                        case "ExtraLarge":
                            priceForOneMonth = 31.79;
                            break;
                    }
                    break;
            }
            if (mobileInternet == "yes")
            {
                if (priceForOneMonth <= 10)
                {
                    priceForOneMonth += 5.5;
                }
                else if (priceForOneMonth > 10 && priceForOneMonth <= 30)
                {
                    priceForOneMonth += 4.35;
                }
                else if (priceForOneMonth > 30)
                {
                    priceForOneMonth += 3.85;
                }
            }
            if (termContract == "two")
            {
                priceForOneMonth *= 0.9625;
            }
            double allPrice = sumMonths * priceForOneMonth;
            Console.WriteLine($"{allPrice:F2} lv.");
        }
    }
}
