using Autobrawl.Engine.Mechanics;
using Microsoft.Extensions.DependencyInjection;

namespace Autobrawl.Engine.Config;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEngine(this IServiceCollection services)
    {
        services.AddManagers();
        return services;
    }

    private static IServiceCollection AddManagers(this IServiceCollection services)
    {
        services.AddScoped<BoardManager>();
        services.AddScoped<DeckManager>();
        services.AddScoped<ChampionManager>();
        services.AddScoped<GameStateManager>();
        services.AddScoped<MatchManager>();
        services.AddScoped<PhaseManager>();
        services.AddScoped<RoundManager>();

        return services;
    }
}