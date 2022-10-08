using System;
using System.Collections.Generic;
using System.Linq;
namespace TanksCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            int num = int.Parse(Console.ReadLine());
            string command = string.Empty;
            for (int i = 1; i <= num; i++)
            {
                command = Console.ReadLine();
                string[] splitCommand = command.Split(", ");
                switch (splitCommand[0])
                {
                    case "Add":
                        string tankName = splitCommand[1];
                        Add(input, tankName);
                        break;
                    case "Remove":
                        string removeTankName = splitCommand[1];
                        Remove(input, removeTankName);
                        break;
                    case "Remove At":
                        int index = int.Parse(splitCommand[1]);
                        RemoveAt(input, index);
                        break;
                    case "Insert":
                        int insertIndex = int.Parse(splitCommand[1]);
                        string insertTankName = splitCommand[2];
                        Insert(input, insertIndex, insertTankName);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }

        private static void Insert(List<string> input, int insertIndex, string insertTankName)
        {
            if (insertIndex < 0 || insertIndex >= input.Count)
            {
                Console.WriteLine("Index out of range");
                return;
            }
            foreach (var item in input)
            {
                if (item == insertTankName)
                {
                    Console.WriteLine("Tank is already bought");
                    return;
                }
            }
            input.Insert(insertIndex, insertTankName);
            Console.WriteLine("Tank successfully bought");
            return;
        }

        private static void RemoveAt(List<string> input, int index)
        {
            if (index < 0 || index >= input.Count)
            {
                Console.WriteLine("Index out of range");
                return;
            }
            input.RemoveAt(index);
            Console.WriteLine("Tank successfully sold");
        }

        private static void Remove(List<string> input, string removeTankName)
        {
            foreach (var item in input)
            {
                if (item == removeTankName)
                {
                    Console.WriteLine("Tank successfully sold");
                    input.Remove(item);
                    return;
                }
            }
            Console.WriteLine("Tank not found");
        }

        private static void Add(List<string> input, string tankName)
        {
            foreach (var item in input)
            {
                if (item == tankName)
                {
                    Console.WriteLine("Tank is already bought");
                    return;
                }
            }
            Console.WriteLine("Tank successfully bought");
            input.Add(tankName);
        }
    }
}
