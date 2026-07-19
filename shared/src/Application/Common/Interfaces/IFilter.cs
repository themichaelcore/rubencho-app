namespace Rubencho.Application.Common.Interfaces;

public interface IFilter<T>
{
    IQueryable<T> Filter(IQueryable<T> source);
}