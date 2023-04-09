
using Base.Clean.Template.Application.WeatherForecastsApp.Common;
using Base.Clean.Template.Application.WeatherForecastsApp.Queries;
using Base.Clean.Template.Contracts.WeatherForecast;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Base.Clean.Template.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator, IMapper mapper)
    {
        _logger = logger;
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<List<WeatherForecastResponse>> Get()
    {
        _logger.LogInformation("Getting weather forecast using clean archtecture principles with mapster and mediatr");
        List<WeatherForecastResult> getWeatherForecastsResult = await _mediator.Send(new GetWeatherForecastQuery());

        return getWeatherForecastsResult.ConvertAll(w => _mapper.Map<WeatherForecastResponse>(w));
    }
}
