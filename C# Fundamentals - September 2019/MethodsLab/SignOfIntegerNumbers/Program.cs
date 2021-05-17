using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var readValueFromConsole = Console.ReadLine();
            int inputValue = int.Parse(readValueFromConsole);
            TypeNumber(inputValue);  // може и директно TypeNumber (int.Parse(Console.ReadLine()));
        }
        static void TypeNumber(int inputNumber)
        {
            if (inputNumber > 0)
            {
                Console.WriteLine($"The number {inputNumber} is positive.");
            }
            else if (inputNumber < 0)
            {
                Console.WriteLine($"The number {inputNumber} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
