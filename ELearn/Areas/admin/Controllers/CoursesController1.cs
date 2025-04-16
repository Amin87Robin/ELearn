using Microsoft.AspNetCore.Mvc;

namespace ELearn.Areas.admin.Controllers
{
    public class CoursesController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
