namespace Weather.Entities
{
    public class WeatherProperties
    {
        public string cwa { get; set; } = "";
        public string forecastOffice { get; set; } = "";
        public string gridId { get; set; } = "";
        public int gridX { get; set; }
        public int gridY { get; set; }
        public string forecast { get; set; } = "";
        public string forecastHourly { get; set; } = "";
        public string forecastGridData { get; set; } = "";
        public string observationStations { get; set; } = "";
        public RelativeLocation? relativeLocation { get; set; } = null;
        public string forecastZone { get; set; } = "";
        public string county { get; set; } = "";
        public string fireWeatherZone { get; set; } = "";
        public string timeZone { get; set; } = "";
        public string radarStation { get; set; } = "";
    }
}