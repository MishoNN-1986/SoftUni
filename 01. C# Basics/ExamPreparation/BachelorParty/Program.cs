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
            int sumForGuest = int.Parse(Console.ReadLine());
            int allMoney = 0;
            int countPeople = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "The restaurant is full")
                {
                    if (allMoney >= sumForGuest)
                    {
                        int diff = allMoney - sumForGuest;
                        Console.WriteLine($"You have {countPeople} guests and {diff} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"You have {countPeople} guests and {allMoney} leva income, but no singer.");
                    }
                    break;
                }
                int sumPeople = int.Parse(command);
                countPeople += sumPeople;
                if (sumPeople < 5)
                {
                    allMoney += sumPeople * 100;
                }
                else
                {
                    allMoney += sumPeople * 70;
                }
            }
        }
    }
}
