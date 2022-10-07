using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //брой числа
            int sumOfEvenNumber = 0; //сумата на четните позиций
            int sumOfOddNumber = 0; // сумата на нечетните позиций
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine()); //въвежда се число
                if (i % 2 == 0)
                {
                    sumOfEvenNumber += number;
                }
                else
                {
                    sumOfOddNumber += number;
                }
            }

            if (sumOfOddNumber == sumOfEvenNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOfEvenNumber}");
            }
            else
            {
                int diff = Math.Abs(sumOfOddNumber - sumOfEvenNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }

    }
}
