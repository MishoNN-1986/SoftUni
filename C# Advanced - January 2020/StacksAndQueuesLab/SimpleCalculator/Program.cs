using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var numbers = new Stack<string>(input.Split()); // може и с .Reverse
            int sum = 0;
            int num = 0;
            int number = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                var item = numbers.Pop();
                var isNum = int.TryParse(item, out num);

                if (!isNum)
                {
                    if (item == "+")
                    {
                        sum += number;
                    }
                    else if (item == "-")
                    {
                        sum -= number;
                    }
                }
                else
                {
                    number = num;
                }
                if (numbers.Count == 0 && isNum)
                {
                    sum += number;
                }
                i--;
            }
            Console.WriteLine(sum);
        }
    }
}

