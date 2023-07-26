using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolManager.Infrastructure.Persistence;

namespace SchoolManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddPersistence();

            return services;
        }
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<SchoolManagerDbContext>(options =>
           options.UseSqlServer("Server=DESKTOP-HIUFAFC\\JOELFERREIRA2022;Initial Catalog=SchoolManager;Persist Security Info=False;User ID=sa;Password=innux123+;MultipleActiveResultSets=False;Encrypt=false;TrustServerCertificate=False;"));
            return services;
        }
    }
}