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

            int sumLeft = 0;

            int sumRight = 0;

            int middle = 0;

            for (int i = num1; i <= num2; i++)
            {
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    char first = i.ToString()[j];

                    string sub = first.ToString();

                    int num3 = 0;

                    bool number_digit = Int32.TryParse(sub, out num3);

                    if (number_digit)
                    {
                        if (j == 0 || j == 1)
                        {
                            sumLeft = sumLeft + num3;
                        }
                        else if (j == 2)
                        {
                            middle = num3;
                        }
                        else if (j == 3 || j == 4)
                        {
                            sumRight = sumRight + num3;
                        }
                    }
                }
                if (sumLeft < sumRight)
                {
                    sumLeft = sumLeft + middle;

                    if (sumLeft == sumRight)
                    {
                        Console.Write("{0} ", i);
                    }
                }
                else if (sumLeft > sumRight)
                {
                    sumRight = sumRight + middle;

                    if (sumLeft == sumRight)
                    {
                        Console.Write("{0} ", i);
                    }
                }
                else if (sumLeft == sumRight)
                {
                    Console.Write("{0} ", i);
                }

                sumLeft = 0;
                sumRight = 0;
                middle = 0;

            }
        }
    }
}
        
    

