using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeForOneMonth = double.Parse(Console.ReadLine());
            int sumMonths = int.Parse(Console.ReadLine());
            double needMoney = double.Parse(Console.ReadLine());
            double savedMoney = incomeForOneMonth * sumMonths * 0.7 - (sumMonths * needMoney);
            Console.WriteLine($"She can save {savedMoney / (incomeForOneMonth * sumMonths) * 100.0:F2}%");
            Console.WriteLine($"{savedMoney:F2}");
        }
    }
}
