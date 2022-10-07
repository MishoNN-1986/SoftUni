using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int biggest = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i >= j)
                    {
                        biggest = i;
                    }
                    else
                    {
                        biggest = j;
                    }
                    for (char k = 'a'; k < 97 + l; k++)
                    {
                        for (char g = 'a'; g < 97 + l; g++)
                        {
                            for (int m = biggest + 1; m <= n; m++)
                            {
                                Console.Write($"{i}{j}{k}{g}{m} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
