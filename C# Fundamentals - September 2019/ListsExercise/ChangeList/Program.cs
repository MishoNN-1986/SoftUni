using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitCommand = command.Split();
                string FirstPosition = splitCommand[0];
                int secondPosition = int.Parse(splitCommand[1].ToString());
                int thirdPosition = 0;
                if (splitCommand.Length == 2)
                {
                    numbers.RemoveAll(x => x == secondPosition);
                    //for (int i = 0; i < numbers.Count; i++)
                    //{
                    //    numbers.Remove(secondPosition);
                    //}
                }
                else if (splitCommand.Length == 3)
                {
                    thirdPosition = int.Parse(splitCommand[2].ToString());
                    numbers.Insert(thirdPosition, secondPosition);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
