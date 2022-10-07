using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0.0;
            string typeResul = "";

            if (n2 == 0 && (operation == '/' || operation == '%'))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");

            }
            else
            {
                switch (operation)
                {
                    case '+':
                        result = n1 + n2;
                        if (result % 2 == 0)
                        {
                            typeResul = "even";
                        }
                        else
                        {
                            typeResul = "odd";
                        }
                        Console.WriteLine($"{n1} {operation} {n2} = {result} - {typeResul}");
                        break;
                    case '-':
                        result = n1 - n2;
                        if (result % 2 == 0)
                        {
                            typeResul = "even";
                        }
                        else
                        {
                            typeResul = "odd";
                        }
                        Console.WriteLine($"{n1} {operation} {n2} = {result} - {typeResul}");
                        break;
                    case '*':
                        result = n1 * n2;
                        if (result % 2 == 0)
                        {
                            typeResul = "even";
                        }
                        else
                        {
                            typeResul = "odd";
                        }
                        Console.WriteLine($"{n1} {operation} {n2} = {result} - {typeResul}");
                        break;
                    case '/':
                        result = n1 / n2;
                        Console.WriteLine($"{n1} {operation} {n2} = {result:F2}");
                        break;
                    case '%':
                        result = n1 % n2;
                        Console.WriteLine($"{n1} {operation} {n2} = {result}");
                        break;
                }
            }
        }
    }
}
