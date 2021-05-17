using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPassengers = int.Parse(Console.ReadLine());
            int numberOfStops = int.Parse(Console.ReadLine());
            int countPassengers = numberOfPassengers;
            for (int i = 1; i <= numberOfStops; i++)
            {
                int numberOfPassengersGoDown = int.Parse(Console.ReadLine());
                int numberOfPassengersArePickedUp = int.Parse(Console.ReadLine());
                countPassengers += numberOfPassengersArePickedUp-numberOfPassengersGoDown;
                if (countPassengers < 0)
                {
                    countPassengers = 0;
                }
                
            }
            if (numberOfStops % 2 != 0)
            {
                countPassengers += 2;
            }
            
            Console.WriteLine($"The final number of passengers is : {countPassengers}");
        }
    }
}
