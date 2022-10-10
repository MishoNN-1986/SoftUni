using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Models
{
    public interface ITextInputArea
    {
        string Text { get; }

        void Write();

        void Render();
    }
}
