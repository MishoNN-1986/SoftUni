using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Models
{
    public interface IMenu
    {
        IButton CurrentOption { get; }

        ILabel[] Labels { get; }

        IButton[] Buttons { get; }

        void NextOption();

        void PreviousOption();

        IMenu ExecuteCommand();

        void Open();
    }
}
