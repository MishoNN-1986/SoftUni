using _01._Forum.Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.Contracts.Services
{
    public interface IUserService
    {
        bool TrySignUpUser(string username, string password);

        bool TryLogInUser(string username, string password);

        string GetUserName(int userId);

        User GetUserById(int userId);
    }
}
