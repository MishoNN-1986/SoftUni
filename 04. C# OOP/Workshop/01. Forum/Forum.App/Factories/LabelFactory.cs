using _01._Forum.Forum.App.Contracts.Factories;
using _01._Forum.Forum.App.Contracts.Models;
using _01._Forum.Forum.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Factories
{
    public class LabelFactory : ILabelFactory
    {
        public ILabel CreateLabel(string contents, Position position, bool isHidden = false)
        {
            return new Label(contents, position, isHidden);
        }

        public IButton CreateButton(string contents, Position position, bool isHidden = false, bool isField = false)
        {
            return new Button(contents, position, isHidden, isField);
        }
    }
}
