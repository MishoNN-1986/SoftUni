using _01._Forum.Forum.App.Contracts.Factories;
using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Commands
{
    public class CategoriesMenuCommand : ICommand
    {
        private IMenuFactory menuFactory;

        public CategoriesMenuCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string commandName = this.GetType().Name;
            string menuName = commandName.Substring(0, commandName.Length - "Command".Length);

            IMenu menu = this.menuFactory.CreateMenu(menuName);
            return menu;
        }
    }
}
