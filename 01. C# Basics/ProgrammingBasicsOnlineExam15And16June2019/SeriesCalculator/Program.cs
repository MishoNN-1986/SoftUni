using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int sumSeasons = int.Parse(Console.ReadLine());
            int sumEpisodes = int.Parse(Console.ReadLine());
            double minutesForOneEpisod = double.Parse(Console.ReadLine());
            double allTime = sumSeasons * 10.0 + sumSeasons * 1.0 * sumEpisodes * minutesForOneEpisod * 1.2;
            Console.WriteLine($"Total time needed to watch the {nameSerial} series is {Math.Floor(allTime)} minutes.");
        }
    }
}
