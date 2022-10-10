using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.ViewModels
{
    public interface IPostViewModel
    {
        string Title { get; }

        string Author { get; }

        string[] Content { get; }

        IReplyViewModel[] Replies { get; }
    }
}
