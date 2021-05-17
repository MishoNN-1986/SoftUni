using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var inputCoins = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var availableCoins = inputCoins.Skip(1)
            .Select(x => x.Split(new char[] { ',' }).First()) //цепи на запетаята и взима първото
            .Select(int.Parse)
            .ToArray();

        var inputSum = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var targetSum = int.Parse(inputSum[1]);

        foreach (var item in availableCoins)
        {
            if (item != 1 && item != 2 && item != 5 && item != 10 && item != 20 && item != 50)
            {
                Console.WriteLine("Error");
                return;
            }
        }

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var orderCoins = coins.OrderByDescending(n => n);
        Dictionary<int, int> coinsWithValue = new Dictionary<int, int>();
        foreach (var item in orderCoins)
        {
            if (targetSum / item > 0)
            {
                if (!coinsWithValue.ContainsKey(item))
                {
                    coinsWithValue.Add(item, targetSum / item);
                }
                else
                {
                    coinsWithValue[item] += targetSum / item;
                }

                targetSum %= item;
                if (targetSum == 0)
                {
                    break;
                }
            }
        }
        if (targetSum != 0)
        {
            throw new InvalidOperationException();
        }
        return coinsWithValue;
        //for (int i = coins.Count - 1; i >= 0; i--)
        //{
        //    if (targetSum / coins[i] > 0)
        //    {
        //        coinsWithValue.Add(coins[i], targetSum / coins[i]);
        //        targetSum %= coins[i];
        //        if (targetSum == 0)
        //        {
        //            return coinsWithValue;
        //        }
        //    }
        //}
        //return coinsWithValue;
    }
}