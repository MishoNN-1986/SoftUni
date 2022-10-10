using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Models
{
    public interface ILabel : IPositionable
    {
        string Text { get; }

        bool IsHidden { get; }
    }
}
