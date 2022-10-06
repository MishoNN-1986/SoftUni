using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // read number frm console
            int number = int.Parse(Console.ReadLine());


            // chek if number is odd or even
            bool isNumberEven = number % 2 == 0;
            // print to console
            if (isNumberEven)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
