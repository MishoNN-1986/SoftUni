using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            double numberOfCoins = 0.0;
            double a = 0.01;
            double b = 0.02;
            double c = 0.05;
            double d = 0.1;
            double e = 0.2;
            double f = 0.5;
            double g = 1.0;
            double h = 2.0;          
            double residue = 1.0;
            while (residue > 0.0)
            {
                residue = sum;
                if (residue >= 2.0)
                {
                    numberOfCoins = Math.Floor(sum / h);            // broi moneti  
                    residue = sum % h;                 //kolko ostawa da se dade                   
                }
                if (residue >= 1.0)
                {
                    numberOfCoins += Math.Floor(residue / g);
                    residue %= g;
                }
                if (residue >= 0.5)
                {
                    numberOfCoins += Math.Floor(residue / f);
                    residue = Math.Round(residue % f, 2);
                }
                if (residue >= 0.2)
                {
                    numberOfCoins += Math.Floor(residue / e);
                    residue = Math.Round(residue % e, 2);

                }
                if (residue >= 0.1)
                {
                    numberOfCoins += Math.Floor(residue / d);
                    residue = Math.Round(residue % d, 2);
                }
                if (residue >= 0.05)
                {
                    numberOfCoins += Math.Floor(residue / c);
                    residue = Math.Round(residue % c, 2);
                }
                if (residue >= 0.02)
                {
                    numberOfCoins += Math.Floor(residue / b);
                    residue = Math.Round(residue % b, 2);

                }
                if (residue >= 0.01)
                {
                    numberOfCoins += Math.Floor(residue / a);
                    residue = Math.Round(residue % a, 2);
                }
            }
            if (residue <= 0.0)
            {
                Console.WriteLine($"{numberOfCoins}");
            }
        }
    }
}
