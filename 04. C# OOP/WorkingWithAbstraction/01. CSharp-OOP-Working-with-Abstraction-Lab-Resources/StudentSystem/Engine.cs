﻿
using StudentSystem.Entities;
using System;

namespace StudentSystem
{
    public class Engine
    {
        private readonly StudentData studentData; // може да бъде сетнато само от конструктора
        private readonly IInputOutputProvider inputOutputProvider;

        public Engine(StudentData studentData, IInputOutputProvider inputOutputProvider)
        {
            this.studentData = studentData;
            this.inputOutputProvider = inputOutputProvider;
        }

        public void Process()
        {
            while (true)
            {
                var line = this.inputOutputProvider.GetInput();
                var command = Command.Parse(line);

                var end = this.ExecuteCommand(command);
                if (end)
                {
                    break;
                }
            }
        }

        private bool ExecuteCommand(Command command)
        {
            var name = command.Name;
            var arguments = command.Arguments;
            switch (name)
            {
                case "Create":
                    this.studentData.Add(arguments[0], int.Parse(arguments[1]), double.Parse(arguments[2]));
                    break;
                case "Show":
                    var details = this.studentData.GetDetails(arguments[0]);
                    this.inputOutputProvider.GetOutPut(details);
                    break;
                case "Exit":
                    return true;
                    break;
            }
            return false;
        }
    }
}
