namespace Rubencho.Application.Common.Context;

public interface IDbContext
{
    /// <summary>
    /// Save database changes.
    /// </summary>
    /// <returns>Number of affected rows.</returns>
    int SaveChanges();

    /// <summary>
    /// Save database changes.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Number of affected rows.</returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
