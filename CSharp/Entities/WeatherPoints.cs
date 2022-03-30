namespace Weather.Entities
{
    public class WeatherPoints
    {
        public string id { get; set; } = "";
        public string type { get; set; } = "";
        public WeatherGeometry? geometry { get; set; } = null;
        public WeatherProperties? properties { get; set; } = null;
    }
}