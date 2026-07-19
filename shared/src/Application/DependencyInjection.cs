using System.Reflection;

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
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg =>
            cfg.AddMaps(Assembly.GetExecutingAssembly()));

        //services.AddAutoMapper(typeof(Program));
        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}