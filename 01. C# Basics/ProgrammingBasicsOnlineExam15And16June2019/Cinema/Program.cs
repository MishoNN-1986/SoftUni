using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int price = 0;
            int allPrice = 0;
            while (capacity >= 0)
            {
                string command = Console.ReadLine();
                allPrice += price;
                price = 0;
                if (command == "Movie time!")
                {
                    Console.WriteLine($"There are {capacity} seats left in the cinema.");
                    Console.WriteLine($"Cinema income - {allPrice} lv.");
                    return;
                }
                int sumPeople = int.Parse(command);
                price = sumPeople * 5;
                if (sumPeople % 3 == 0)
                {
                    price = (sumPeople * 5) - 5;
                }
                capacity -= sumPeople;
            }
            Console.WriteLine("The cinema is full.");
            Console.WriteLine($"Cinema income - {allPrice} lv.");
        }
    }
}
