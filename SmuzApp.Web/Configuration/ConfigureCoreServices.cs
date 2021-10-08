using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmuzApp.Core.Interfaces;
using SmuzApp.Core.Services;
using SmuzApp.Infrastructure.Data;
using SmuzApp.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmuzApp.Web.Configuration
{
    public static class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            services.AddScoped<IAdminService, AdminService>();
            //services.AddSingleton<IUriComposer>(new UriComposer(configuration.Get<CatalogSettings>()));
            //services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<IEmailSender, EmailSender>();

            return services;
        }
    }
}
