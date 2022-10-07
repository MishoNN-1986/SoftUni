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
            int count = 0;
            while (count < 10000)
            {
                string comand = Console.ReadLine();
                if (comand == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    count += lastSteps;
                    if (count < 10000)
                    {
                        int neededSteps = 10000 - count;
                        Console.WriteLine($"{neededSteps} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                }
                count += int.Parse(comand);
                if (count >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
            }
        }
    }
}
