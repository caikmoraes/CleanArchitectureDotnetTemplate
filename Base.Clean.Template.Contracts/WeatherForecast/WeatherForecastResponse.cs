namespace Base.Clean.Template.Contracts.WeatherForecast;

public record WeatherForecastResponse(
    DateOnly Date,
    int TemperatureC,
    int TemperatureF,
    string? Summary
);
