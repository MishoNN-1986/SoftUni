using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                Console.WriteLine(sum);
                sum *= 4;
            }
        }
    }
}
