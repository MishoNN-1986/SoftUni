using _01._Forum.Forum.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Models
{
    public interface IPositionable
    {
        Position Position { get; }
    }
}
