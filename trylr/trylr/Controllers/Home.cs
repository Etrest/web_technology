using Microsoft.AspNetCore.Mvc;

namespace trylr.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
