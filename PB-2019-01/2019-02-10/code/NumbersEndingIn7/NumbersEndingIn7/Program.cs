using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i); //всички числа които завършват на 7
                }
            }
        }
    }
}
