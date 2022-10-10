using _01._Forum.Forum.App.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App.ViewModels
{
    public class CategoryInfoViewModel : ICategoryInfoViewModel
    {
        public CategoryInfoViewModel(int id, string name, int postCount)
        {
            this.Id = id;
            this.Name = name;
            this.PostCount = postCount;
        }
        public int Id { get; private set; }

        public string Name { get; private set; }

        public int PostCount { get; private set; }
    }
}
