using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context.Repositories;
using CleanArchMvc.Application.Services;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Mappings;

namespace CleanArchMvc.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;            
        }
    }
}
