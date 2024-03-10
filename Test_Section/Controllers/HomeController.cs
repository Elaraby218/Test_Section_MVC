using Microsoft.AspNetCore.Mvc;

namespace Test_Section.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
