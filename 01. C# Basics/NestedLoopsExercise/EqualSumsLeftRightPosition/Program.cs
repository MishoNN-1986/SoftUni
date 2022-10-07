using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                string num = $"{num1}";
                int sum1 = num[0] + num[1];
                int sum2 = num[3] + num[4];
                if (sum1 == sum2)
                {
                    Console.Write($"{num1} ");
                }
                else
                {
                    int secondNum = int.Parse(num[2].ToString());
                    int diff = Math.Abs(int.Parse(sum1.ToString()) - int.Parse(sum2.ToString()));
                    if (diff == secondNum)
                    {
                        Console.Write($"{num1} ");
                    }
                }
                num1++;
            }
        }
    }
}
