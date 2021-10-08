using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmuzApp.Infrastructure.Identity;

[assembly: HostingStartup(typeof(SmuzApp.Web.Areas.Identity.IdentityHostingStartup))]
namespace SmuzApp.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<AppIdentityDbContext>(options =>
                //options.UseSqlServer(context.Configuration.GetConnectionString("IdentityConnection")));

                //services.AddIdentity<ApplicationUser, IdentityRole>()
                //        .AddEntityFrameworkStores<AppIdentityDbContext>();
            });
        }
    }
}