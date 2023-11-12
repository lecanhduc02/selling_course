using Microsoft.AspNetCore.Mvc;

namespace selling_course.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CourseDetails()
        {
            return View();
        }
    }
}
