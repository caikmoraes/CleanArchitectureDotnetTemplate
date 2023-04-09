using System.Reflection;
using Mapster;
using MapsterMapper;

namespace Base.Clean.Template.Api;

/// <summary>
/// Configure dependency injection of Presentation Layer
/// </summary>
public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
@*
#if (SwaggerSupport)
        services.AddSwaggerGen();
#endif*@
        services.AddMappings();

        return services;
    }

    private static IServiceCollection AddMappings(this IServiceCollection services)
    {
        TypeAdapterConfig config = TypeAdapterConfig.GlobalSettings;

        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);

        services.AddScoped<IMapper, ServiceMapper>();

        return services;
    }
}
