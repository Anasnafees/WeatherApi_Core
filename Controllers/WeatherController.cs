﻿using Microsoft.AspNetCore.Mvc;
using WeatherApi_Core.Models;
using WeatherApi_Core.WeatherServices;

namespace WeatherApi_Core.Controllers
{
    public class WeatherController : Controller
    {
        private readonly GetWeatherService _weatherServices;

        public WeatherController(GetWeatherService getWeatherService)
        {
            _weatherServices = getWeatherService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetWeather(GetWeatherData getWeatherData)
        {
            var weatherData = await _weatherServices.GetCurrentWeather(getWeatherData.City);
            GetWeatherData GetWeatherData = new GetWeatherData();

            GetWeatherData.City = weatherData.Location.Name;

            GetWeatherData.Location = weatherData.Location;

            GetWeatherData.Current = weatherData.Current;

            GetWeatherData.Current.Condition = weatherData.Current.Condition;

            if (weatherData != null)
            {
                Console.WriteLine("response : " + weatherData);
                return View(GetWeatherData);
            }
            return View("Error");
        }
    }
}