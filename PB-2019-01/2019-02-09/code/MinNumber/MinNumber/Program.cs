using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //брой числа
            int minNumber = int.MaxValue; // най-малкото число = maxvalue
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()); //въвеждам число
                if (num < minNumber) // проверявам дали числото е по-малко от най-малкото
                {
                    minNumber = num;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
