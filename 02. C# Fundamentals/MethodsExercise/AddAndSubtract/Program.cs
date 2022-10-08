using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = ReadDouble();
            double secondNumber = ReadDouble();
            double thirdNumber = ReadDouble();

            double sum = Sum(firstNumber, secondNumber);
            double result = Subtract(sum, thirdNumber);
            Console.WriteLine(result);
        }

        static double Sum(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        static double Subtract(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }

        static double ReadDouble()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
