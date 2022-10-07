using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();
            double allSum = 0;
            double neededProcent = 0;
            //neededProcent = (20.0 - allSum) / 20.0 * 100.0;
            switch (country)
            {
                case "Russia":
                    switch (instrument)
                    {
                        case "ribbon":
                            allSum = 18.5;
                            break;
                        case "hoop":
                            allSum = 19.1;
                            break;
                        case "rope":
                            allSum = 18.6;
                            break;
                    }
                    break;
                case "Bulgaria":
                    switch (instrument)
                    {
                        case "ribbon":
                            allSum = 19.0;
                            break;
                        case "hoop":
                            allSum = 19.3;
                            break;
                        case "rope":
                            allSum = 18.9;
                            break;
                    }
                    break;
                case "Italy":
                    switch (instrument)
                    {
                        case "ribbon":
                            allSum = 18.7;
                            break;
                        case "hoop":
                            allSum = 18.8;
                            break;
                        case "rope":
                            allSum = 18.85;
                            break;
                    }
                    break;
            }
            neededProcent = (20.0 - allSum) / 20.0 * 100.0;
            Console.WriteLine($"The team of {country} get {allSum:F3} on {instrument}.");
            Console.WriteLine($"{neededProcent:F2}%");
        }
    }
}
