using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Read USD
            double usd = double.Parse(Console.ReadLine());
            //2. Calculate BGN -> USD * course
            double bgn = usd * 1.79549;
            //3. Print
            Console.WriteLine($"{bgn:F2}");
        }
    }
}
