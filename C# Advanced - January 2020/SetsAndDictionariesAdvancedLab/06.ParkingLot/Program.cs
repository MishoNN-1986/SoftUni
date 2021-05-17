using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> carNumbers = new HashSet<string>();
            while (input != "END")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = command[0];
                string carNumber = command[1];
                if (direction == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    carNumbers.Remove(carNumber);
                }
                input = Console.ReadLine();
            }
            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var carNumber in carNumbers)
                {
                    Console.WriteLine(carNumber);
                }
            }
        }
    }
}
