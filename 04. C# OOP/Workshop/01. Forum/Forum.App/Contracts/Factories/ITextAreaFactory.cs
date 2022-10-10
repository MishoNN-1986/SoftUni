using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Factories
{
    public interface ITextAreaFactory
    {
        ITextInputArea CreateTextArea(IForumReader reader, int x, int y, bool isPost = true);
    }
}
