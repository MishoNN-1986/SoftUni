using System;
using System.Collections.Generic;
using System.Text;

namespace _02Articles
{
    class Article
    {
        public Article(string rename, string newContent, string changeAuthor)
        {
            Content = newContent;/////////
            Author = changeAuthor;
            Title = rename;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            string res = $"{Title} - {Content}: {Author}";
            return res;
        }
    }
}
