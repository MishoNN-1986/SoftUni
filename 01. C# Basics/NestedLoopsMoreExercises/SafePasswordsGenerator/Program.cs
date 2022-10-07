using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count = 0;
            char i = '#';
            char j = '@';
            //for (char i = '#' ; i <= '7'; i++)
            //{
            //    for (char j = '@'; j <= '`'; j++)
            //    {
            for (int k = 1; k <= a; k++)
            {
                for (int l = 1; l <= b; l++)
                {
                    Console.Write($"{i}{j}{k}{l}{j}{i}|");
                    count++;
                    i++;
                    j++;
                    if (i > '7')
                    {
                        i = '#';
                    }
                    if (j > '`')
                    {
                        j = '@';
                    }
                    if (count == max)
                    {
                        return;
                    }
                }
            }
            // }
            //}
        }

    }
}
