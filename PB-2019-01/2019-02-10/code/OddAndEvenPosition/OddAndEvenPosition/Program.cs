using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());   //брой числа
            double oddSum = 0.0;                     // сумата от числата на нечетни позиции
            double oddMin = double.MaxValue;         // минималното число от нечетните позиции   
            double oddMax = double.MinValue;         //максималното число от нечетните позиции
            double evenSum = 0.0;                    //симата от четните позиции
            double evenMin = double.MaxValue;        //минималното число от четните позиции
            double evenMax = double.MinValue;        // максималното число от четните позиции 
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            Console.WriteLine($"EvenSum={evenSum:F2},");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        }
    }
}
