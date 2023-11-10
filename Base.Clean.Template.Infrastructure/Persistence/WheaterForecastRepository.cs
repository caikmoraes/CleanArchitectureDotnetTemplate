using Base.Clean.Template.Application.Common.Interfaces.Persistence;
using Base.Clean.Template.Domain.Models;

namespace Base.Clean.Template.Infrastructure.Persistence;

public class WheaterForecastRepository : IWheaterForecastRepository
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


    public async Task<IList<WeatherForecast>> GetAllAsync()
    {
        await Task.CompletedTask;
        List<WeatherForecast> weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();

        return weatherForecasts;
    }
}