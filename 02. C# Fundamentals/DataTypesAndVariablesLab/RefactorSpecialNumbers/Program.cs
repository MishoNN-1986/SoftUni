using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int leftNum = 0;
            bool specialNumber = false;
            for (int n = 1; n <= quantityNumbers; n++)
            {
                leftNum = n;
                while (n > 0)
                {
                    sumOfDigits += n % 10;
                    n = n / 10;
                }
                specialNumber = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", leftNum, specialNumber);
                sumOfDigits = 0;
                n = leftNum;
            }
        }
    }
}
