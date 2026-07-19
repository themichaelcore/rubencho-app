using Rubencho.Application.Common.Interfaces;
using Rubencho.Application.Common.Models;

namespace Rubencho.Application.Common.Mappings;

public static class QueryableExtensions
{
    public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, ISortable sortable)
    {
        if (string.IsNullOrEmpty(sortable?.SortField))
            return source;

        var expression = ExpressionUtils.PropertyOrField<T>(sortable.SortField);

        source = sortable.SortDirection == SortDirection.Ascending
            ? source.OrderBy(expression)
            : source.OrderByDescending(expression);

        return source;
    }

    public static IQueryable<TSource> FilterBy<TSource>(this IQueryable<TSource> source, IFilter<TSource> filter)
    {
        return filter.Filter(source);
    }
}