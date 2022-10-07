using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumTickets = int.Parse(Console.ReadLine());
            for (int i = 0; i < sumTickets; i++)
            {
                string ticketNumber = Console.ReadLine();
                if (ticketNumber.Length == 4)
                {
                    if ((int)ticketNumber[0] >= 65 && (int)ticketNumber[0] <= 90)
                    {
                        Console.WriteLine($"Seat decoded: {ticketNumber[0]}{ticketNumber[1]}{ticketNumber[2]}");
                    }
                    else
                    {
                        Console.WriteLine($"Seat decoded: {ticketNumber[3]}{ticketNumber[1]}{ticketNumber[2]}");
                    }
                }
                else if (ticketNumber.Length == 5 || ticketNumber.Length == 6)
                {
                    Console.WriteLine($"Seat decoded: {ticketNumber[0]}{(int)ticketNumber[1]}");
                }
            }
        }
    }
}
