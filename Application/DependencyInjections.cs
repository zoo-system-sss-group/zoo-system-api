using Application.IRepositories;
using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjections
{
    public static IServiceCollection AddRepositoryDIs(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ISpeciesRepository, SpeciesRepository>();
        services.AddScoped<IAnimalRepository, AnimalRepsository>();
        services.AddScoped<IAreaRepository, AreaRepository>();
        services.AddScoped<ICageRepository, CageRepository>();

        return services;
    }
}
