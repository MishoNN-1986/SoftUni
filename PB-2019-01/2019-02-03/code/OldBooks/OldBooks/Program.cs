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
            string favoriteNameBook = Console.ReadLine();
            int sumBooks = int.Parse(Console.ReadLine());
            int counter = 0;
            while (counter < sumBooks)
            {
                string nameBook = Console.ReadLine();
                if (favoriteNameBook == nameBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if (counter >= sumBooks)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
