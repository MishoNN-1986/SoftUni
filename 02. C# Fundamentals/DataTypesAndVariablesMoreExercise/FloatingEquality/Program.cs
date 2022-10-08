using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
           double equal = 0;
            if (firstNumber > secondNumber)
            {
                equal = Math.Abs(firstNumber - secondNumber);
            }
            else
            {
                equal = Math.Abs(secondNumber - firstNumber);
            }
            if (equal < 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
