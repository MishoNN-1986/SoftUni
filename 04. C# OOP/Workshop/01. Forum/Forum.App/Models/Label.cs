using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Models
{
    internal class Label : ILabel
    {
        public Label(string text, Position position, bool isHidden = false)
        {
            this.Text = text;
            this.Position = position;
            this.IsHidden = isHidden;
        }

        public string Text { get; }

        public bool IsHidden { get; }

        public Position Position { get; }
    }
}
