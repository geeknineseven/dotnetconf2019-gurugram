using Microsoft.AspNetCore.Mvc;

namespace DemoNetConf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}