namespace Weather.Entities
{
    public class ForecastGeometry
    {
        public string type { get; set; } = "";
        public List<List<List<double>>> coordinates { get; set; } = new List<List<List<double>>>();
    }
}