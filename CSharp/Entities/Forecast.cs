
namespace Weather.Entities;

public class Forecast
{
    public string type { get; set; } = "";
    public ForecastGeometry? geometry { get; set; }
    public ForecastProperties? properties { get; set; }
}