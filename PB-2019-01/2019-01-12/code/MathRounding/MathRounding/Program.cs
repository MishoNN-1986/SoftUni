using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathRounding
{
    class Program
    {
        static void Main(string[] args)
        {
            double testNumber = 4.5678;
            Console.WriteLine(Math.Ceiling(testNumber)); // 5
            Console.WriteLine(Math.Floor(testNumber)); //4
            Console.WriteLine(Math.Round(testNumber, 2)); // 4.57
            Console.WriteLine($"{testNumber:F2}"); // 4.57
            Console.WriteLine("{0:F6}", testNumber); // 4.567800
        }
    }
}
