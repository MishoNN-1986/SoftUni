using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            int rowCount = 1;
            while (currentNumber <= n)
            {
                for (int i = 1; i <= rowCount; i++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                    if(currentNumber > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                rowCount++;
            }
        }
    }
}
