using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = ReadDouble();
            double secondNumber = ReadDouble();
            double result = DivideOfTwoNumbers(FactorialOfNumber(firstNumber), FactorialOfNumber(secondNumber));
            Console.WriteLine($"{result:F2}");
        }

        static double FactorialOfNumber(double number)
        {
            double result = 1;
            if (number == 0)
            {
                result = 0;
                return result;
            }
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static double DivideOfTwoNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }

        static double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
