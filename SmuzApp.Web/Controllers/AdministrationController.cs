using Microsoft.AspNetCore.Mvc;
using SmuzApp.Core.Interfaces;
using SmuzApp.Web.ViewModels.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmuzApp.Web.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly IAppLogger<AdministrationController> _logger;

        public AdministrationController(
            IAppLogger<AdministrationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index(AdministrationViewModel model)
        {
            return View();
        }
    }
}
