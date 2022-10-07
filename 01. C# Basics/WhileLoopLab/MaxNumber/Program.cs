using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int biggestNum = int.MinValue;
            while (count <= n)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= biggestNum)
                {
                    biggestNum = num;
                }
                count++;
            }
            Console.WriteLine(biggestNum);
        }
    }
}
