using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n >= 0)
            {
                if (n == 0)
                {
                    Console.WriteLine("ZERO");
                    break;
                }
                int lastNum = n % 10;
                if (lastNum == 0)
                {
                    Console.Write("ZERO");
                }
                else
                {
                    for (int i = 0; i < lastNum; i++)
                    {
                        Console.Write((char)(lastNum + 33));
                    }
                }
                    Console.WriteLine();
                    n = n - lastNum;
                
                if (n == 0)
                {
                    break;
                }
                while (n % 10 == 0)
                {
                    n = n / 10;
                    if (n % 10 == 0)
                    {
                        Console.Write("ZERO");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
