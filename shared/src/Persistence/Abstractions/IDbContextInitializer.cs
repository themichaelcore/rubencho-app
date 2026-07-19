namespace Rubencho.Persistence.Abstractions;

public interface IDbContextInitializer
{
    Task InitializeAsync();
}
