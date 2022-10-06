using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // брой числа
            int sum = 0;
            int maxNum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()); // въвеждаме число
                sum += num;                               //добавяме числото към сумата
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            sum = sum - maxNum;                        //вадим най-голямото число от сумата
            if (sum == maxNum)                         // проверяваме дали сумата е равна на най-голямото число
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                int diff = Math.Abs(sum - maxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
