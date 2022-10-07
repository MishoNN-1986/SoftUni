using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int sumSerials = int.Parse(Console.ReadLine());
            double allSum = 0;
            for (int i = 0; i < sumSerials; i++)
            {
                string nameSerial = Console.ReadLine();
                double priceSerial = double.Parse(Console.ReadLine());
                switch (nameSerial)
                {
                    case "Thrones":
                        priceSerial *= 0.5;
                        break;
                    case "Lucifer":
                        priceSerial *= 0.6;
                        break;
                    case "Protector":
                        priceSerial *= 0.7;
                        break;
                    case "TotalDrama":
                        priceSerial *= 0.8;
                        break;
                    case "Area":
                        priceSerial *= 0.9;
                        break;
                }
                allSum += priceSerial;
            }
            if (buget >= allSum)
            {
                Console.WriteLine($"You bought all the series and left with {buget - allSum:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {allSum - buget:F2} lv. more to buy the series!");
            }
        }
    }
}
