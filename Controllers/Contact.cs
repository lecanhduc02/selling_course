using Microsoft.AspNetCore.Mvc;

namespace selling_course.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
