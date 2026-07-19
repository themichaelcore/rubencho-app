using FluentValidation.Results;

namespace Rubencho.Application.Common.Exceptions;

/// <summary>
/// Defines the validation exception.
/// </summary>
public class ValidationException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationException"/> class.
    /// </summary>
    public ValidationException()
            : base("One or more validation failures have occurred.")
    {
        Errors = new Dictionary<string, string[]>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationException"/> class.
    /// </summary>
    /// <param name="failures">Errors.</param>
    public ValidationException(IEnumerable<ValidationFailure> failures)
        : this()
    {
        Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
    }
    /// <summary>
    /// Create Validation Exception with custom message
    /// </summary>
    /// <param name="message"></param>
    public ValidationException(string message)
            : base(message)
    {
        Errors = new Dictionary<string, string[]>();
        Errors["validation"] = new string[] { message };
    }
    /// <summary>
    /// Gets the errors.
    /// </summary>
    public IDictionary<string, string[]> Errors { get; }
}