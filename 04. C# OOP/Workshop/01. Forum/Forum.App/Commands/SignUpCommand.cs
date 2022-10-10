using _01._Forum.Forum.App.Contracts.Factories;
using _01._Forum.Forum.App.Contracts.Models;
using _01._Forum.Forum.App.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Commands
{
    public class SignUpCommand : ICommand
    {
        private IUserService userService;
        private IMenuFactory menuFactory;

        public SignUpCommand(IUserService userService, IMenuFactory menuFactory)
        {
            this.userService = userService;
            this.menuFactory = menuFactory;
        }

        public IMenu Execute(params string[] args)
        {
            string username = args[0];
            string password = args[1];

            bool success = this.userService.TrySignUpUser(username, password);

            if (!success)
            {
                throw new InvalidOperationException("Invalid login!");
            }

            return this.menuFactory.CreateMenu("MainMenu");
        }
    }
}
