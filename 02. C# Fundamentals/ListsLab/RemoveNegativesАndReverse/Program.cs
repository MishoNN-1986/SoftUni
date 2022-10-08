using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesАndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            ReversedOrderNumbers(GetRemoveNegativeNumbers(numbers));
            
        }

        static List<int> GetRemoveNegativeNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            return numbers;
        }

        static void ReversedOrderNumbers(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            List<int> reversedOrderNumbersInt = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)   // става и с numbers.Reverse();
            {
                reversedOrderNumbersInt.Add(numbers[i]);
            }
            Console.WriteLine(string.Join(" ", reversedOrderNumbersInt));
        }
    }
}
