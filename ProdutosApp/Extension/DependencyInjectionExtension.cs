using ProdutosApp.Domain.Interface;
using ProdutosApp.Domain.Services;
using ProdutosApp.Data.Repositories;

namespace ProdutosApp.Extension
{
    public static class DependencyInjectionExtension
    {

        public static IServiceCollection AddDependencyInjection(this IServiceCollection services) { 
        
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();
            services.AddTransient<IProdutoRepository, ProdutoRepositories>();

            return services;
        }
    }
}
