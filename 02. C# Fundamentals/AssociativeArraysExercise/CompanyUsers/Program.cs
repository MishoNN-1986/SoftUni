using System;
using System.Collections.Generic;
using System.Linq;
namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            bool repeating = false;
            while (input[0] != "End")
            {
                string companyName = input[0];
                string id = input[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    var list = companies[companyName];
                    list.Add(id);
                }
                else
                {
                    for (int i = 0; i < companies[companyName].Count; i++)
                    {
                        if (companies[companyName][i] == id)
                        {
                            repeating = true;
                            break;
                        }
                    }
                    if (!repeating)
                    {
                        companies[companyName].Add(id);
                    }
                }
                input = Console.ReadLine().Split(" -> ");
                repeating = false;
            }
            companies = companies.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value);
            foreach (var item in companies)
            {
                Console.WriteLine(item.Key);
                for (int i = 0; i < companies[item.Key].Count; i++)
                {
                    Console.WriteLine($"-- {companies[item.Key][i]}");
                }
            }
        }
    }
}
