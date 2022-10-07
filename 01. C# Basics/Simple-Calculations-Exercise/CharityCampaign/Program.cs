using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int cook = int.Parse(Console.ReadLine());
            int numberOfCake = int.Parse(Console.ReadLine());
            int numberOfCorrugations = int.Parse(Console.ReadLine());
            int numberOfPancake = int.Parse(Console.ReadLine());
            double allSum = numberOfDays * cook * (numberOfCake * 45 + numberOfCorrugations * 5.80 + numberOfPancake * 3.20);
            double finalSum = allSum - allSum / 8;
            Console.WriteLine($"{finalSum:F2}");




        }
    }
}
