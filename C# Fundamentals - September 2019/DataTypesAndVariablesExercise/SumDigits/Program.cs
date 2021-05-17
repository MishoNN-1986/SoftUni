using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberToString = number.ToString();
            int sum = 0;
            for (int i = 0; i < numberToString.Length; i++)
            {
                sum += int.Parse(numberToString[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
