using Base.Clean.Template.Domain.Models;

namespace Base.Clean.Template.Application.Common.Interfaces.Persistence;

public interface IWheaterForecastRepository
{
    Task<IList<WeatherForecast>> GetAllAsync();
}