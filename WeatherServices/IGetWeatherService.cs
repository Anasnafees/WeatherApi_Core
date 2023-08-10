using WeatherApi_Core.Models;

namespace WeatherApi_Core.WeatherServices
{
    public interface IGetWeatherService
    {
        Task<GetWeatherData> GetCurrentWeather(string city);
    }
}