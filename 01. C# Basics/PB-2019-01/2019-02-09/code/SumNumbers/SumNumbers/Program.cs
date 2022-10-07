using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //брой числа 
            int sum = 0; //сумата на числата
            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine()); //въвеждаме число
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
