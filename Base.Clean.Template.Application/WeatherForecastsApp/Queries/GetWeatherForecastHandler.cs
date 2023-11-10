using Base.Clean.Template.Application.Common.Interfaces.Persistence;
using Base.Clean.Template.Application.WeatherForecastsApp.Common;
using Base.Clean.Template.Domain.Models;
using MediatR;

namespace Base.Clean.Template.Application.WeatherForecastsApp.Queries;

public class GetWeatherForecastHandler : IRequestHandler<GetWeatherForecastQuery, List<WeatherForecastResult>>
{
    private readonly IWheaterForecastRepository _wheaterForecastRepository;

    public GetWeatherForecastHandler(IWheaterForecastRepository wheaterForecastRepository)
    {
        _wheaterForecastRepository = wheaterForecastRepository;
    }

    public async Task<List<WeatherForecastResult>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        IList<WeatherForecast> weatherForecasts = await _wheaterForecastRepository.GetAllAsync();

        return weatherForecasts.ToList().ConvertAll(w => new WeatherForecastResult(w)).ToList();
    }
}
