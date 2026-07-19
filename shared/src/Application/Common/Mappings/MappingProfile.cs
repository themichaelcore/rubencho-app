using System.Reflection;

namespace Rubencho.Application.Common.Mappings;

/// <summary>
/// Defines the mapping profile.
/// </summary>
public class MappingProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MappingProfile"/> class.
    /// </summary>
    public MappingProfile()
    {
        ApplyDestinationMappingsFromAssembly(Assembly.GetExecutingAssembly());
        ApplySourceMappingsFromAssembly(Assembly.GetExecutingAssembly());
    }

    /// <summary>
    /// Applys mappings.
    /// </summary>
    /// <param name="assembly"></param>
    private void ApplyDestinationMappingsFromAssembly(Assembly assembly)
    {
        var types = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
            .ToList();

        foreach (var type in types)
        {
            var instance = Activator.CreateInstance(type);

            var methodInfo = type.GetMethod("Mapping")
                ?? type.GetInterface("IMapFrom`1")?.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });
        }
    }

    /// <summary>
    /// Applys mappings.
    /// </summary>
    /// <param name="assembly"></param>
    private void ApplySourceMappingsFromAssembly(Assembly assembly)
    {
        var types = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapTo<>)))
            .ToList();

        foreach (var type in types)
        {
            var instance = Activator.CreateInstance(type);

            var methodInfo = type.GetMethod("Mapping")
                ?? type.GetInterface("IMapTo`1")?.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });
        }
    }
}