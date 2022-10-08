using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            int lastDigit = int.Parse(num[num.Length - 1].ToString());
            var lastDigitWord = "";
            if (lastDigit == 1)
            {
                lastDigitWord = "one";
            }
            else if (lastDigit == 2)
            {
                lastDigitWord = "two";
            }
            else if (lastDigit == 3)
            {
                lastDigitWord = "three";
            }
            else if (lastDigit == 4)
            {
                lastDigitWord = "four";
            }
            else if (lastDigit == 5)
            {
                lastDigitWord = "five";
            }
            else if (lastDigit == 6)
            {
                lastDigitWord = "six";
            }
            else if (lastDigit == 7)
            {
                lastDigitWord = "seven";
            }
            else if (lastDigit == 8)
            {
                lastDigitWord = "eight";
            }
            else if (lastDigit == 9)
            {
                lastDigitWord = "nine";
            }
            else if (lastDigit == 0)
            {
                lastDigitWord = "zero";
            }
            Console.WriteLine(lastDigitWord);
        }
    }
}
