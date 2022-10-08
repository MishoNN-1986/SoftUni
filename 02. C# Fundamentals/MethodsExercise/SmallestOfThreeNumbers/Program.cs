using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = ReadInt();
            //int secondNumber = ReadInt();
            //int thirdNumber = ReadInt();
            Console.WriteLine(PrintMinNumber(ReadInt(), ReadInt(), ReadInt())); // може вместо метод в скобите да сложим променливите
        }
        static int PrintMinNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            return Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);
        }
        static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
