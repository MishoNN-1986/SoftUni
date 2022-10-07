using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            while (num1 < num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    string num = $"{num1}";
                    int oddSum = num[0] + num[2] + num[4];
                    int evenSum = num[1] + num[3] + num[5];
                    if (oddSum == evenSum)
                    {
                        Console.Write($"{num} ");
                    }
                    num1++;
                }
            }
        }
    }
}
