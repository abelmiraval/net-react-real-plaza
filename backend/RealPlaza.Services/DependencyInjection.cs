using RealPlaza.DataAccess.Implementations;
using RealPlaza.DataAccess.Interfaces;
using RealPlaza.Services.Implementations;
using RealPlaza.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace RealPlaza.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>()
                .AddTransient<IProductService, ProductService>();

            return services;
        }
    }
}