using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            Calculate(firstNumber, operation, secondNumber);
        }
        static void Calculate(double firstNumber,string operation, double secondNumber)
        {
            double result = 0;
            switch (operation)
            {
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
            }
            Console.WriteLine($"{result}");
        }
    }
}
