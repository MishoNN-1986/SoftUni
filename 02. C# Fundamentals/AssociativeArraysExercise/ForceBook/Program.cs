using System;
using System.Collections.Generic;
using System.Linq;
namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            bool checkName = false;
            while (text != "Lumpawaroo")
            {
                if (text.Contains('|'))
                {
                    string[] addName = text.Split(" | ");
                    string side = addName[0];
                    string name = addName[1];
                    foreach (var item in sides)
                    {
                        checkName = item.Value.Contains(name);
                    }

                    if (!checkName)
                    {
                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }
                        var list = sides[side];
                        list.Add(name);
                        list.Sort();
                    }
                    checkName = false;
                }
                else
                {
                    string[] changeSide = text.Split(" -> ");
                    string side = changeSide[1];
                    string name = changeSide[0];
                    bool sideName = false;
                    foreach (var item in sides)
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            if (item.Value[i] == name)
                            {
                                if (item.Key == side)
                                {
                                    sideName = true;
                                    continue;
                                }
                                else
                                {
                                    item.Value.Remove(name);
                                    checkName = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (!sideName)
                    {
                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }
                        var list = sides[side];
                        list.Add(name);
                        list.Sort();
                        Console.WriteLine($"{name} joins the {side} side!");
                    }
                    sideName = false;
                    checkName = false;
                }
                text = Console.ReadLine();
            }
            sides = sides.OrderByDescending(n => n.Value.Count).ThenBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
            foreach (var item in sides)
            {
                if (item.Value.Count < 1)
                {
                    continue;
                }
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"! {item.Value[i]}");
                }
            }
        }
    }
}
