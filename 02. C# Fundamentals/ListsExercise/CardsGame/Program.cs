using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < firstPlayerCards.Count; i++)
            {
                for (int j = 0; j < secondPlayerCards.Count; j++)
                {
                    if (secondPlayerCards.Count == 0 || firstPlayerCards.Count == 0)
                    {
                        break;
                    }
                    if (firstPlayerCards[i] > secondPlayerCards[j])
                    {
                        FirstCardWin(firstPlayerCards, secondPlayerCards);
                    }
                    else if (firstPlayerCards[i] < secondPlayerCards[j])
                    {
                        SecondCardWin(firstPlayerCards, secondPlayerCards);
                    }
                    else if (firstPlayerCards[i] == secondPlayerCards[j])
                    {
                        NoWin(firstPlayerCards, secondPlayerCards);
                    }
                    j--;
                }
                break;
            }
            GetSum(firstPlayerCards, secondPlayerCards);
        }
        static void FirstCardWin(List<int> firstCards, List<int> secondCards)
        {
            firstCards.Add(firstCards[0]);
            firstCards.Add(secondCards[0]);
            firstCards.RemoveAt(0);
            secondCards.RemoveAt(0);
        }

        static void SecondCardWin(List<int> firstCards, List<int> secondCards)
        {
            secondCards.Add(secondCards[0]);
            secondCards.Add(firstCards[0]);
            secondCards.RemoveAt(0);
            firstCards.RemoveAt(0);
        }



        static void NoWin(List<int> firstCards, List<int> secondCards)
        {
            firstCards.RemoveAt(0);
            secondCards.RemoveAt(0);
        }

        static void GetSum(List<int> first, List<int> second)
        {
            int sum = 0;
            if (first.Count > 0)
            {
                sum = first.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (second.Count > 0)
            {
                sum = second.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
