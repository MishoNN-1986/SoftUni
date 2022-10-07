using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameBook = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            while (count < capacity)
            {
                string book = Console.ReadLine();
                if (book == nameBook)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                count++;
            }
            if (count >= capacity)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {capacity} books.");
            }
        }
    }
}
