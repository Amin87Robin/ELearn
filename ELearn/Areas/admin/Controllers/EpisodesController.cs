using Microsoft.AspNetCore.Mvc;

namespace ELearn.Areas.admin.Controllers
{
    public class EpisodesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
