using LUMIA_WEBSITE.DAL;
using LUMIA_WEBSITE.Models;
using Microsoft.AspNetCore.Mvc;

namespace LUMIA_WEBSITE.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Teams.ToList());
        }
        public IActionResult Create()

        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Team team)
        {

            return RedirectToAction("Index");   
        }
        
    }
}
