using _01._Forum.Forum.App.Contracts.Models;
using _01._Forum.Forum.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Factories
{
    public interface ILabelFactory
    {
        ILabel CreateLabel(string content, Position position, bool isHidden = false);

        IButton CreateButton(string content, Position position, bool isHidden = false, bool isField = false);
    }
}
