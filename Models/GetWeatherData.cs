using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WeatherApi_Core.Models
{
    public class GetWeatherData
    {
        public LocationData Location { get; set; }
        public CurrentWeatherData Current { get; set; }
        [Required]
        [Display(Name = "City Name")]
        public string City { get; set; }

    }
    public class LocationData
    {

        public string Name { get; set; }
        [Display(Name = "Region")]
        public string Region { get; set; }
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Display(Name = "Lattitude")]
        public double Lat { get; set; }
        [Display(Name = "Longitude")]
        public double Lon { get; set; }
        [Display(Name = "TzId")]
        [JsonPropertyName("tz_id")]
        public string TzId { get; set; }
        public int LocaltimeEpoch { get; set; }
        [Display(Name = "Local Time")]
        public string Localtime { get; set; }
    }

    public class CurrentWeatherData
    {
        [Display(Name = "Temperature In Celsius")]
        [JsonPropertyName("temp_c")]
        public double TempC { get; set; }
        [Display(Name = "Temperature In Fahrenheit")]
        [JsonPropertyName("temp_f")]
        public double TempF { get; set; }
        [Display(Name = "Last Updated On")]
        [JsonPropertyName("last_updated")]
        public string LastUpdateOn { get; set; }
        [Display(Name = "Wind Speed(KM/H)")]
        [JsonPropertyName("wind_kph")]
        public double Wind { get; set; }
        [Display(Name = "Humidity")]
        [JsonPropertyName("humidity")]
        public double Humidity { get; set; }
        [Display(Name = "Cloud")]
        [JsonPropertyName("cloud")]
        public double Cloud { get; set; }
        public Condition Condition { get; set; }
    }

    public class Condition
    {
        [Display(Name = "Current Condition")]
        public string Text { get; set; }
        public string Icon { get; set; }
        public int Code { get; set; }
    }

}
