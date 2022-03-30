namespace Weather.Entities
{
    public class WeatherLocationProperties
    {
        public string city { get; set; } = "";
        public string state { get; set; } = "";
        public UnitCodeValue? distance { get; set; } = null;
        public UnitCodeValue? bearing { get; set; } = null;
    }
}