using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeInput = Console.ReadLine();
            switch (typeInput)
            {
                case "int":
                    int firstValue = int.Parse(Console.ReadLine());
                    int secondValue = int.Parse(Console.ReadLine());
                    int getMaxInt = GetMax(firstValue, secondValue);
                    Console.WriteLine(getMaxInt);
                    break;
                case "char":
                    char firstValueChar = char.Parse(Console.ReadLine());
                    char secondValueChar = char.Parse(Console.ReadLine());
                    char getMaxChar = GetMax(firstValueChar, secondValueChar);
                    Console.WriteLine(getMaxChar);
                    break;
                case "string":
                    string firstValueString = Console.ReadLine();
                    string secondValueString = Console.ReadLine();
                    string getMaxString = GetMax(firstValueString, secondValueString);
                    Console.WriteLine(getMaxString);
                    break;
            }
        }
        static int GetMax(int firstValue, int secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
        static char GetMax(char firstValue, char secondValue)
        {
            return (char)Math.Max(firstValue, secondValue);
        }
        static string GetMax(string firstValue, string secondValue)
        {
            //int firstSum = 0;
            //for (int i = 0; i < firstValue.Length; i++)
            //{
            //    firstSum += (int)firstValue[i];
            //}
            //int secondSum = 0;
            //for (int j = 0; j < firstValue.Length; j++)
            //{
            //    secondSum += (int)secondValue[j];
            //}
            //if (firstSum > secondSum)
            //{
            //    return firstValue;
            //}
            //else
            //{
            //    return secondValue;
            //}
            int comparison = firstValue.CompareTo(secondValue);
            if (comparison > 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
