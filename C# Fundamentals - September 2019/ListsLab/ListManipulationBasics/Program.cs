using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                int numberOne = int.Parse(command[1]);
                int numberTwo = 0;
                if (command.Length == 3)
                {
                    numberTwo = int.Parse(command[2]);
                }
                switch (command[0])
                {
                    case "Add":
                        AddNumber(numbers, numberOne);
                        break;
                    case "Remove":
                        RemoveNumber(numbers, numberOne);
                        break;
                    case "RemoveAt":
                        RemoveAt(numbers, numberOne);
                        break;
                    case "Insert":
                        Insert(numbers, numberOne, numberTwo);
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> AddNumber(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;
        }

        static List<int> RemoveNumber(List<int> numbers, int number)
        {
            numbers.Remove(number);
            return numbers;
        }

        static List<int> RemoveAt(List<int> numbers, int number)
        {
            numbers.RemoveAt(number);
            return numbers;
        }

        static List<int> Insert(List<int> numbers, int numberOne, int numberTwo)
        {
            numbers.Insert(numberTwo,numberOne);
            return numbers;
        }
    }
}
