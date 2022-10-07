using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (true)
            {
                int count = 0;
                string comand = Console.ReadLine();
                if (comand == "stop")
                {
                    break;
                }
                int num = int.Parse(comand);
                //if (num == 1)
                //{
                //    primeSum++;
                //}
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i <= num; i++) // 0 и 1 не са нито прости нито непрости числа!
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    nonPrimeSum += num;
                    continue;
                }
                if (count == 1)
                {
                    primeSum += num;
                }


            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
