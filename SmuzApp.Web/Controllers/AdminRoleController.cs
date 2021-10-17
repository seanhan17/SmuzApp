using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmuzApp.Core.Interfaces;
using SmuzApp.Web.Common.Enum;
using SmuzApp.Web.Common.Models;
using SmuzApp.Web.ViewModels.AdminRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmuzApp.Web.Controllers
{
    public class AdminRoleController : Controller
    {
        public readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAppLogger<AdminRoleController> _logger;

        public AdminRoleController(RoleManager<IdentityRole> roleManager,
            IAppLogger<AdminRoleController> logger)
        {
            _roleManager = roleManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> CreateAdminRole(CreateAdminRoleViewModel model)
        {
            ResponseModel response = new ResponseModel();

            try
            {
                if (ModelState.IsValid)
                {
                    var isRoleExist = await _roleManager.RoleExistsAsync(model.RoleName);

                    if (!isRoleExist)
                    {
                        var result = await _roleManager.CreateAsync(new IdentityRole(model.RoleName));

                        if (result.Succeeded)
                        {
                            response.ResultCode = ResultCode.SUCCESS;
                            response.ResultMessage = "User role has been successfully created.";
                        }
                        else
                        {
                            response.ResultMessage = "An error occured while creating the user role";

                            foreach (var error in result.Errors)
                            {
                                response.ErrorMessage.Add(error.Description);
                            }
                        }
                    }
                    else
                    {
                        response.ResultMessage = "An error occured while creating the user role";
                        response.ErrorMessage.Add("User role is already exists");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Create Role", ex);
            }

            return Json(response);
        }
    }
}
