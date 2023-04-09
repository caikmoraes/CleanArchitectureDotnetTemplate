using Base.Clean.Template.Application.WeatherForecastsApp.Common;
using Base.Clean.Template.Domain.Models;
using MediatR;

namespace Base.Clean.Template.Application.WeatherForecastsApp.Queries;

public class GetWeatherForecastHandler : IRequestHandler<GetWeatherForecastQuery, List<WeatherForecastResult>>
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    public async Task<List<WeatherForecastResult>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        List<WeatherForecast> weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToList();

        return weatherForecasts.ConvertAll(w => new WeatherForecastResult(w)).ToList();
    }
}
