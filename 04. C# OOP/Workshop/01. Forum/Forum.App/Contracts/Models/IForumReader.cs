using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Models
{
    public interface IForumReader
    {
        string ReadLine();

        string ReadLine(int left, int top);

        void HideCursor();

        void ShowCursor();
    }
}
