using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ShopCore.Infrastucture.Data;
using System.Threading.Tasks;

namespace ShopCore.WebApi.StartUp
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public static class StartUpMiddleWareExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
