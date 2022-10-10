using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.ViewModels
{
    public interface ICategoryInfoViewModel
    {
        int Id { get; }

        string Name { get; }

        int PostCount { get; }
    }
}
