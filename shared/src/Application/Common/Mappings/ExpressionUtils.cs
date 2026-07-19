using System.Linq.Expressions;

namespace Rubencho.Application.Common.Mappings;

public static class ExpressionUtils
{
    public static Expression<Func<T, object>> PropertyOrField<T>(string propertyOrFieldName)
    {
        var param = Expression.Parameter(typeof(T));
        var body = Expression.PropertyOrField(param, propertyOrFieldName);

        var conversion = Expression.Convert(body, typeof(object));

        return Expression.Lambda<Func<T, object>>(conversion, param);
    }
}