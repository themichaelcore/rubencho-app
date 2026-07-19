namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Configures services for AdminApi.
/// </summary>
public static class ConfigureServices
{
    /// <summary>
    /// Add required services to Admin Api.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configurationManager"></param>
    /// <returns></returns>
    public static IServiceCollection AddWebServices(this IServiceCollection services, ConfigurationManager configurationManager)
    {
        services.AddCors(options => {
            options.AddPolicy("AngularAppPolicy", policy => {
                policy.WithOrigins("http://localhost:4200")
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
        });

        return services;
    }
}
