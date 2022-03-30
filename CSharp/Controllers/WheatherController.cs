using Microsoft.AspNetCore.Mvc;

namespace Weather.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : Controller {

    [HttpGet(Name = "Test")]
    public object Index() {
        return new {
            Success = true,
            Message = "OK"
        };
    }
}