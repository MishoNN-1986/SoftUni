using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int countNum = 0;
            int prize = 0;
            for (int firstSymbol = 'B'; firstSymbol <= 'L'; firstSymbol += 2)    // za da go polzwzme kato simvol trqbva da e char vmesto int
            {
                for (int secondSymbol = 'f'; secondSymbol >= 'a'; secondSymbol--)
                {
                    for (int thirdSymbol = 'A'; thirdSymbol <= 'C'; thirdSymbol++)
                    {
                        for (int fourthSymbol = 1; fourthSymbol <= 10; fourthSymbol++)
                        {
                            for (int fifthSymbol = 10; fifthSymbol >= 1; fifthSymbol--)
                            {
                                countNum++;
                                if (countNum == num)
                                {
                                    prize = firstSymbol + secondSymbol + thirdSymbol + fourthSymbol + fifthSymbol;


                                    Console.WriteLine($"Ticket combination: {(char)firstSymbol}{(char)secondSymbol}{(char)thirdSymbol}{fourthSymbol}{fifthSymbol}");
                                    Console.WriteLine($"Prize: {prize} lv.");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
