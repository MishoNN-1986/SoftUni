using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumVoucher = int.Parse(Console.ReadLine());
            string buy = Console.ReadLine();
            int countSum = 0;
            int countTickets = 0;
            int countOther = 0;
            while (buy != "End")
            {
                if (buy.Length > 8)
                {
                    countSum += (int)buy[0] + (int)buy[1];
                    if (countSum > sumVoucher)
                    {
                        break;
                    }
                    countTickets++;
                }
                else
                {
                    countSum += (int)buy[0];
                    if (countSum > sumVoucher)
                    {
                        break;
                    }
                    countOther++;
                }
                buy = Console.ReadLine();
            }
            Console.WriteLine($"{countTickets}");
            Console.WriteLine($"{countOther}");
        }
    }
}
