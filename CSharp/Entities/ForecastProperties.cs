namespace Weather.Entities
{
    public class ForecastProperties
    {
        public DateTime updated { get; set; }
        public string units { get; set; } = "";
        public string forecastGenerator { get; set; } = "";
        public DateTime generatedAt { get; set; }
        public DateTime updateTime { get; set; }
        //public DateTime validTimes { get; set; } //not sure what type this is

        public UnitCodeValue? elevation { get; set; }
        public List<ForecastPeriod> periods { get; set; } = new List<ForecastPeriod>();
    }
}