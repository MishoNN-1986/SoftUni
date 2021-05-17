using System;
using System.Linq;

namespace _04.HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            string season = input[2].ToLower();
            string discountType = "none";
            if (input.Length > 3) discountType = input[3].ToLower();

            PriceCalculator priceCalculator = new PriceCalculator();
            var output= priceCalculator.Calculate(pricePerDay,
                numberOfDays,
                Enum.Parse<Season>(season),
                Enum.Parse<Discount>(discountType));
            Console.WriteLine(output);
        }
    }
}
