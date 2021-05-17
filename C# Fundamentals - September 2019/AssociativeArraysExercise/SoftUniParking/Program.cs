using System;
using System.Collections.Generic;
using System.Linq;
namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, string> userNames = new Dictionary<string, string>();
            for (int i = 1; i <= num; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                string name = commands[1];

                switch (command)
                {
                    case "register":
                        string number = commands[2];
                        if (!userNames.ContainsKey(name))
                        {
                            userNames[name] = number;
                            Console.WriteLine($"{name} registered {number} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {userNames[name]}");
                        }
                        break;
                    case "unregister":
                        if (!userNames.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{name} unregistered successfully");
                            userNames.Remove(name);
                        }
                        break;
                }
            }
            foreach (var user in userNames)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
