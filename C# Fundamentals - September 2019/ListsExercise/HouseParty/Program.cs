using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCommands = int.Parse(Console.ReadLine());
            string command = string.Empty;
            List<string> names = new List<string>(numbersOfCommands);
            while (numbersOfCommands > 0)
            {
                command = Console.ReadLine();
                string[] splitCommand = command.Split();
                string name = splitCommand[0];
                string move = splitCommand[2];
                switch (move)
                {
                    case "going!":
                        GetIsGoing(names, name);
                        break;
                    case "not":
                        GetIsNotGoing(names, name);
                        break;
                }
                numbersOfCommands--;
            }
            GetListNames(names);
        }

        static void GetIsGoing(List<string> names, string name)
        {
            bool isInTheList = names.Contains(name);
            if (isInTheList)
            {
                Console.WriteLine($"{name} is already in the list!");
            }
            if (isInTheList == false)
            {
                names.Add(name);
            }
        }

        static void GetIsNotGoing(List<string> names, string name)
        {
            bool isInTheList = names.Contains(name);
            if (isInTheList)
            {
                names.Remove(name);
            }
            if (isInTheList == false)
            {
                Console.WriteLine($"{name} is not in the list!");
            }
        }

        static void GetListNames(List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(string.Join(" ", names[i]));
            }
        }
    }
}
