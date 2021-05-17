using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().Split();
            bool original = true;
            while (command[0] != "end")
            {
                if(command[0]=="Add"|| command[0] == "Remove"|| command[0] == "RemoveAt"|| command[0] == "Insert")
                {
                    original = false;
                }
                int numberOne = 0;
                int numberTwo = 0;
                string numberOneString = "";
                if (command[0] == "Filter")
                {
                    numberOneString = command[1].ToString();
                    numberTwo = int.Parse(command[2]);
                }
                else if (command[0] == "Insert")
                {
                    numberOne = int.Parse(command[1]);
                    numberTwo = int.Parse(command[2]);
                }
                else if (command.Length == 2)
                {
                    numberOne = int.Parse(command[1]);
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
                    case "Contains":
                        //Contains(numbers, numberOne);
                        Console.WriteLine(Contains(numbers, numberOne));
                        break;
                    case "PrintEven":
                        //PrintEven(numbers);
                        Console.WriteLine(string.Join(" ", PrintEven(numbers)));
                        break;
                    case "PrintOdd":
                        //PrintOdd(numbers);
                        Console.WriteLine(string.Join(" ", PrintOdd(numbers)));
                        break;
                    case "GetSum":
                        //GetSum(numbers);
                        Console.WriteLine(string.Join(" ", GetSum(numbers)));
                        break;
                    case "Filter":
                        //Filter(numbers, numberOne.ToString(), numberTwo);
                        Console.WriteLine(string.Join(" ", Filter(numbers, numberOneString, numberTwo)));
                        break;
                }
                command = Console.ReadLine().Split();
            }
            //Console.WriteLine(string.Join(" ", numbers));
            if (original == false)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static string Contains(List<int> numbers, int num)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == num)
                {
                    return "Yes";
                }
            }
            return "No such number";
        }

        static List<int> PrintEven(List<int> numbers)
        {
            List<int> newNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    newNumbers.Add(numbers[i]);
                }
            }
            return newNumbers;
        }

        static List<int> PrintOdd(List<int> numbers)
        {
            List<int> newNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    newNumbers.Add(numbers[i]);

                }
            }
            return newNumbers;
        }

        static int GetSum(List<int> numbers)
        {
            int getSum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                getSum += numbers[i];
            }
            return getSum;
        }

        static List<int> Filter(List<int> numbers, string operation, int num)
        {
            List<int> newNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                switch (operation)
                {
                    case "<":
                        if (numbers[i] < num)
                        {
                            newNumbers.Add(numbers[i]);
                        }
                        break;
                    case "<=":
                        if (numbers[i] <= num)
                        {
                            newNumbers.Add(numbers[i]);
                        }
                        break;
                    case ">":
                        if (numbers[i] > num)
                        {
                            newNumbers.Add(numbers[i]);
                        }
                        break;
                    case ">=":
                        if (numbers[i] >= num)
                        {
                            newNumbers.Add(numbers[i]);
                        }
                        break;
                }
            }
            return newNumbers;
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
            numbers.Insert(numberTwo, numberOne);
            return numbers;
        }
    }
}
