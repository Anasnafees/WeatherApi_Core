using Microsoft.AspNetCore.Mvc;
using WeatherApi_Core.Models;
using WeatherApi_Core.WeatherServices;

namespace WeatherApi_Core.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IGetWeatherService _weatherServices;

        public WeatherController(IGetWeatherService getWeatherService)
        {
            _weatherServices = getWeatherService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetWeather(GetWeatherData getWeatherData)
        {
            if (getWeatherData.City != null)
            {
                var weatherData = await _weatherServices.GetCurrentWeather(getWeatherData.City);
                if (weatherData != null)
                {
                    GetWeatherData GetWeatherData = new GetWeatherData();

                    GetWeatherData.City = weatherData.Location.Name;

                    GetWeatherData.Location = weatherData.Location;

                    GetWeatherData.Current = weatherData.Current;

                    GetWeatherData.Current.Condition = weatherData.Current.Condition;

                    Console.WriteLine("response : " + weatherData);
                    ViewBag.mssg = "SHOWING WEATHER UPDATE FOR : " + getWeatherData.City;
                    return View(GetWeatherData);
                }
                return View("Error");
            }
            else 
            {
                ModelState.AddModelError("CustomError", "Required Feild");
                return View("Index");
            }
        }
    }
}
