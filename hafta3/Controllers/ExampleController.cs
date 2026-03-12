using Microsoft.AspNetCore.Mvc;

namespace hafta3.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult pageWithOutLayout()
        {
            return View();
        }
    }
}
