using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SmuzApp.Core.Interfaces;
using SmuzApp.Infrastructure.Identity;

namespace SmuzApp.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IAppLogger<LogoutModel> _logger;

        public LogoutModel(SignInManager<ApplicationUser> signInManager, IAppLogger<LogoutModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            try
            {
                // Clears the user's claims stored in a cookie.
                await _signInManager.SignOutAsync();
                _logger.LogInformation("User logged out.");
                if (returnUrl != null)
                {
                    return LocalRedirect(returnUrl);
                }
            }
            catch(Exception ex)
            {
                _logger.LogInformation("Error occured during log out", ex);
            }

            return Page();
        }
    }
}
