using _01._Forum.Forum.App.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.ViewModels
{
    public class ReplyViewModel : ContentViewModel, IReplyViewModel
    {
        public ReplyViewModel(string author, string content)
            : base(content)
        {
            this.Author = author;
        }

        public string Author { get; private set; }
    }
}
