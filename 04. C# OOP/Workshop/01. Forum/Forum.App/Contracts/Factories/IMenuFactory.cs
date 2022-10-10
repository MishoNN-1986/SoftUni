using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Factories
{
    public interface IMenuFactory
    {
        IMenu CreateMenu(string menuName);
    }
}
