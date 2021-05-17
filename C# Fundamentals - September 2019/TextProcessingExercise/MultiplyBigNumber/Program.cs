using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNum = int.Parse(Console.ReadLine());
            string firstNumString = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiply(firstNumString, secondNum));
        }

        static string Multiply(string bigNumber, int number)
        {
            if (bigNumber == "0" || number == 0)
            {
                return "0";
            }

            int add = 0;
            var result = new StringBuilder();
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int firstNumberDigit = int.Parse(bigNumber[i].ToString());
                int sum = (firstNumberDigit * number) + add;

                if (i == 0)
                {
                    result.Insert(0, sum);
                }
                else
                {
                    result.Insert(0, sum % 10);
                    add = sum / 10;
                }
            }

            return result.ToString().TrimStart('0');
        }
    }
}
