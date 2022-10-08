using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {

                string firstPosition = command[0];
                int secondPosition = 0;
                int firstPositionToInt = 0;
                if (command.Length == 1)
                {
                    firstPositionToInt = int.Parse(firstPosition);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] + firstPositionToInt <= num)
                        {
                            numbers[i] += firstPositionToInt;
                            break;
                        }
                    }
                }
                else if (command.Length == 2)
                {
                    secondPosition = int.Parse(command[1]);
                    numbers.Add(secondPosition);
                }

                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
