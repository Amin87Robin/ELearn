using ELearn.Core.Interfaces;
using ELearn.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ELearn.Areas.admin.Controllers
{
    [Area("Admin")]
    public class CourseGroupsController : Controller
    {
        
        private readonly ICourseGroup _courseGroupServices;
        public CourseGroupsController(ICourseGroup courseGroupServices)
        {
            _courseGroupServices = courseGroupServices;
        }
        public IActionResult Index()
        {
            List<CourseGroup> courseGroups = _courseGroupServices.GetCourseGroup().ToList();
            return View();
        }
    }
}
