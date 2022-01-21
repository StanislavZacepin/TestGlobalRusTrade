using Microsoft.AspNetCore.Mvc;

namespace TestGlobalRusTrade.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
