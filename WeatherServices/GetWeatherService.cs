using WeatherApi_Core.Models;

namespace WeatherApi_Core.WeatherServices
{
    public class GetWeatherService
    {

        private readonly IWeatherApiConfiguration _weatherApiConfiguration;
        //Used IHttpClientFactory To Create An Instance For HttpClient Instance//
        private readonly IHttpClientFactory _httpClientFactory;

        //Constructor
        public GetWeatherService(IHttpClientFactory httpClientFactory, IWeatherApiConfiguration weatherApiConfiguration)
        {
            _weatherApiConfiguration = weatherApiConfiguration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<GetWeatherData> GetCurrentWeather(string city)
        {
            string CurrentApiUrl = $"http://api.weatherapi.com/v1/current.json?Key={_weatherApiConfiguration.ApiKey}&q={city}";
            var GetHttpClient = _httpClientFactory.CreateClient(); //HttpClient Instance

            try 
            {
                HttpResponseMessage response = await GetHttpClient.GetAsync(CurrentApiUrl);
                response.EnsureSuccessStatusCode();
                var weatherData = await response.Content.ReadFromJsonAsync<GetWeatherData>();
                return weatherData;
            }
            catch (HttpRequestException ex) 
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
