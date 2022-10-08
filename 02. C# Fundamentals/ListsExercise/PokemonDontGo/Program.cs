using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while (numbers.Count > 0)
            {
                int position = int.Parse(Console.ReadLine());

                int distance = GetDistance(numbers, position);
                CalculateDistance(numbers, distance);

                sum += distance;
            }
            Console.WriteLine(sum);
        }

        static int GetDistance(List<int> numbers, int position)
        {
            int distance = 0;

            if (position < 0)
            {
                distance = numbers[0];
                numbers[0] = numbers[numbers.Count - 1];
            }
            else if (position >= numbers.Count)
            {
                distance = numbers[numbers.Count - 1];
                numbers[numbers.Count - 1] = numbers[0];
            }
            else
            {
                distance = numbers[position];
                numbers.RemoveAt(position);
            }

            return distance;
        }

        static void CalculateDistance(List<int> numbers, int num)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= num)
                {
                    numbers[i] += num;
                }
                else
                {
                    numbers[i] -= num;
                }
            }
        }
    }
}
