using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.ViewModels
{
    public interface IReplyViewModel
    {
        string Author { get; }

        string[] Content { get; }
    }
}
