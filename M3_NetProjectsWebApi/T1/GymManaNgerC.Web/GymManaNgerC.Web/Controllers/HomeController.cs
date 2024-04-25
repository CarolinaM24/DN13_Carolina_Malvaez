using Microsoft.AspNetCore.Mvc;

namespace GymManaNgerC.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
