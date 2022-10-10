using _01._Forum.Forum.App.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Forum.Forum.App.ViewModels
{
    public class PostViewModel : ContentViewModel, IPostViewModel
    {
        public PostViewModel(string title, string author, string content, IEnumerable<IReplyViewModel> replies)
            : base(content)
        {
            this.Title = title;
            this.Author = author;
            this.Replies = replies.ToArray();
        }

        public string Title { get; private set; }

        public string Author { get; private set; }

        public IReplyViewModel[] Replies { get; private set; }
    }
}
