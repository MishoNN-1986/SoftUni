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
            int age = int.Parse(Console.ReadLine());                        //въвеждаме години
            double washingMachinePrice = double.Parse(Console.ReadLine());  //цена на пералната
            int onePriceToy = int.Parse(Console.ReadLine());                //цена на 1 играчка
            int counterToy = 0;                                             //брояч на играчки 
            double counterBirthdayMoney = 0.0;                              //брояч пари от рождени дни
            int brotherMoney = 0;                                           //пари на брата 
            double moneyOfToy = 0.0;                                        //пари от играчки
            double allMoney = 0;                                            //вскички пари 
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    counterBirthdayMoney += i / 2 * 10.0;
                    brotherMoney++;
                }
                else
                {
                    counterToy++;
                }
            }
            moneyOfToy = counterToy * 1.0 * onePriceToy;
            allMoney = allMoney + moneyOfToy - brotherMoney + counterBirthdayMoney;
            if (allMoney >= washingMachinePrice)
            {
                double diff = allMoney - washingMachinePrice;
                Console.WriteLine($"Yes! {diff:F2}");
            }
            else
            {
                double diff = washingMachinePrice - allMoney;
                Console.WriteLine($"No! {diff:F2}");
            }
        }
    }
}
