using Application.IRepositories;
using Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjections
{
    public static IServiceCollection AddRepositoryDIs(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<INewsRepository, NewsRepository>();
        services.AddScoped<ISpeciesRepository, SpeciesRepository>();
        services.AddScoped<IAnimalRepository, AnimalRepsository>();
        services.AddScoped<IAreaRepository, AreaRepository>();
        services.AddScoped<ICageRepository, CageRepository>();
        services.AddScoped<IDietRepository, DietRepository>();
        services.AddScoped<ITicketRepository, TicketRepository>();
        services.AddScoped<ITicketOrderRepository, TicketOrderRepository>();
        services.AddScoped<IFeedHistoryRepository, FeedHistoryRepository>();
        services.AddScoped<ICageHistoryRepository, CageHistoryRepository>();
        services.AddScoped<ITrainingDetailRepository, TrainingDetailRepository>();
        return services;
    }
}
