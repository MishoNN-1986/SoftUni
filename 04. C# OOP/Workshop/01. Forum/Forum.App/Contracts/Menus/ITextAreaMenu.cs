﻿using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Menus
{
    public interface ITextAreaMenu : IMenu
    {
        ITextInputArea TextArea { get; }
    }
}
