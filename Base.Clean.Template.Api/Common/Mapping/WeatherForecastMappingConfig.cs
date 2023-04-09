using Base.Clean.Template.Application.WeatherForecastsApp.Common;
using Base.Clean.Template.Contracts.WeatherForecast;
using Mapster;

namespace Base.Clean.Template.Api.Common.Mapping;

public class WeatherForecastMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<WeatherForecastResult, WeatherForecastResponse>()
            .Map(dest => dest, src => src.WeatherForecast);
    }
}
