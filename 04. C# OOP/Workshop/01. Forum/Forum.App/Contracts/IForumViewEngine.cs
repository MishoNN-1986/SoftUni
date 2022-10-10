using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts
{
    public interface IForumViewEngine
    {
        void RenderMenu(IMenu menu);

        void Mark(ILabel label, bool highlighted = true);

        void SetBufferHeight(int rows);

        void ResetBuffer();
    }
}
