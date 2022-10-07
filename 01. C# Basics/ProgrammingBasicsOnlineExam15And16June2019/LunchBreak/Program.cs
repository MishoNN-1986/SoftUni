using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int timeSerial = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());
            double freeTime = breakTime * 1.0 - (breakTime / 8.0) - (breakTime / 4.0);
            if (freeTime >= timeSerial)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(freeTime - timeSerial)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeSerial - freeTime)} more minutes.");
            }
        }
    }
}
