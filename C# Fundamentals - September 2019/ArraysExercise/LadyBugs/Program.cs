using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] startIndexOfLadyBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = new int[num];
            foreach (int index in startIndexOfLadyBugs)
            {
                if (index < 0 || index > num - 1)
                {
                    continue;
                }
                numbers[index] = 1;
            }
            string command = null;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] stringCommand = command.Split();
                int ladyBugIndex = int.Parse(stringCommand[0]);
                string operation = stringCommand[1];
                int flyLength = int.Parse(stringCommand[2]);
                if (ladyBugIndex < 0 || ladyBugIndex > num || numbers[ladyBugIndex] != 1)
                {
                    continue;
                }
                if (operation == "right")
                {
                    numbers[ladyBugIndex] = 0;
                    int newIndex = ladyBugIndex + flyLength;
                    while (newIndex < num)
                    {
                        if (numbers[newIndex] == 1)
                        {
                            newIndex += flyLength;
                            continue;
                        }
                        numbers[newIndex] = 1;
                        break;
                    }
                }
                else if (operation == "left")
                {
                    numbers[ladyBugIndex] = 0;
                    int newIndex = ladyBugIndex - flyLength;
                    while (newIndex >= 0)
                    {
                        if (numbers[newIndex] == 1)
                        {
                            newIndex -= flyLength;
                            continue;
                        }
                        numbers[newIndex] = 1;
                        break;
                    }
                }
                //command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
