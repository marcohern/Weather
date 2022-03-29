using Microsoft.AspNetCore.Mvc;

namespace Weather.Controllers;

[Route("[controller]")]
public class WeatherController : Controller {
    public IActionResult Index() {
        return View();
    }
}