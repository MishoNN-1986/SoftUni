using System;
using System.Collections.Generic;
using System.Linq;
namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> legendaryMaterial = new Dictionary<string, int>();
            legendaryMaterial.Add("shards", 0);
            legendaryMaterial.Add("fragments", 0);
            legendaryMaterial.Add("motes", 0);
            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();
            bool obtained = false;
            while (obtained == false)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                for (int i = 1; i <= input.Count - 1; i += 2)
                {
                    if (i % 2 == 1)
                    {
                        input[i] = input[i].ToLower();
                    }

                    if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                    {
                        legendaryMaterial[input[i]] += int.Parse(input[i - 1]);
                        if (legendaryMaterial[input[i]] >= 250)
                        {
                            if (input[i] == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                legendaryMaterial[input[i]] -= 250;
                                obtained = true;
                                break;
                            }
                            else if (input[i] == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                                legendaryMaterial[input[i]] -= 250;
                                obtained = true;
                                break;
                            }
                            else if (input[i] == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                legendaryMaterial[input[i]] -= 250;
                                obtained = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (!junkMaterial.ContainsKey(input[i]))
                        {
                            junkMaterial.Add(input[i], 0);
                        }
                        junkMaterial[input[i]] += int.Parse(input[i - 1]);
                    }
                }
            }
            legendaryMaterial = legendaryMaterial.OrderByDescending(a => a.Value).ThenBy(b => b.Key).ToDictionary(b => b.Key, a => a.Value);
            foreach (var m in legendaryMaterial)
            {
                Console.WriteLine($"{m.Key}: {m.Value}");
            }
            junkMaterial = junkMaterial.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);
            foreach (var j in junkMaterial)
            {
                Console.WriteLine($"{j.Key}: {j.Value}");
            }
        }
    }
}
