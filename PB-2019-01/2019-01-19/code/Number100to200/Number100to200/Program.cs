using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number100to200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (100 <= num && num <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (200 < num)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
