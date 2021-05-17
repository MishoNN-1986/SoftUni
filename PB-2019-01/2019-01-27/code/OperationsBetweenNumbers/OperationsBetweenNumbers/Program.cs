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
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double theResult = 0.0;
            switch (operation)
            {
                case '+':
                    theResult = number1 + number2;
                    if (theResult % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {theResult} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {theResult} - odd");
                    }
                    break;

                case '-':
                    theResult = number1 - number2;
                    if (theResult % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {theResult} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {theResult} - odd");
                    }
                    break;
                case '*':
                    theResult = number1 * number2;
                    if (theResult % 2 == 0)
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {theResult} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} {operation} {number2} = {theResult} - odd");
                    }
                    break;

                case '/':
                    theResult = number1*1.0 / number2;
                    
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} / {number2} = {theResult:F2}");
                    }
                    break;
                case '%':
                    
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                       
                    {
                        theResult = number1 % number2;
                        Console.WriteLine($"{number1} % {number2} = {theResult}");
                    }
                    break;
            }
        }
    }
}
