using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());  //sumata za gost izpylnitelq
            int countMoney = 0;
            int counterPeaple = 0;
            int numberPeapleInGroup = 0;
            string command = Console.ReadLine();
            while (true)
            {
                if (command == "The restaurant is full" && countMoney >= sum)
                {
                    Console.WriteLine($"You have {counterPeaple} guests and {countMoney - sum} leva left.");
                    break;
                }
                else if (command == "The restaurant is full" && countMoney < sum)
                {
                    Console.WriteLine($"You have {counterPeaple} guests and {countMoney} leva income, but no singer.");
                    break;
                }
                else
                {
                    numberPeapleInGroup = int.Parse(command);
                    command = Console.ReadLine();
                    if (numberPeapleInGroup < 5)
                    {
                        countMoney += numberPeapleInGroup * 100;
                        counterPeaple += numberPeapleInGroup;
                    }
                    else if (numberPeapleInGroup >= 5)
                    {
                        countMoney += numberPeapleInGroup * 70;
                        counterPeaple += numberPeapleInGroup;
                    }
                }

            }
        }
    }
}
