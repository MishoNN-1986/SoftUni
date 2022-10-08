using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Articles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Articles2> addAtrickes = new List<Articles2>();
            for (int i = 0; i < num; i++)
            {
                string[] articlesList = Console.ReadLine().Split(", ");
                Articles2 articles = new Articles2(articlesList[0], articlesList[1], articlesList[2]);

                addAtrickes.Add(articles);

            }
            string criteria = Console.ReadLine();
            switch (criteria)
            {
                case "title":
                    addAtrickes.Sort((a, b) => string.Compare(a.Title, b.Title));  // може и с addAtrickes.OrderByDescending(addAtrickes => addAtrickes.Title).ToList();, но няма да я запази !!!
                    break;
                case "content":
                    addAtrickes.Sort((a, b) => string.Compare(a.Content, b.Content));
                    break;
                case "author":
                    addAtrickes.Sort((a, b) => string.Compare(a.Author, b.Author));
                    break;
            }
            foreach (Articles2 list in addAtrickes)
            {
                Console.WriteLine(list);
            }

        }
    }
}
