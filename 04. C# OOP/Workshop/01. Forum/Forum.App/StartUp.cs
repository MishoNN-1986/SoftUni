using _01._Forum.Forum.App.Contracts;
using _01._Forum.Forum.App.Contracts.Factories;
using _01._Forum.Forum.App.Contracts.Models;
using _01._Forum.Forum.App.Contracts.Services;
using _01._Forum.Forum.App.Factories;
using _01._Forum.Forum.App.Models;
using _01._Forum.Forum.App.Services;
using _01._Forum.Forum.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Forum.Forum.App
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServices();
            IMainController menu = serviceProvider.GetService<IMainController>();

            Engine engine = new Engine(menu);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<ITextAreaFactory, TextAreaFactory>();
            services.AddSingleton<ILabelFactory, LabelFactory>();
            services.AddSingleton<IMenuFactory, MenuFactory>();
            services.AddSingleton<ICommandFactory, CommandFactory>();

            services.AddSingleton<ForumData>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IUserService, UserService>();

            services.AddSingleton<ISession, Session>();
            services.AddSingleton<IForumViewEngine, ForumViewEngine>();
            services.AddSingleton<IMainController, MenuController>();

            services.AddTransient<IForumReader, ForumConsoleReader>();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}

