using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int count = 0;
            sum = Math.Floor(sum * 100);
            while (sum > 0)
            {
                if (sum >= 200)
                {
                    sum -= 200;
                    count++;
                }
                else if (sum >= 100)
                {
                    sum -= 100;
                    count++;
                }
                else if (sum >= 50)
                {
                    sum -= 50;
                    count++;
                }
                else if (sum >= 20)
                {
                    sum -= 20;
                    count++;
                }
                else if (sum >= 10)
                {
                    sum -= 10;
                    count++;
                }
                else if (sum >= 5)
                {
                    sum -= 5;
                    count++;
                }
                else if (sum >= 2)
                {
                    sum -= 2;
                    count++;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}