namespace WeatherForecastService.Controllers.Models
{
    public class WetheForecast
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TemperatureC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TemperatureF { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Summary => TemperatureC switch
        {
            <= -30 => "Freezing",
            <= -20 => "Bracing",
            <= -10 => "Chilly",
            <= 5 => "Cool",
            <= 10 => "Mild",
            <= 20 => "Warm",
            <= 30 => "Balmy",
            <= 35 => "Hot",
            _ => "No case availabe"
        };


    }
}
