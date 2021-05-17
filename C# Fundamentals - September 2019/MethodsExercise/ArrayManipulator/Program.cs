using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ConvertStringToArr(ReadString());
            string command = ReadString();
            //int position = int.Parse(ReadString());
            //string newArr = (string.Join(" ", numbers));
            //Console.WriteLine(GetArrayWithComma(newArr));
            //GetNewAraayAfterExchange(numbers, n);
            //string az = "";

            string[] commandParams = command.Split();
            StringBuilder sb = new StringBuilder();

            while (commandParams[0] != "end")
            {
                //az = newArr;
                switch (commandParams[0])
                {
                    case "exchange":
                        var index = int.Parse(commandParams[1]);
                        var isValid = TryExchange(numbers, index, out int[] res);
                        numbers = res;
                        if (!isValid)
                        {
                            sb.AppendLine("Invalid index");
                        }
                        break;
                    case "max":
                        int max = GetMax(numbers, commandParams[1] == "even");

                        if (max == int.MinValue)
                        {
                            sb.AppendLine("No matches");
                        }
                        else
                        {
                            sb.AppendLine($"[{max}]");
                        }

                        break;
                    case "min":
                        int min = GetMin(numbers, commandParams[1] == "even");

                        if (min == int.MaxValue)
                        {
                            sb.AppendLine("No matches");
                        }
                        else
                        {
                            sb.AppendLine($"[{min}]");
                        }

                        break;
                    case "first":
                        int count = int.Parse(commandParams[1]);
                        int[] result = GetFirst(numbers, count, commandParams[2] == "even");
                        sb.AppendLine(GetArrayWithComma(result));
                        break;
                    case "first even":
                        Console.WriteLine(GetFirstEven(newArr, GetPositionOfFirstAndLast(command)));
                        break;
                    case "last even":
                        Console.WriteLine(GetLastEven(newArr, GetPositionOfFirstAndLast(command)));
                        break;
                    case "last odd":
                        Console.WriteLine(GetLastOdd(newArr, GetPositionOfFirstAndLast(command)));
                        break;
                    case "first odd":
                        Console.WriteLine(GetFirstOdd(newArr, GetPositionOfFirstAndLast(command)));
                        break;
                }
                numbers = newArr.Split().Select(int.Parse).ToArray();
                command = ReadString();
            }
            sb.AppendLine(GetArrayWithComma(newArr));

            Console.WriteLine(sb.ToString());
        }

        static bool TryExchange(int[] numbers, int num, out int[] newNumbers)
        {
            newNumbers = numbers;
            if (num >= numbers.Length)
            {
                return false;
            }

            if (num + 1 == numbers.Length)
            {
                return true;
            }
            
            newNumbers = new int[numbers.Length];

            int i = 0;

            for (int j = num + 1; j < numbers.Length; j++)
            {
                newNumbers[i] = numbers[j];
                i++;
            }

            for (int j = 0; j < num + 1; j++)
            {
                newNumbers[i] = numbers[j];
                i++;
            }

            return true;
        }

        static int GetPositionOfFirstAndLast(string text)
        {
            string[] item = text.Split();
            int position = int.Parse(item[1]);
            return position;
        }

        static string GetFirstEven(string text, int num)
        {
            string firstEven = "[";
            int count = 0;
            int[] arr = text.Split().Select(int.Parse).ToArray();
            if (num >= arr.Length)
            {
                return "Invalid count";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                    if (count == 1)
                    {
                        firstEven += "" + arr[i];
                    }
                    else if (count == num)
                    {
                        firstEven += "" + ", " + arr[i] + "]";
                        return firstEven;
                    }
                    else
                    {
                        firstEven += "" + ", " + arr[i];
                    }
                }
            }
            if (count == 0)
            {
                return "[]";
            }
            return firstEven += "" + "]";

        }

        static string GetFirstOdd(string text, int num)
        {
            string firstOdd = "[";
            int count = 0;
            int[] arr = text.Split().Select(int.Parse).ToArray();
            if (num >= arr.Length)
            {
                return "Invalid count";
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count++;
                    if (count == 1)
                    {
                        firstOdd += "" + arr[i];
                    }
                    else if (count == num)
                    {
                        firstOdd += "" + ", " + arr[i] + "]";
                        return firstOdd;
                    }
                    else
                    {
                        firstOdd += "" + ", " + arr[i];
                    }
                }
            }
            if (count == 0)
            {
                return "[]";
            }
            return firstOdd += "" + "]";

        }

        static string GetLastEven(string text, int num)
        {
            string lastEven = "[";
            int count = 0;
            int[] arr = text.Split().Select(int.Parse).ToArray();
            if (num >= arr.Length)
            {
                return "Invalid count";
            }
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                if (arr[j] % 2 == 0)
                {
                    count++;
                }
            }
            int[] newArr = new int[count];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    newArr[k] = arr[i];
                    k++;
                }
            }
            int maxEven = 0;
            if (newArr.Length > num)
            {
                maxEven = newArr.Length - num;
            }
            for (int l = maxEven; l < newArr.Length; l++)
            {
                if (l == maxEven)
                {
                    lastEven += "" + newArr[l];
                }
                else if (l > maxEven && l < newArr.Length - 1)
                {
                    lastEven += "" + ", " + newArr[l];
                }
                else
                {
                    lastEven += "" + ", " + newArr[l];
                }
            }
            if (count == 0)
            {
                return "[]";
            }
            return lastEven += "" + "]";
        }

        static string GetLastOdd(string text, int num)
        {
            string lastOdd = "[";
            int count = 0;
            int[] arr = text.Split().Select(int.Parse).ToArray();
            if (num >= arr.Length)
            {
                return "Invalid count";
            }
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                if (arr[j] % 2 == 1)
                {
                    count++;
                }
            }
            int[] newArr = new int[count];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    newArr[k] = arr[i];
                    k++;
                }
            }
            int maxOdd = 0;
            if (newArr.Length > num)
            {
                maxOdd = newArr.Length - num;
            }
            for (int l = maxOdd; l < newArr.Length; l++)
            {
                if (l == maxOdd)
                {
                    lastOdd += "" + newArr[l];
                }
                else if (l > maxOdd && l < newArr.Length - 1)
                {
                    lastOdd += "" + ", " + newArr[l];
                }
                else
                {
                    lastOdd += "" + ", " + newArr[l];
                }
            }
            if (count == 0)
            {
                return "[]";
            }
            return lastOdd += "" + "]";
        }
        
        static string GetArrayWithComma(string arrString)
        {
            string ArrayWithComma = "[";
            int[] arr = arrString.Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    ArrayWithComma += "" + arr[i];
                }
                else if (i > 0 && i < arr.Length - 1)
                {
                    ArrayWithComma += "" + ", " + arr[i];
                }
                else
                {
                    ArrayWithComma += "" + ", " + arr[i] + "]";
                }
            }
            if (arr.Length == 1)
            {
                ArrayWithComma += "" + "]";
            }
            return ArrayWithComma;
        }

        static int GetMax(int[] arr, bool even)
        {
            int max = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= max)
                {
                    if (even && arr[i] % 2 == 0)
                    {
                        max = i;
                    }
                    else if (!even && arr[i] % 2 == 1)
                    {
                        max = i;
                    }
                }
            }
            return max;
        }

        static int GetMin(int[] arr, bool even)
        {
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= min)
                {
                    if (even && arr[i] % 2 == 0)
                    {
                        min = i;
                    }
                    else if (!even && arr[i] % 2 == 1)
                    {
                        min = i;
                    }
                }
            }
            return min;
        }

        static string GetMinOdd(string arrString)
        {
            int[] arr = ConvertStringToArr(arrString);
            int minOdd = 1001;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 && arr[i] < minOdd)
                {
                    minOdd = i;
                }
            }
            if (minOdd == 1001)
            {
                return "No matches";
            }
            else
            {
                return minOdd.ToString();
            }
        }

        static string GetMaxEven(string arrString)
        {
            int[] arr = ConvertStringToArr(arrString);
            int maxOdd = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] > maxOdd)
                {
                    maxOdd = i;
                }
            }
            if (maxOdd == -1)
            {
                return "No matches";
            }
            else
            {
                return maxOdd.ToString();
            }
        }

        static string GetMinEven(string arrString)
        {
            int[] arr = ConvertStringToArr(arrString);
            int minOdd = 1001;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] < minOdd)
                {
                    minOdd = i;
                }
            }
            if (minOdd == 1001)
            {
                return "No matches";
            }
            else
            {
                return minOdd.ToString();
            }
        }

        static string ReadString()
        {
            return Console.ReadLine();
        }

        static int[] ConvertStringToArr(string arrString)
        {
            int[] arr = arrString.Split().Select(int.Parse).ToArray();
            return arr;
        }
    }
}
