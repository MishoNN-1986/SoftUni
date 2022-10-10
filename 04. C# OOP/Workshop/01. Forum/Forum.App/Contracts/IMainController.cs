using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts
{
    public interface IMainController
    {
        void MarkOption();

        void UnmarkOption();

        void NextOption();

        void PreviousOption();

        void Back();

        void Execute();
    }
}
