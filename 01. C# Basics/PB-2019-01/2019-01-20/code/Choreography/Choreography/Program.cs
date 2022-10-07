using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSteps = int.Parse(Console.ReadLine());
            int numberOfDancer = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());
            double allPercentStepsOfDay = Math.Ceiling(((numberOfSteps * 1.0 / numberOfDays) / numberOfSteps) * 100.0);  //100.0  i *1.0 zashtoto vsichki sa int i nqma smi ot ceiling
            double percentStepsOfDancer = (allPercentStepsOfDay / numberOfDancer);
            if (allPercentStepsOfDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentStepsOfDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {percentStepsOfDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
