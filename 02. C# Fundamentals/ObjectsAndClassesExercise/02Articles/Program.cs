using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            //article.Title = input[0];
            //article.Content = input[1];
            //article.Author = input[2];

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }
            Console.WriteLine(article);

            //Console.WriteLine(article.ToString()); // може и без ToString()
        }
    }
}
