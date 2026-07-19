namespace Rubencho.Domain.Common;

/// <summary>
/// Defines the base class for a domain event.
/// </summary>
public abstract class DomainEvent
{
    /// <summary>
    /// Gets or sets a value to indicate if the domain event has been published or not.
    /// </summary>
    public bool IsPublished { get; set; }

    /// <summary>
    /// Gets the occurrency date time.
    /// </summary>
    public DateTimeOffset DateOccurred { get; protected set; } = DateTime.UtcNow;
}