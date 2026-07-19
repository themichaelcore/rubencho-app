namespace Rubencho.Domain.Common;

/// <summary>
/// Interface for domain events.
/// </summary>
public interface IHasDomainEvent
{
    /// <summary>
    /// Gets or sets the list of domain events.
    /// </summary>
    public List<DomainEvent> DomainEvents { get; set; }
}