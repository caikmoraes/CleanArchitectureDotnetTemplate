using Base.Clean.Template.Application.WeatherForecastsApp.Common;
using MediatR;

namespace Base.Clean.Template.Application.WeatherForecastsApp.Queries;

public record GetWeatherForecastQuery() : IRequest<List<WeatherForecastResult>>;
