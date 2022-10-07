using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secoundTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int allTimeInSeconds = firstTime + secoundTime + thirdTime;
            int allTimeInMinutes = allTimeInSeconds / 60;
            int secondTime = allTimeInSeconds % 60;
            if (secondTime < 10)
            {
                Console.WriteLine($"{allTimeInMinutes}:0{secondTime}");  // става и с {secondTime:D2}
            }
            else
            {
                Console.WriteLine($"{allTimeInMinutes}:{secondTime}");
            }
        }
    }
}
