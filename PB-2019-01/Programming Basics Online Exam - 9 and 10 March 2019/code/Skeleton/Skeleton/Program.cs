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
            int minutesOfControl = int.Parse(Console.ReadLine());  // minuti na kontrolata
            int secondsOfControl = int.Parse(Console.ReadLine());  // sekundi na kontrolata
            double lengthOfTheChuteInMeters = double.Parse(Console.ReadLine());   // dyljina na uleq v metri
            int secondsTo100Meters = int.Parse(Console.ReadLine());  // sekundi za izminavane na 100 metra
            int allSecondsOfControl = minutesOfControl * 60 + secondsOfControl;  //

            double allTime = lengthOfTheChuteInMeters / 100 * secondsTo100Meters - ((lengthOfTheChuteInMeters * 1.0 / 120) * 2.5);
            if (allTime <= allSecondsOfControl)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {allTime:F3}.");

            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {(allTime - allSecondsOfControl):F3} second slower.");
            }
        }
    }
}
