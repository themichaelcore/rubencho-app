using Rubencho.Domain.Common;

namespace Rubencho.Application.Extensions;

public static class MappingExpressionExtensions
{
    public static IMappingExpression<TSource, TDestination> IgnoreAuditory<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        where TDestination : AuditableEntity
    {
        expression
            .ForMember(d => d.Created, opt => opt.Ignore())
            .ForMember(d => d.CreatedBy, opt => opt.Ignore())
            .ForMember(d => d.LastModified, opt => opt.Ignore())
            .ForMember(d => d.LastModifiedBy, opt => opt.Ignore());

        return expression;
    }

    public static IMappingExpression<TSource, TDestination> IgnoreRowVersion<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        where TDestination : IConcurrent
    {
        expression
            .ForMember(d => d.RowVersion, opt => opt.Ignore());

        return expression;
    }

    public static IMappingExpression<TSource, TDestination> IgnoreSequence<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        where TDestination : ISequenciable
    {
        expression
            .ForMember(d => d.Sequence, opt => opt.Ignore());

        return expression;
    }
}