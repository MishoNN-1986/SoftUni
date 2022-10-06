using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int numberHolidays = int.Parse(Console.ReadLine());
            int numberWeekendsToBornCity = int.Parse(Console.ReadLine());
            int weekendsInSofia = 48 - numberWeekendsToBornCity;
            double playWeekendsInSofia = weekendsInSofia * 3.0 / 4;
            int playWeekendsInBornCity = numberWeekendsToBornCity;
            double playGamesInHolidays = numberHolidays * 2.0 / 3;
            double sumPlayDays = playWeekendsInBornCity + playWeekendsInSofia + playGamesInHolidays;
            if (year == "leap")
            {
                sumPlayDays *= 1.15;
                sumPlayDays = Math.Floor(sumPlayDays);
                Console.WriteLine($"{sumPlayDays}");
            }
            else if (year == "normal")
            {
                sumPlayDays = Math.Floor(sumPlayDays);
                Console.WriteLine($"{sumPlayDays}");
            }
        }
    }
}

