namespace Weather.Entities
{
    public class WeatherGeometry
    {
        public string type { get; set; } = "";
        public List<double> coordinates { get; set; } = new List<double>();
    }
}