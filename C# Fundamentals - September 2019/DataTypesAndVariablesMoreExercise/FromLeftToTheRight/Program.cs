using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityNumbers = int.Parse(Console.ReadLine());
            string firstNumber = "";
            string secondNumber = "";
            long firstNumberToInt = 0;
            long secondNumberToInt = 0;
            long sumOfDigits = 0;
            bool space = false;
            for (int i = 0; i < quantityNumbers; i++)
            {
                string numbers = Console.ReadLine();
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (space)
                    {
                        secondNumber += numbers[j];
                        continue;
                    }
                    if (char.Parse(numbers[j].ToString()) == ' ')
                    {
                        space = true;
                        continue;
                    }
                    firstNumber += numbers[j];
                }
                firstNumberToInt = long.Parse(firstNumber);
                secondNumberToInt = long.Parse(secondNumber);
                if (firstNumberToInt > secondNumberToInt)
                {
                    for (int k = 0; k < firstNumber.Length; k++)
                    {
                        if (firstNumber[k].ToString() == "-")
                        {
                            continue;
                        }
                        sumOfDigits += long.Parse(firstNumber[k].ToString());
                    }
                }
                else
                {
                    for (int l = 0; l < secondNumber.Length; l++)
                    {
                        if (secondNumber[l].ToString() == "-")
                        {
                            continue;
                        }
                        sumOfDigits += long.Parse(secondNumber[l].ToString());
                    }
                }
                Console.WriteLine($"{Math.Abs(sumOfDigits)}");
                sumOfDigits = 0;
                firstNumber = "";
                secondNumber = "";
                space = false;
            }
        }
    }
}
