using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;
            double numPlusBonusPionts = 0.0;
            if (num <= 100)
            {
                bonusPoints += 5;
            }
            else if (num > 1000)
            {
                bonusPoints += 0.1 * num;
            }
            else
            {
                bonusPoints += 0.2 * num;
            }
            if (num % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (num % 10 == 5)
            {
                bonusPoints += 2;
            }
            numPlusBonusPionts = num + bonusPoints;

            Console.WriteLine(bonusPoints);
            Console.WriteLine(numPlusBonusPionts);
        }
    }
}
