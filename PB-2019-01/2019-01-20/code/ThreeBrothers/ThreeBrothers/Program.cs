using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double fatherTimeFishing = double.Parse(Console.ReadLine());
            double allTimeCleaning = 1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime);
            double breakCleaning = allTimeCleaning * 0.15;
            allTimeCleaning = allTimeCleaning + breakCleaning;

            Console.WriteLine($"Cleaning time: {allTimeCleaning:F2}");

            if (fatherTimeFishing >= allTimeCleaning)
            {
                double timeleft = fatherTimeFishing - allTimeCleaning;  // moje i double timeleft = Math.Floor(fatherTimeFishing - allTimeCleaning);
                timeleft = Math.Floor(timeleft);
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeleft} hours.");
            }
            else
            {
                double timeleft = allTimeCleaning - fatherTimeFishing;
                timeleft = Math.Ceiling(timeleft);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeleft} hours.");
            }
        }
    }
}
