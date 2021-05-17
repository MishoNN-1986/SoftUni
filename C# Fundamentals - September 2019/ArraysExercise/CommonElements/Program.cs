using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstElements = Console.ReadLine();
            //string[] arrone = Console.ReadLine().Split();
            string secondElements = Console.ReadLine();
            string[] firstArray = firstElements.Split();
            string[] secondArray = secondElements.Split();
            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray[j] == secondArray[i])
                    {
                        Console.Write($"{secondArray[i]} ");
                    }
                }
            }
        }
    }
}
