using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfLines = int.Parse(Console.ReadLine());
            int countOpen = 0;
            int countClose = 0;
            bool firsSymbol = false;
            bool endSymbol = false;
            int finalCountOpen = 0;
            for (int i = 0; i < numbersOfLines; i++)
            {
                string symbol = Console.ReadLine();
                if (symbol == "(")
                {
                    countOpen++;
                }
                else if (symbol == ")")
                {
                    countClose++;
                }
                if (countOpen == 1 && countClose == 0)
                {
                    firsSymbol = true;
                }
                if (countClose + 1 == countOpen)
                {
                    endSymbol = true;
                    finalCountOpen = countOpen;
                }
            }
            if (countClose == countOpen && firsSymbol && endSymbol && finalCountOpen == countOpen)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
