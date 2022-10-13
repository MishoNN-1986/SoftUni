using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.App.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(string[] args);
    }
}
