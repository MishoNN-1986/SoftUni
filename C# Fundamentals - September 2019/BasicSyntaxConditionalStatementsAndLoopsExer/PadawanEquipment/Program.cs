using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());
            double allPriceOfLightsabers = (Math.Ceiling(countOfStudents * 1.1)) * priceOfLightsabers;
            double allPriceOfBelts = 0.0;
            if (countOfStudents >= 6)
            {
                allPriceOfBelts = ((countOfStudents * 1.0 - (countOfStudents / 6)) * priceOfBelts * 1.0);
            }
            else
            {
                allPriceOfBelts = countOfStudents * 1.0 * priceOfBelts;
            }
            double allSum = allPriceOfLightsabers + allPriceOfBelts + (priceOfRobes * countOfStudents);
            if (amountOfMoney >= allSum)
            {
                Console.WriteLine($"The money is enough - it would cost {allSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(allSum - amountOfMoney):F2}lv more.");
            }
        }
    }
}
