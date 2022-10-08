using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] countOfWagons = new int[n];
            int sumOfThePeople = 0;
            for (int i = 0; i < countOfWagons.Length; i++)
            {
                countOfWagons[i] = int.Parse(Console.ReadLine());
                sumOfThePeople += countOfWagons[i];
            }
            //for (int j = 0; j < countOfWagons.Length; j++)
            //{
            //    Console.Write($"{countOfWagons[j]} ");
            //}
            //Console.WriteLine();
            Console.WriteLine(string.Join(" ", countOfWagons));
            Console.WriteLine(sumOfThePeople);
        }
    }
}
