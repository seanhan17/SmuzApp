using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuzApp.Core.Interfaces
{
    public interface IAdminService
    {
        Task CreateAdmin(string emailAddress);
    }
}
