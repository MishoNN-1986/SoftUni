using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double wordRecordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsForOneMeter = double.Parse(Console.ReadLine());
            double numberOfDelay = Math.Floor(distanceInMeters / 15);
            double timeDelay = numberOfDelay * 12.5;
            double allTimeInSeconds = distanceInMeters * timeInSecondsForOneMeter + timeDelay;
            if (allTimeInSeconds < wordRecordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {allTimeInSeconds:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {allTimeInSeconds - wordRecordInSeconds:F2} seconds slower.");
            }
        }
    }
}
