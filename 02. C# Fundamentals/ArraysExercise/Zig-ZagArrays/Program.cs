using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArray = new string[n];
            string[] secondArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] symbols = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    firstArray[i] = symbols[0];
                    secondArray[i] = symbols[1];
                }
                else
                {
                    firstArray[i] = symbols[1];
                    secondArray[i] = symbols[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
