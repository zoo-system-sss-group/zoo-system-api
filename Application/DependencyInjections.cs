using Application.IRepositories;
using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjections
{
    public static IServiceCollection AddRepositoryDIs(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();

        return services;
    }
}
