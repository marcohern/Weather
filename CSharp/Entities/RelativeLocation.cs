namespace Weather.Entities
{
    public class RelativeLocation
    {
        public string type { get; set; } = "";
        public WeatherGeometry? geometry { get; set; } = null;
        public WeatherLocationProperties? properties { get; set; } = null;
    }
}