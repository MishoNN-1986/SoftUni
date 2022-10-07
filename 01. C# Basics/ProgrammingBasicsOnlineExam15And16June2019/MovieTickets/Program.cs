using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (char i = (char)a1; i < (char)a2; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 1; k < n / 2; k++)
                    {
                        int l = (int)i;
                        if ((int)i % 2 == 1 && ((j + k + l) % 2 == 1))
                        {
                            Console.WriteLine($"{i}-{j}{k}{l}");
                        }
                    }
                }
            }
        }
    }
}
