
using Microsoft.Extensions.DependencyInjection;

namespace Base.Clean.Template.Infrastructure;

/// <summary>
/// Configure dependency injection of Infrastructure Layer
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
