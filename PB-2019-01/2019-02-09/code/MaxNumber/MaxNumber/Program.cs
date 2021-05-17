using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //брой числа
            int biggerNumber = int.MinValue; // най-голямото число = minvalue
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()); //въвеждам число
                if (num > biggerNumber)
                {
                    biggerNumber = num;
                }
            }
            Console.WriteLine(biggerNumber);
        }
    }
}
