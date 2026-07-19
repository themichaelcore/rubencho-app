using Rubencho.Domain.Enums;

namespace Rubencho.Domain.Common;

public interface IWithStatus
{
    EntityStatus StatusId { get; set; }
}