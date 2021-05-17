using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            // keep all steps in variable -> sum
            int stepsSum = 0;
            int stepsTarget = 10000;

            // infinite loop
            while (true)
            {
                // if get "Going home"
                // read just one more line of steps
                // add to sum
                // print -> 1 or 2
                string input = Console.ReadLine(); // number || Going home
                if (input == "Going home")
                {
                    int laststeps = int.Parse(Console.ReadLine()); //steps to home
                    stepsSum += laststeps;
                    if (stepsSum >= stepsTarget)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    else
                    {
                        int stepsLeft = stepsTarget - stepsSum;
                        Console.WriteLine($"{stepsLeft} more steps to reach goal.");
                        break;
                    }
                }
                // we get number
                //take steps from console
                //add steps to sum
                //if sum >= stepsTarget => exit loop => print 1
                int currentSteps = int.Parse(input);
                stepsSum += currentSteps;
                if(stepsSum>= stepsTarget)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                
            }
        }
    }
}
