using Microsoft.AspNetCore.Mvc;

namespace ELearn.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
