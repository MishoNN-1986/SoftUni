using _01._Forum.Forum.App.Contracts.Factories;
using _01._Forum.Forum.App.Contracts.Menus;
using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Commands
{
    class AddReplyCommand : ICommand
    {
        private IMenuFactory menuFactory;

        public AddReplyCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string commandName = this.GetType().Name;
            string menuName = commandName.Substring(0, commandName.Length - "Command".Length) + "Menu";

            IMenu menu = this.menuFactory.CreateMenu(menuName);

            int postId = int.Parse(args[0]);
            if (menu is IIdHoldingMenu idHoldingMenu)
            {
                idHoldingMenu.SetId(postId);
            }
            return menu;
        }
    }
}
