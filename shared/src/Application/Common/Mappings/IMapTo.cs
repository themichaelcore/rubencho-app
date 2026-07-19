namespace Rubencho.Application.Common.Mappings;

/// <summary>
/// Defines mapping to.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IMapTo<T>
{
    /// <summary>
    /// Mapping.
    /// </summary>
    /// <param name="profile"></param>
    void Mapping(Profile profile) => profile.CreateMap(GetType(), typeof(T));
}