using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecordInSecunds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeterInSecunds = double.Parse(Console.ReadLine());

            double numOfDelays = Math.Floor(distance / 15);
            double waterDelay = numOfDelays * 12.50;
            double allTime = distance * timeForOneMeterInSecunds + waterDelay;

            if (allTime < worldRecordInSecunds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {allTime:F2} seconds.");
            }
            else
            {
                double needSeconds = allTime - worldRecordInSecunds;
                Console.WriteLine($"No, he failed! He was {needSeconds:F2} seconds slower.");
            }
        }
    }
}
