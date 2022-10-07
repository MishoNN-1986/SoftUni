using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesControl = int.Parse(Console.ReadLine());
            int secondsControl = int.Parse(Console.ReadLine());
            double lengthInMeters = double.Parse(Console.ReadLine());
            int secondsFor100Meters = int.Parse(Console.ReadLine());

            int timeControlInSeconds = minutesControl * 60 + secondsControl;
            double timeForLength = (lengthInMeters / 100) * secondsFor100Meters - (lengthInMeters / 120 * 2.5);
            if (timeForLength <= timeControlInSeconds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeForLength:F3}.");
            }
            else
            {
                double diff = timeForLength - timeControlInSeconds;
                Console.WriteLine($"No, Marin failed! He was {diff:F3} second slower.");
            }
        }
    }
}
