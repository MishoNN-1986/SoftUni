using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numbersToArray = numbers.Split(' ');
            double[] array = new double[numbersToArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(numbersToArray[i]);
                Console.WriteLine($"{array[i]} => {(int)Math.Round(array[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
