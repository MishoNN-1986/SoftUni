using System;
using System.Collections.Generic;
using System.Text;

namespace _03Articles2
{
    class Articles2
    {
        public Articles2(string rename, string newContent, string changeAuthor)
        {
            Content = newContent;/////////
            Author = changeAuthor;
            Title = rename;
            //ArticlesList = new List<Articles2>();
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        //public List<Articles2> ArticlesList { get; set; }

        public override string ToString()
        {
            string res = $"{Title} - {Content}: {Author}";
            return res;
        }
    }
}
