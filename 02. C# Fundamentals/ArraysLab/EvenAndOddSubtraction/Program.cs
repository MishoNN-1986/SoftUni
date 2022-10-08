using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numbersToArray = numbers.Split();
            int[] intNumberToArray = new int[numbersToArray.LongLength];
            int evenSum = 0;
            int oddSum = 0;
            int diff = 0;
            for (int i = 0; i < intNumberToArray.Length; i++)
            {
                intNumberToArray[i] = int.Parse(numbersToArray[i]);
                if (intNumberToArray[i] % 2 == 0)
                {
                    evenSum += intNumberToArray[i];
                }
                else
                {
                    oddSum += intNumberToArray[i];
                }
            }
            diff = evenSum - oddSum;
            Console.WriteLine(diff);
        }
    }
}
