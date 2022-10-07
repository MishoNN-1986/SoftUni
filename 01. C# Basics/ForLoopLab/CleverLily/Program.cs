using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceForWashingMachine = double.Parse(Console.ReadLine());
            int priceForOneToy = int.Parse(Console.ReadLine());
            int allMoney = 0;
            int allToys = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 1)
                {
                    allToys++;
                }
                else
                {
                    allMoney += 5 * i;
                    allMoney--;
                }
            }
            allMoney += allToys * priceForOneToy;
            double difference = Math.Abs(allMoney - priceForWashingMachine);
            if (allMoney >= priceForWashingMachine)
            {
                Console.WriteLine($"Yes! {difference:F2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:F2}");
            }
        }
    }
}
