using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using WebApplication3.Controllers;

namespace NUnitTestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            var serviceProvider = new ServiceCollection()
     .AddLogging()
     .BuildServiceProvider();

            var factory = serviceProvider.GetService<ILoggerFactory>();

            var logger = factory.CreateLogger<WeatherForecastController>();
            WeatherForecastController weatherForecastController = new WeatherForecastController(logger);
            weatherForecastController.TestTestCover();
         //   Assert.Pass();
        }
    }
}