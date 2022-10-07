using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForPicture = int.Parse(Console.ReadLine());
            int sumScenes = int.Parse(Console.ReadLine());
            int timeForOneScene = int.Parse(Console.ReadLine());
            double freeTime = timeForPicture * 0.85;
            int needTime = sumScenes * timeForOneScene;
            if (freeTime >= needTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(freeTime - needTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(needTime - freeTime)} minutes.");
            }
        }
    }
}
