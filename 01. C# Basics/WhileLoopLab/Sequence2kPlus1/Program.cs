using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            int count = 1;
           
            while (count <= n)
            {
                Console.WriteLine(count);
                k = count;
                count = 2 * k + 1;
            }
        }
    }
}
