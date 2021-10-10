using Microsoft.AspNetCore.Mvc;
using SmuzApp.Core.Interfaces;
using SmuzApp.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SmuzApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppLogger<HomeController> _logger;

        public HomeController(IAppLogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
