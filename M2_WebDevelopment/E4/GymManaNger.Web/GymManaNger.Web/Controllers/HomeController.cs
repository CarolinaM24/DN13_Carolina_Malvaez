using Microsoft.AspNetCore.Mvc;

namespace GymManaNger.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Home()
        {
            return View();

        }


    }
}
