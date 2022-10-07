using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTicket = 0;
            int studentTicket = 0;
            int standardTicket = 0;
            int kidTicket = 0;
            int allTicket = 0;
            int count = 0;
            while (true)
            {
                string nameMovie = Console.ReadLine();
                if (nameMovie == "Finish")
                {
                    break;
                }
                int freeSeats = int.Parse(Console.ReadLine());
                while (countTicket != freeSeats)
                {
                    string typeTicket = Console.ReadLine();
                    if (typeTicket == "End")
                    {
                        break;
                    }
                    else if (typeTicket == "student")
                    {
                        studentTicket++;
                    }
                    else if (typeTicket == "standard")
                    {
                        standardTicket++;
                    }
                    else if (typeTicket == "kid")
                    {
                        kidTicket++;
                    }
                    countTicket++;
                    allTicket++;
                    //freeSeats--;
                }
                Console.WriteLine($"{nameMovie} - {countTicket * 1.0 / freeSeats * 100.0:F2}% full.");
                countTicket = 0;
            }
            Console.WriteLine($"Total tickets: {allTicket}");
            Console.WriteLine($"{studentTicket * 1.0 / allTicket * 100.0:F2}% student tickets.");
            Console.WriteLine($"{standardTicket * 1.0 / allTicket * 100.0:F2}% standard tickets.");
            Console.WriteLine($"{kidTicket * 1.0 / allTicket * 100.0:F2}% kids tickets.");
        }
    }
}
