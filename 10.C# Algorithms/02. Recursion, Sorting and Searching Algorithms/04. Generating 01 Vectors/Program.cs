using System;
using System.Linq;
using System.Text;

namespace _04._Generating_01_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDigits = int.Parse(Console.ReadLine());
            int[] vector = new int[countDigits];
            Gen01(vector, 0);
        }

        private static void Gen01(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }
            
            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Gen01(vector, index + 1);
            }
        }
    }
}
