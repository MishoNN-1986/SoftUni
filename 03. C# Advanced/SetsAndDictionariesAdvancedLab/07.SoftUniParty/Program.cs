using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reservationNumbers = new HashSet<string>();
            string number = Console.ReadLine();
            while (number != "PARTY")
            {
                reservationNumbers.Add(number);
                number = Console.ReadLine();
            }
            number = Console.ReadLine();
            while (number != "END")
            {
                reservationNumbers.Remove(number);
                number = Console.ReadLine();
            }
            Console.WriteLine(reservationNumbers.Count);
            foreach (var reservationNumber in reservationNumbers)
            {
                char symbol = reservationNumber[0];
                if (char.IsDigit(symbol))
                {
                    Console.WriteLine(reservationNumber);
                }
            }
            foreach (var reservationNumber in reservationNumbers)
            {
                char symbol = reservationNumber[0];
                if (!char.IsDigit(symbol))
                {
                    Console.WriteLine(reservationNumber);
                }
            }
        }
    }
}
