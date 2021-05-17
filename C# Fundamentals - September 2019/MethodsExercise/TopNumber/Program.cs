using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetTopNumbersToGivenNumber(number);
        }

        static void GetTopNumbersToGivenNumber(int number)
        {
            int sum = 0;
            string stringSum = string.Empty;
            bool odd = false;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    int digit = int.Parse(i.ToString()[j].ToString());
                    sum += digit;
                    stringSum += "" + digit;
                    if (digit % 2 == 1)
                    {
                        odd = true;
                    }
                }
                if (sum % 8 == 0 && odd)
                {
                    Console.WriteLine($"{int.Parse(stringSum)}");
                }
                odd = false;
                sum = 0;
                stringSum = string.Empty;
            }
        }
    }
}
