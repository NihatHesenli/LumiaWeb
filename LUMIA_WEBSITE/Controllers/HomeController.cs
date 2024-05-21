using Microsoft.AspNetCore.Mvc;

namespace LUMIA_WEBSITE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
