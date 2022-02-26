using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    private readonly ILogger<WeatherForecastController> _logger;
    private WeatherForecastController controller;

    public UnitTest1(ILogger<WeatherForecastController> logger) 
    {
        _logger = logger;
        controller = new WeatherForecastController(_logger);
    }

    [Fact]
    public void Test1()
    {
        var returnValue = controller.Get();
        Assert.Equal("[{\"date\":\"2022-02-26T20:57:35.2819187-05:00\",\"temperatureC\":16,\"temperatureF\":60,\"summary\":\"Chilly\"},{\"date\":\"2022-02-27T20:57:35.2819292-05:00\",\"temperatureC\":47,\"temperatureF\":116,\"summary\":\"Chilly\"},{\"date\":\"2022-02-28T20:57:35.2819298-05:00\",\"temperatureC\":52,\"temperatureF\":125,\"summary\":\"Freezing\"},{\"date\":\"2022-03-01T20:57:35.2819302-05:00\",\"temperatureC\":23,\"temperatureF\":73,\"summary\":\"Freezing\"},{\"date\":\"2022-03-02T20:57:35.2819306-05:00\",\"temperatureC\":42,\"temperatureF\":107,\"summary\":\"Sweltering\"}]", returnValue.ToString());
    }
}