using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // read two numbers from console
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // compare the numbers
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

            // write the console bigger number
        }
    }
}
