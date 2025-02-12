using System.Text.Json.Serialization;
#pragma warning disable IDE0290
namespace AspireDemoApi.Types
{
    public class WeatherForecast
    {
        public WeatherForecast(DateOnly date, int temparatureC, string? summary)
        {
            this.Date = date;
            this.TemperatureC = temparatureC;
            this.Summary = summary;
        }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
#pragma warning restore IDE0290
