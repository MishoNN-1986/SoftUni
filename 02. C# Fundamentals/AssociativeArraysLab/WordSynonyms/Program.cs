using System;
using System.Collections.Generic;
using System.Linq;
namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();
            for (int i = 1; i <= num; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonims.ContainsKey(word))
                {
                    var list = synonims[word];
                    list.Add(synonym);
                }
                else
                {
                    synonims.Add(word, new List<string> { synonym });
                }
            }
            foreach (var synonym in synonims)
            {
                Console.Write($"{synonym.Key} - ");
                for (int j = 0; j < synonym.Value.Count; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(synonym.Value[j]);
                    }
                    else
                    {
                        Console.Write($", {synonym.Value[j]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
