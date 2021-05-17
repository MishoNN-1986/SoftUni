using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            int sum = 1;
            int allSum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = int.Parse(num[i].ToString()); j > 0; j--)
                {
                    sum *= j;
                }
                allSum += sum;
                sum = 1;
            }
            if (allSum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
