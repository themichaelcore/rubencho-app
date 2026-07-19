using System.Globalization;

namespace Rubencho.Application.Extensions;

public static class StringExtensions
{
    public static string IfNullOrEmpty(this string? source, string value)
        => string.IsNullOrEmpty(source) ? value : source;

    public static T Switch<T>(this bool source, T caseTrue, T caseFalse)
        => source ? caseTrue : caseFalse;

    public static T? Switch<T>(this bool? source, T caseTrue, T caseFalse)
        => source.HasValue ? (source.Value ? caseTrue : caseFalse) : default;

    public static T Switch<T>(this bool? source, T caseTrue, T caseFalse, T caseNull)
        => source.HasValue ? (source.Value ? caseTrue : caseFalse) : caseNull;

    public static string ToTitleCase(this string? source)
    {
        if (string.IsNullOrEmpty(source))
            return string.Empty;
        var textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(source.ToLowerInvariant());
    }

    /// <summary>
    /// Converts the input string to a string in currency format using en-US culture.
    /// </summary>
    /// <param name="source"></param>
    /// <param name="removeCurrencySymbol">Indicate true if you need to remove the currency symbol</param>
    /// <returns>Returns the converted string and if it's not a number or is null, returns that.</returns>
    public static string? ToCurrencyString(this string? source, bool removeCurrencySymbol = false)
    {
        if (decimal.TryParse(source, out decimal amount))
        {
            var usCulture = new CultureInfo("en-US", false);
            var currency = string.Format(usCulture, "{0:C}", amount);
            return removeCurrencySymbol ? currency[1..] : currency;
        }
        return source;
    }
}