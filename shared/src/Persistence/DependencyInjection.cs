using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Rubencho.Persistence;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Defines extension methods to register services into the dependency injection container.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Add application services.
    /// </summary>
    /// <param name="services">Service collection.</param>
    /// <returns><see cref="IServiceCollection"/></returns>
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        // Registrar EF Core
        services.AddDbContext<RubenchoDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("RubenchoBackEndAPIContext")));

        return services;
    }
}