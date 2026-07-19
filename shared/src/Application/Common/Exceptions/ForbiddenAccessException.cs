namespace Rubencho.Application.Common.Exceptions;

/// <summary>
/// Defines the forbidden access exception.
/// </summary>
public class ForbiddenAccessException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForbiddenAccessException"/> class.
    /// </summary>
    public ForbiddenAccessException()
        : base()
    {
    }
}