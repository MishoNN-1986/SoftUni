using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //GetMultipleOfEvenAndOdds(number);
            //Console.WriteLine($"Even sum:{GetSumOfEvenDigits(number)}");
            //Console.WriteLine($"Odd sum:{GetSumOfOddDigits(number)}");
            //int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            //GetResult(number);
            GetResult(number);
        }

        static void GetMultipleOfEvenAndOdds(int number)
        {
            number = Math.Abs(number);
            string evenDigits = "";
            string oddDigits = "";
            while (number != 0)
            {
                int nextNum = number % 10;
                if (nextNum % 2 == 1)
                {
                    oddDigits += " " + nextNum;
                }
                else
                {
                    evenDigits += " " + nextNum;
                }
                number -= nextNum;
                number /= 10;
            }
            string[] item = oddDigits.Split();
            int[] arr = new int[item.Length - 1];
            int j = 0;
            for (int i = item.Length - 1; i > 0; i--)
            {
                arr[j] = int.Parse(item[i]);
                j++;
            }
            j = 0;
            string[] itemEven = evenDigits.Split();
            int[] arrEven = new int[itemEven.Length - 1];
            for (int i = itemEven.Length - 1; i > 0; i--)
            {
                arrEven[j] = int.Parse(itemEven[i]);
                j++;
            }
            Console.WriteLine($"Evens: {string.Join(" ", arrEven)}");
            Console.WriteLine($"Odds: {string.Join(" ", arr)}");
        }

        static int GetSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);

            int evenSum = 0;
            while (number != 0)
            {
                int nextNum = number % 10;
                if (nextNum % 2 == 0)
                {
                    evenSum += nextNum;
                }

                number -= nextNum;
                number /= 10;
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int oddSum = 0;
            while (number != 0)
            {
                int nextNum = number % 10;
                if (nextNum % 2 == 1)
                {
                    oddSum += nextNum;
                }
                number -= nextNum;
                number /= 10;
            }
            return oddSum;
        }

        static void GetResult(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            //Console.WriteLine($"{GetSumOfEvenDigits(number)} * {GetSumOfOddDigits(number)} = {result} ");
            Console.WriteLine(result);
        }
    }
}
