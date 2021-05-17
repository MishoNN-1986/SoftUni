using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] splitCommand = command.Split();
                string firstPosition = splitCommand[0];
                string secondPosition = splitCommand[1];
                string thirdPosition = string.Empty;
                int secondPositionToInt = 0;
                int thirdPositionToInt = 0;
                if (splitCommand.Length == 2)
                {
                    secondPositionToInt = GetInt(secondPosition);
                }
                switch (firstPosition)
                {
                    case "Add":
                        //secondPositionToInt = int.Parse(secondPosition);
                        GetAdd(numbers, secondPositionToInt);
                        break;
                    case "Insert":
                        secondPositionToInt = GetInt(secondPosition);
                        thirdPosition = splitCommand[2];
                        thirdPositionToInt = GetInt(thirdPosition);
                        GetInsert(numbers, secondPositionToInt, thirdPositionToInt);
                        break;
                    case "Remove":
                        //secondPositionToInt = int.Parse(secondPosition);
                        GetRemove(numbers, secondPositionToInt);
                        break;
                    case "Shift":
                        thirdPosition = splitCommand[2];
                        thirdPositionToInt = GetInt(thirdPosition);
                        GetLeftAndRightShif(numbers, secondPosition, thirdPositionToInt);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void GetAdd(List<int> numbers, int number)
        {
            numbers.Add(number);
        }

        static void GetInsert(List<int> numbers, int number, int index)
        {
            if (index >= numbers.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(index, number);
            }
        }

        static void GetRemove(List<int> numbers, int index)
        {
            if (index >= numbers.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(index);
            }
        }

        static void GetLeftAndRightShif(List<int> numbers, string type, int count)
        {
            if (type == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }
            else if (type == "right")
            {
                for (int i = 1; i <= count; i++)
                {
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
            }
        }
        static int GetInt(string num)
        {
            return int.Parse(num);
        }
    }
}
