using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = 0;
            if (num2 > 10)
            {
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
            }
            while (num2 <= 10)
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} X {num2} = {result}");
                num2++;
            }
        }
    }
}
