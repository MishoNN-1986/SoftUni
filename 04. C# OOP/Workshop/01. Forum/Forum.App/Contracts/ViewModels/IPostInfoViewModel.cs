using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.ViewModels
{
    public interface IPostInfoViewModel
    {
        int Id { get; }

        string Title { get; }

        int ReplyCount { get; }
    }
}
