using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlaneTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string desiNumberTicket = "";
            double desiPrice = 0;
            int desiMinMinutes = int.MaxValue;
            while (true)
            {
                string numberTicket = Console.ReadLine();
                if (numberTicket == "End")
                {
                    break;
                }
                double priceInEuro = double.Parse(Console.ReadLine());
                int minutes = int.Parse(Console.ReadLine());
                if (minutes < desiMinMinutes)
                {
                    desiMinMinutes = minutes;
                    desiNumberTicket = numberTicket;
                    desiPrice = priceInEuro;
                }
            }
            Console.WriteLine($"Ticket found for flight {desiNumberTicket} costs {desiPrice * 1.96:F2} leva with {desiMinMinutes / 60}h {desiMinMinutes % 60}m stay");
        }
    }
}
