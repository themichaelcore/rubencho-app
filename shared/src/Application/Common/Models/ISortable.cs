namespace Rubencho.Application.Common.Models;

public interface ISortable
{
    string? SortField { get; }

    SortDirection SortDirection { get; }
}