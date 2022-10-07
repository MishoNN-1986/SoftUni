using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int sumDays = int.Parse(Console.ReadLine());
            int sumTickets = int.Parse(Console.ReadLine());
            double priceForOneTicket = double.Parse(Console.ReadLine());
            int percentForCinema = int.Parse(Console.ReadLine());
            double allSum = sumDays * 1.0 * sumTickets * priceForOneTicket * ((100.0 - percentForCinema) / 100.0);
            Console.WriteLine($"The profit from the movie {name} is {allSum:F2} lv.");
        }
    }
}
