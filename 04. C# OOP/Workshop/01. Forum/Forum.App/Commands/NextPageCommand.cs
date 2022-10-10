using _01._Forum.Forum.App.Contracts.Menus;
using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Commands
{
    public class NextPageCommand : ICommand
    {
        private ISession session;

        public NextPageCommand(ISession session)
        {
            this.session = session;
        }

        public IMenu Execute(params string[] args)
        {
            IMenu currentMenu = this.session.CurrentMenu;

            if (currentMenu is IPaginatedMenu paginatedMenu)
            {
                paginatedMenu.ChangePage();
            }

            return currentMenu;
        }
    }
}
