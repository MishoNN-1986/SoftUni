using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDeposits = int.Parse(Console.ReadLine());
            double sumMoney = 0;
            int count = 1;
            while (count <= numberOfDeposits)
            {
                double money = double.Parse(Console.ReadLine());
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {money:F2}");
                sumMoney += money;
                count++;
            }
            Console.WriteLine($"Total: {sumMoney:F2}");
        }
    }
}
