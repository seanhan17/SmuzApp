using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmuzApp.Web.ViewModels.AdminRole
{
    public class CreateAdminRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
