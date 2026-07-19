namespace Rubencho.Application.Common.Models;

public interface IPageable
{
    int PageNumber { get; }

    int PageSize { get; }
}