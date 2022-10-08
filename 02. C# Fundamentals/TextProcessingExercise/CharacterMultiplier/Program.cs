using System;
using System.Text;
namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstText = input[0];
            string secondText = input[1];
            if (firstText.Length > secondText.Length)
            {
                string subWord = firstText.Substring(0, secondText.Length);
                string remainingWord = firstText.Substring(secondText.Length);
                TotalSum(subWord, secondText, remainingWord);
            }
            else if (firstText.Length < secondText.Length)
            {
                string subWord = secondText.Substring(0, firstText.Length);
                string remainingWord = secondText.Substring(firstText.Length);
                TotalSum(subWord, firstText, remainingWord);
            }
            else
            {
                TotalSum(firstText, secondText, string.Empty);
            }
        }

        private static void TotalSum(string subWord, string secondText, string remainingWord)
        {
            int totalSum = 0;
            int remainindSum = 0;
            for (int i = 0; i < subWord.Length; i++)
            {
                totalSum += (subWord[i] * secondText[i]);
            }
            for (int i = 0; i < remainingWord.Length; i++)
            {
                remainindSum += remainingWord[i];
            }
            totalSum += remainindSum;
            Console.WriteLine(totalSum);
            return;
        }
    }
}
