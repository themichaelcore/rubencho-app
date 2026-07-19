namespace Rubencho.Domain.Common;

/// <summary>
/// Defines the base class for auditable entities.
/// </summary>
public abstract class AuditableEntity
{
    /// <summary>
    /// Gets or sets the creation date time.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the created by.
    /// </summary>
    public string CreatedBy { get; set; } = default!;

    /// <summary>
    /// Gets or sets the last modification date time.
    /// </summary>
    public DateTime? LastModified { get; set; }

    /// <summary>
    /// Gets or sets last modification by.
    /// </summary>
    public string LastModifiedBy { get; set; } = string.Empty;
}