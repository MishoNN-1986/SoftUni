using System;
using System.Collections.Generic;
using System.Linq;
namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += quantity;
                resource = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
