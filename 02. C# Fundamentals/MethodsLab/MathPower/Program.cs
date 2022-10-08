﻿using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = GetMathPowerResult(number, power);
            Console.WriteLine(result);
        }
        private static double GetMathPowerResult(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
