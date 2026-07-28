using Microsoft.AspNetCore.Mvc;

namespace dotnetCore.Training.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }
    }
}
