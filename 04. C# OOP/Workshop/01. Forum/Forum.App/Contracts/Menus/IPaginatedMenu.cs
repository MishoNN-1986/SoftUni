using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Menus
{
    public interface IPaginatedMenu
    {
        void ChangePage(bool forward = true);
    }
}
