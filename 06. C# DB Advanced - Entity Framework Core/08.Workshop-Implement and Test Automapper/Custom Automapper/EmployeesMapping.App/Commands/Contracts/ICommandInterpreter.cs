using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.App.Commands.Contracts
{
    public interface ICommandInterpreter
    {
        string Read(string[] args);
    }
}
