using Microsoft.AspNetCore.Mvc;
using MyFirstMvcApp.Data;
using MyFirstMvcApp.Models;
using MyFirstMvcApp.Models.Home;
using MyFirstMvcApp.Services;
using System.Diagnostics;

namespace MyFirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersService userService;


        //private readonly ILogger<HomeController> _logger;
        //private readonly ApplicationDbContext dbContext;

        //public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        //{
        //    this._logger = logger;
        //    this.dbContext = dbContext;
        //}

        public HomeController(IUsersService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            //var usernames = this.dbContext.Users.Select(x => x.UserName).ToList();
            var usernames = this.userService.GetUserNames();
            var viewModel = new IndexViewModel { Usernames = usernames };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}