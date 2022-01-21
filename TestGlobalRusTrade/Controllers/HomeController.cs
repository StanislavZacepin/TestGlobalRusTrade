using Microsoft.AspNetCore.Mvc;
using TestGlobalRusTrade.Services.Data;

namespace TestGlobalRusTrade.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(weatherData._Weathers);
        }
    }
}
