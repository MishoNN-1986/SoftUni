using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string destinacion = Console.ReadLine();
                if (destinacion == "End")
                {
                    break;
                }
                double NeedMoney = double.Parse(Console.ReadLine());
                double saveMoney = 0;
                while (saveMoney < NeedMoney)
                {
                    double money = double.Parse(Console.ReadLine());
                    saveMoney += money;
                }
                Console.WriteLine($"Going to {destinacion}!");
            }
        }
    }
}
