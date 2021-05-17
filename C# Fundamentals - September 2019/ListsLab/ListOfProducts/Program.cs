using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 1; i <= quantity; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int j = 1; j <= quantity; j++)
            {
                Console.WriteLine($"{j}.{products[j - 1]}");
            }
        }
    }
}
