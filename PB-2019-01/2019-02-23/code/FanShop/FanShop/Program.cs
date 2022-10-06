using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int numberSubject = int.Parse(Console.ReadLine());
            int countSum = 0;
            int sum = 0;
            int price = 0;
            for (int i = 0; i < numberSubject; i++)
            {

                string subject = Console.ReadLine();

                switch (subject)
                {
                    case "hoodie":
                        price = 30;
                        break;
                    case "keychain":
                        price = 4;
                        break;
                    case "T-shirt":
                        price = 20;
                        break;
                    case "flag":
                        price = 15;
                        break;
                    case "sticker":
                        price = 1;
                        break;

                }

                sum = price;
                countSum += sum;
            }
            if (budget >= countSum)
            {
                int leftMoney = budget - countSum;
                Console.WriteLine($"You bought {numberSubject} items and left with {leftMoney} lv.");
            }
            else
            {
                int needMoney = countSum - budget;
                Console.WriteLine($"Not enough money, you need {needMoney} more lv.");
            }

        }
    }
}
