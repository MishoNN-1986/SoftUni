using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Models
{
    public class Button : IButton
    {
        public Button(string text, Position position, bool isHidden = false, bool isField = false)
        {
            this.Text = text;
            this.Position = position;
            this.IsHidden = isHidden;
            this.IsField = isField;
        }

        public string Text { get; }

        public bool IsHidden { get; }

        public bool IsField { get; }

        public Position Position { get; }
    }
}
