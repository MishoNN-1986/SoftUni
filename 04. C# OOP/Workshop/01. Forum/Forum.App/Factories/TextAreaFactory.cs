using _01._Forum.Forum.App.Contracts.Factories;
using _01._Forum.Forum.App.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _01._Forum.Forum.App.Factories
{
    public class TextAreaFactory : ITextAreaFactory
    {
        public ITextInputArea CreateTextArea(IForumReader reader, int x, int y, bool isPost = true)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type commandType = assembly.GetTypes().FirstOrDefault(t => typeof(ITextInputArea).IsAssignableFrom(t));

            if (commandType == null)
            {
                throw new InvalidOperationException("TextArea not found!");
            }

            object[] args = new object[] { reader, x, y, isPost };

            ITextInputArea commandInstance = (ITextInputArea)Activator.CreateInstance(commandType, args);

            return commandInstance;
        }
    }
}
