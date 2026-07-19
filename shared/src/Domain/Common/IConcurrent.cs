namespace Rubencho.Domain.Common;

/// <summary>
/// Interface for IConcurrent entities.
/// </summary>
public interface IConcurrent
{
    /// <summary>
    /// Gets or sets the row version.
    /// </summary>
    public byte[] RowVersion { get; set; }
}