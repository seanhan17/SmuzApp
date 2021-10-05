using SmuzApp.Core.AdminAggregrate;
using SmuzApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuzApp.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAsyncRepository<Admin> _adminRepository;
        //private readonly IAppLogger<AdminService> _logger;

        public AdminService(IAsyncRepository<Admin> adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task CreateAdmin(string emailAddress)
        {

        }
    }
}