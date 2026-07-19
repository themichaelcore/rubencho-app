namespace Rubencho.Domain.Common;

/// <summary>
/// Interface for isequenciable entities.
/// </summary>
public interface ISequenciable
{
    /// <summary>
    /// Gets or sets the entity sequence.
    /// </summary>
    public int Sequence { get; set; }
}