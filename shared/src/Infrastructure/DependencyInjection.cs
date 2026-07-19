using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Rubencho.Application.Common.Context;
using Rubencho.Persistence;
using Rubencho.Persistence.Abstractions;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Defines extension methods to register services into the dependency injection container.
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        if (configuration.GetValue<bool>("UseInMemoryDatabase"))
        {
            //services.AddDbContext<RubenchoDbContext>(options =>
            //    options.UseInMemoryDatabase("RubenchoDb"));
        }
        else
        {
            services.AddDbContext<RubenchoDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("RubenchoDb"),
                    b => b.MigrationsAssembly(typeof(RubenchoDbContext).Assembly.FullName)));
        }

        //services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddScoped<IDbContextInitializer, RubenchoDbContextInitializer>();

        services.AddScoped<IRubenchoDbContext>(provider => provider.GetRequiredService<RubenchoDbContext>());

        return services;
    }
}
